using Billing.OSE.Data;
using Billing.OSE.Dto;
using Billing.OSE.Entities.Base;
using Billing.OSE.IService;
using Billing.OSE.Service;
using Facturacion.OSE.IServicio;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing.OSE.UI.MonitorApp
{
    public partial class frmSendBill : Form
    {
        //IDocumentService service = null;
        Serializator serializator = null;
        string cdrDir = "";
        DateTime OseInitDate;
        public frmSendBill()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            serializator = new Serializator();

            OseInitDate = Convert.ToDateTime(ConfigurationManager.AppSettings["OseInitDate"]);
            cdrDir = ConfigurationManager.AppSettings["CDRPath"];

            var cdrBolDir = Path.Combine(cdrDir, BillingConstant.DocumentTypeBoleta);
            if (!Directory.Exists(cdrBolDir))
            {
                Directory.CreateDirectory(cdrBolDir);
            }

            var cdrFactDir = Path.Combine(cdrDir, BillingConstant.DocumentTypeFactura);
            if (!Directory.Exists(cdrFactDir))
            {
                Directory.CreateDirectory(cdrFactDir);
            }


        }

        private void SendFacturas()
        {
            SendBilling(BillingConstant.DocumentTypeFactura,
                ConfigurationManager.AppSettings["facturasDir"]
                );
        }

        private void SendBoletas()
        {
            SendBilling(BillingConstant.DocumentTypeBoleta,
                ConfigurationManager.AppSettings["boletasDir"]
                );
        }

        private void SendBilling(string documentType, string documentTypePath)
        {
            var da = new BillDocumentDA();

            var documentsSent = da.GetDocumentStatus(documentType);

            //Leer archivos
            // Only get files that begin with the letter "c".
            List<string> files = Directory.GetFiles
                            (documentTypePath, "*.xml").ToList();

            var filesGroups = GeneratGroups(files);

            foreach (var grupoFiles in filesGroups)
            {
                Parallel.ForEach(grupoFiles, async (currentFile) =>
                {
                    string fileName = Path.GetFileNameWithoutExtension(currentFile);


                    byte[] fileContent = System.IO.File.ReadAllBytes(currentFile);


                    BillDocumentSummary documentSummary = await serializator.ReadDocumentXML(fileContent);

                    //If already,dont sent
                    if (documentSummary.DocumentIssueDate > OseInitDate && documentsSent.Exists(item => item.DocumentNumber == documentSummary.DocumentNumber))
                    {
                        return;
                    }


                    var billDoc = new BillDocument();

                    //Fill document basic information 
                    billDoc.DocumentNumber = documentSummary.DocumentNumber;
                    billDoc.DocumentIssueDate = new DateTime(documentSummary.DocumentIssueDate.Year,
                    documentSummary.DocumentIssueDate.Month, documentSummary.DocumentIssueDate.Day,
                    documentSummary.DocumentIssueTime.Hour, documentSummary.DocumentIssueTime.Minute,
                    documentSummary.DocumentIssueTime.Second);

                    billDoc.CustomerDocumentType = documentSummary.CustomerDocumentType;
                    billDoc.CustomerDocumentNumber = documentSummary.CustomerDocumentNumber;
                    billDoc.CustomerName = documentSummary.CustomerDocumentType;
                    billDoc.CustomerAddress = documentSummary.CustomerAddress;
                    billDoc.InvoiceNote = documentSummary.InvoiceNote;
                    billDoc.InvoiceCurrency = documentSummary.InvoiceCurrency;
                    billDoc.TaxAmount = documentSummary.TaxAmount;
                    billDoc.TaxableAmount = documentSummary.TaxableAmount;
                    billDoc.TotalAmount = documentSummary.TotalAmount;

                    billDoc.SentDate = DateTime.Now;

                    var request = new SendRequest();
                    //Preparing information in order to send to OSE Service
                    request.FileName = $"{fileName}.zip";
                    request.ContentFile = await serializator.GenerateZip(fileContent, fileName);
                    //calling to ose webservices
                    IDocumentService service = new DocumentService();
                    service.Initializate();
                    var response = await service.SendBill(request);

                    billDoc.DocumentType = documentType;
                    billDoc.ResponseCode = response.ResponseCode;
                    billDoc.ResponseMessage = response.ResponseMessage;

                    if (response.Success)
                    {
                        billDoc.Status = (int)BillingConstant.BillingSentStatus.Success;
                        billDoc.CDRFileName = response.CDRFileName?.ToUpper().Replace(".XML", ".zip");

                        if (response.CDRFileContentZip != null && response.CDRFileContentZip.Length > 0)
                        {
                            string cdrGeneratedPath = Path.Combine(cdrDir, documentType, $"{billDoc.CDRFileName}");
                            File.WriteAllBytes(cdrGeneratedPath, response.CDRFileContentZip);
                        }

                        //if (response.DocumentIssueDate != null)
                        //    billDoc.DocumentIssueDate = new DateTime(response.DocumentIssueDate.Year,
                        //        response.DocumentIssueDate.Month, response.DocumentIssueDate.Day,
                        //        response.DocumentIssueTime.Hour, response.DocumentIssueTime.Minute,
                        //        response.DocumentIssueTime.Second);
                    }
                    else
                    {
                        billDoc.Status = (int)BillingConstant.BillingSentStatus.Error;
                    }

                    da.AddDocument(billDoc);

                });

                Thread.Sleep(2000);
            }
        }

        private List<List<string>> GeneratGroups(List<string> files)
        {
            int cantidadXGrupo = 10;

            if (ConfigurationManager.AppSettings["GruposCantidad"] != null)
                cantidadXGrupo = Convert.ToInt32(ConfigurationManager.AppSettings["GruposCantidad"]);


            var grupos = new List<List<string>>();
            List<string> grupo = new List<string>();

            for (var i = 0; i < files.Count; i++)
            {

                grupo.Add(files[i]);

                if (i > 0 && (i + 1) % cantidadXGrupo == 0)
                {
                    grupos.Add(grupo);
                    grupo = new List<string>();
                }
            }

            if (grupo.Count > 0)
            {
                grupos.Add(grupo);
            }

            return grupos;
        }

        private void btnSendBilling_Click(object sender, EventArgs e)
        {
            SendBoletas();
        }

        private void btnSendFact_Click(object sender, EventArgs e)
        {
            SendFacturas();
        }
    }
}
