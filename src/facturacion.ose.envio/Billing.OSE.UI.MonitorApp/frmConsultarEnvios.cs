using Billing.OSE.Data;
using Billing.OSE.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing.OSE.UI.MonitorApp
{
    public partial class frmConsultarEnvios : Form
    {
        public frmConsultarEnvios()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            dgvListado.AutoGenerateColumns = false;
            cboStatus.SelectedIndex = 0;
            Consultar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Consultar()
        {
            var date1 = new DateTime(dtpDate1.Value.Year, dtpDate1.Value.Month, dtpDate1.Value.Day,0,0,0,1);
            var date2 = new DateTime(dtpDate2.Value.Year, dtpDate2.Value.Month, dtpDate2.Value.Day, 23, 59, 59, 999);
            var status = cboStatus.SelectedIndex;
            var documentNumber = txtNroDoc.Text.Trim();

            var da = new BillDocumentDA();
            var data = da.GetDocuments(date1,date2,status,documentNumber);

            dgvListado.DataSource = data;
            dgvListado.Refresh();


        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // if current cell is DataGridViewLinkCell

            try
            {
                if (dgvListado[e.ColumnIndex, e.RowIndex].GetType() == typeof(DataGridViewLinkCell))

                {
                    var dataItem = (BillQuery)dgvListado.Rows[e.RowIndex].DataBoundItem;
                    var cdrDir = ConfigurationManager.AppSettings["CDRPath"];
                    string filePath = Path.Combine(cdrDir,dataItem.DocumentType,dataItem.CDRFileName);

                    System.Diagnostics.Process.Start(filePath);

                }
            }
            catch
            {

            }
        }
    }
}
