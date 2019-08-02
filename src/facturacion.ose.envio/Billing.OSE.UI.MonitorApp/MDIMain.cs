using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing.OSE.UI.MonitorApp
{
    public partial class MDIMain : Form
    {
        public MDIMain()
        {
            InitializeComponent();

            OpenForm(new frmSendBill());
        }



        private void mnuSendBill_Click(object sender, EventArgs e)
        {
            OpenForm(new frmSendBill());
        }

        private void OpenForm(Form frm)
        {

           foreach (Form frmOpen in Application.OpenForms)
            {
                //iterate through
                if (frmOpen.Name == frm.Name)
                {
                    return;
                }
            }
            frm.MdiParent = this;
            frm.Show();
        }

        private void consultarEnvíosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new frmConsultarEnvios());
        }
    }
}
