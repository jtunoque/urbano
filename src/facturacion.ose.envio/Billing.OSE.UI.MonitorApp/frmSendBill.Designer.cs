namespace Billing.OSE.UI.MonitorApp
{
    partial class frmSendBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSendBilling = new System.Windows.Forms.Button();
            this.btnSendFact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendBilling
            // 
            this.btnSendBilling.Location = new System.Drawing.Point(25, 12);
            this.btnSendBilling.Name = "btnSendBilling";
            this.btnSendBilling.Size = new System.Drawing.Size(247, 41);
            this.btnSendBilling.TabIndex = 0;
            this.btnSendBilling.Text = "Enviar Boletas";
            this.btnSendBilling.UseVisualStyleBackColor = true;
            this.btnSendBilling.Click += new System.EventHandler(this.btnSendBilling_Click);
            // 
            // btnSendFact
            // 
            this.btnSendFact.Location = new System.Drawing.Point(25, 71);
            this.btnSendFact.Name = "btnSendFact";
            this.btnSendFact.Size = new System.Drawing.Size(247, 41);
            this.btnSendFact.TabIndex = 1;
            this.btnSendFact.Text = "Enviar Facturas";
            this.btnSendFact.UseVisualStyleBackColor = true;
            this.btnSendFact.Click += new System.EventHandler(this.btnSendFact_Click);
            // 
            // frmSendBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 136);
            this.Controls.Add(this.btnSendFact);
            this.Controls.Add(this.btnSendBilling);
            this.Name = "frmSendBill";
            this.Text = "frmSendBill";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSendBilling;
        private System.Windows.Forms.Button btnSendFact;
    }
}