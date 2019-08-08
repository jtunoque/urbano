using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO.Compression;
using Billing.OSE.Dto;
using Billing.OSE.IService;

namespace Billing.OSE.Service
{
    public class Serializator
    {
        /// <summary>
        /// Genera el ZIP del XML basandose en la trama del XML.
        /// </summary>
        /// <param name="tramaXml">Cadena Base64 con el contenido del XML</param>
        /// <param name="nombreArchivo">Nombre del archivo ZIP</param>
        /// <returns>Devuelve Cadena Base64 del archizo ZIP</returns>
        public async Task<string> GenerateZip(byte[] tramaXml, string nombreArchivo)
        {
            var task = Task.Factory.StartNew(() =>
            {
                string resultado;

                using (var memDestino = new MemoryStream())
                {
                    using (var ziparchive = new ZipArchive(memDestino, ZipArchiveMode.Create))
                    {

                        ZipArchiveEntry zipItem = ziparchive.CreateEntry($"{nombreArchivo}.xml");

                        using (Stream ZipFile = zipItem.Open())
                        {
                            byte[] data = tramaXml;
                            ZipFile.Write(data, 0, data.Length);
                        }
                    }

                    resultado = Convert.ToBase64String(memDestino.ToArray());
                }

                return resultado;
            });

            return await task;
        }

        /// <summary>
        /// Lee la Constancia de Recepción SUNAT y devuelve el contenido
        /// </summary>
        /// <param name="constanciaRecepcion">Trama ZIP del CDR</param>
        /// <returns>Devuelve una clase <see cref="EnviarDocumentoResponse"/></returns>
        public async Task<SendResponse> BillingResponseFormat(byte[] cdrFileContentZip)
        {
            var response = new SendResponse();
            using (var memRespuesta = new MemoryStream(cdrFileContentZip))
            {
                if (memRespuesta.Length <= 0)
                {
                    response.ResponseCode = null;
                    response.ResponseMessage = "Respuesta SUNAT Vacio";
                    response.Success = false;
                }
                else
                {
                    using (ZipArchive zipFile = new ZipArchive(memRespuesta, ZipArchiveMode.Read))
                    {
                        foreach (ZipArchiveEntry entry in zipFile.Entries)
                        {
                            if (!entry.Name.ToLower().EndsWith(".xml")) continue;
                            using (Stream ms = entry.Open())
                            {
                                var responseReader = new StreamReader(ms);
                                var responseString = await responseReader.ReadToEndAsync();
                                try
                                {
                                    var xmlDoc = new XmlDocument();
                                    xmlDoc.LoadXml(responseString);

                                    var xmlnsManager = new XmlNamespaceManager(xmlDoc.NameTable);

                                    xmlnsManager.AddNamespace("ar", XMLNameSpace.ar);
                                    xmlnsManager.AddNamespace("cac", XMLNameSpace.cac);
                                    xmlnsManager.AddNamespace("cbc", XMLNameSpace.cbc);

                                    response.ResponseCode =
                                        xmlDoc.SelectSingleNode(XMLNameSpace.nodoResponseCode,
                                            xmlnsManager)?.InnerText;

                                    response.ResponseMessage =
                                        xmlDoc.SelectSingleNode(XMLNameSpace.nodoDescription,
                                            xmlnsManager)?.InnerText;

                                    response.DocumentNumber =
                                        xmlDoc.SelectSingleNode(XMLNameSpace.nodoDocumentReferenceID,
                                            xmlnsManager)?.InnerText;

                                    response.DocumentIssueDate = Convert.ToDateTime(
                                        xmlDoc.SelectSingleNode(XMLNameSpace.nodoDocumentReferenceIssueDate,
                                            xmlnsManager)?.InnerText);

                                    response.DocumentIssueTime = Convert.ToDateTime(
                                        xmlDoc.SelectSingleNode(XMLNameSpace.nodoDocumentReferenceIssueTime,
                                            xmlnsManager)?.InnerText);

                                    response.DocumentType =
                                        xmlDoc.SelectSingleNode(XMLNameSpace.nodoDocumentReferenceDocumentTypeCode,
                                            xmlnsManager)?.InnerText;

                                    response.CDRFileContentZip = cdrFileContentZip;
                                    response.CDRFileName = entry.Name;
                                    response.Success = true;
                                }
                                catch (Exception ex)
                                {
                                    response.ResponseCode = null;
                                    response.ResponseMessage = ex.Message;
                                    //response.Pila = ex.StackTrace;
                                    response.Success = false;
                                }
                            }
                        }
                    }
                }
            }
            return response;
        }

        public async Task<BillDocumentSummary> ReadDocumentXML(byte[] documentXML)
        {
            var response = new BillDocumentSummary();
            using (var memRespuesta = new MemoryStream(documentXML))
            {
                var responseString = await new StreamReader(memRespuesta).ReadToEndAsync();

                var xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(responseString);

                var xmlnsManager = new XmlNamespaceManager(xmlDoc.NameTable);

                xmlnsManager.AddNamespace("inv", XMLNameSpace.xmlnsInvoice);
                xmlnsManager.AddNamespace("cac", XMLNameSpace.cac);
                xmlnsManager.AddNamespace("cbc", XMLNameSpace.cbc);
                xmlnsManager.AddNamespace("ccts", XMLNameSpace.ccts);
                xmlnsManager.AddNamespace("ds", XMLNameSpace.ds);
                xmlnsManager.AddNamespace("ext", XMLNameSpace.ext);
                xmlnsManager.AddNamespace("qdt", XMLNameSpace.qdt);
                xmlnsManager.AddNamespace("udt", XMLNameSpace.udt);
                xmlnsManager.AddNamespace("xsi", XMLNameSpace.xsi);

                response.DocumentNumber =
                    xmlDoc.SelectSingleNode(XMLNameSpace.nodoInvoiceID,
                        xmlnsManager)?.InnerText;

                response.DocumentIssueDate =
                    Convert.ToDateTime(xmlDoc.SelectSingleNode(XMLNameSpace.nodeInvoiceIssueDate,
                        xmlnsManager)?.InnerText);

                response.DocumentIssueTime =
                    Convert.ToDateTime(xmlDoc.SelectSingleNode(XMLNameSpace.nodeInvoiceIssueTime,
                        xmlnsManager)?.InnerText);

                var customerIDNode = xmlDoc.SelectSingleNode(XMLNameSpace.nodeCustomerID,
                        xmlnsManager);

                if (customerIDNode != null)
                {
                    response.CustomerDocumentType = customerIDNode.Attributes["schemeID"].Value;
                    response.CustomerDocumentNumber = customerIDNode.InnerText;
                }
                else
                {
                    response.CustomerDocumentType = xmlDoc.SelectSingleNode(XMLNameSpace.nodeAdditionalAccountID,
                       xmlnsManager)?.InnerText;

                    response.CustomerDocumentNumber = xmlDoc.SelectSingleNode(XMLNameSpace.nodeCustomerAssignedAccountID,
                       xmlnsManager)?.InnerText;
                }

                response.CustomerName = xmlDoc.SelectSingleNode(XMLNameSpace.nodeCustomerName,
                        xmlnsManager)?.InnerText;

                response.CustomerAddress = xmlDoc.SelectSingleNode(XMLNameSpace.nodeCustomerAddress,
                        xmlnsManager)?.InnerText;

                response.TaxableAmount =
                   Convert.ToDouble(xmlDoc.SelectSingleNode(XMLNameSpace.nodeTaxableAmount,
                       xmlnsManager)?.InnerText);

                response.TaxAmount =
                   Convert.ToDouble(xmlDoc.SelectSingleNode(XMLNameSpace.nodeTaxAmount,
                       xmlnsManager)?.InnerText);



                var totalAmountNode = xmlDoc.SelectSingleNode(XMLNameSpace.nodePayableAmount,
                       xmlnsManager);

                response.TotalAmount = Convert.ToDouble(totalAmountNode.InnerText);
                response.InvoiceCurrency = totalAmountNode.Attributes["currencyID"].Value;

                response.InvoiceNote = xmlDoc.SelectSingleNode(XMLNameSpace.nodeNote1,
                        xmlnsManager)?.InnerText;


                var lineNodes = xmlDoc.SelectNodes(XMLNameSpace.nodeInvoiceLine,
                       xmlnsManager);


                foreach (var line in lineNodes)
                {

                }

            }
            return response;
        }
    }
}