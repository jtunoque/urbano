namespace Billing.OSE.UI.MonitorApp
{
    partial class frmConsultarEnvios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpDate1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.dcDocumentTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcDocumentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcDocumentIssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcSentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcStatusDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcResponseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcResponseMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcCDRFileName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboStatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNroDoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDate2);
            this.groupBox1.Controls.Add(this.dtpDate1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Todos",
            "Correctos",
            "Con error"});
            this.cboStatus.Location = new System.Drawing.Point(608, 19);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(99, 21);
            this.cboStatus.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado envío:";
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(431, 19);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(100, 20);
            this.txtNroDoc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número Documento:";
            // 
            // dtpDate2
            // 
            this.dtpDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate2.Location = new System.Drawing.Point(209, 19);
            this.dtpDate2.Name = "dtpDate2";
            this.dtpDate2.Size = new System.Drawing.Size(105, 20);
            this.dtpDate2.TabIndex = 3;
            // 
            // dtpDate1
            // 
            this.dtpDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate1.Location = new System.Drawing.Point(98, 19);
            this.dtpDate1.Name = "dtpDate1";
            this.dtpDate1.Size = new System.Drawing.Size(105, 20);
            this.dtpDate1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha envío:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(713, 13);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(131, 36);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListado);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(856, 395);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcDocumentTypeName,
            this.dcDocumentNumber,
            this.dcDocumentIssueDate,
            this.dcSentDate,
            this.dcStatusDescription,
            this.dcResponseCode,
            this.dcResponseMessage,
            this.dcCDRFileName});
            this.dgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListado.Location = new System.Drawing.Point(3, 16);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(850, 376);
            this.dgvListado.TabIndex = 0;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            // 
            // dcDocumentTypeName
            // 
            this.dcDocumentTypeName.DataPropertyName = "DocumentTypeName";
            this.dcDocumentTypeName.HeaderText = "Tipo de documento";
            this.dcDocumentTypeName.Name = "dcDocumentTypeName";
            this.dcDocumentTypeName.ReadOnly = true;
            // 
            // dcDocumentNumber
            // 
            this.dcDocumentNumber.DataPropertyName = "DocumentNumber";
            this.dcDocumentNumber.HeaderText = "Número del documento";
            this.dcDocumentNumber.Name = "dcDocumentNumber";
            this.dcDocumentNumber.ReadOnly = true;
            this.dcDocumentNumber.Width = 130;
            // 
            // dcDocumentIssueDate
            // 
            this.dcDocumentIssueDate.DataPropertyName = "DocumentIssueDate";
            this.dcDocumentIssueDate.HeaderText = "Fecha documento";
            this.dcDocumentIssueDate.Name = "dcDocumentIssueDate";
            this.dcDocumentIssueDate.ReadOnly = true;
            this.dcDocumentIssueDate.Width = 130;
            // 
            // dcSentDate
            // 
            this.dcSentDate.DataPropertyName = "SentDate";
            this.dcSentDate.HeaderText = "Fecha envío OSE";
            this.dcSentDate.Name = "dcSentDate";
            this.dcSentDate.ReadOnly = true;
            this.dcSentDate.Width = 130;
            // 
            // dcStatusDescription
            // 
            this.dcStatusDescription.DataPropertyName = "StatusDescription";
            this.dcStatusDescription.HeaderText = "Estado envío";
            this.dcStatusDescription.Name = "dcStatusDescription";
            this.dcStatusDescription.ReadOnly = true;
            // 
            // dcResponseCode
            // 
            this.dcResponseCode.DataPropertyName = "ResponseCode";
            this.dcResponseCode.HeaderText = "Código respuesta";
            this.dcResponseCode.Name = "dcResponseCode";
            this.dcResponseCode.ReadOnly = true;
            // 
            // dcResponseMessage
            // 
            this.dcResponseMessage.DataPropertyName = "ResponseMessage";
            this.dcResponseMessage.HeaderText = "Mensaje de respuesta";
            this.dcResponseMessage.Name = "dcResponseMessage";
            this.dcResponseMessage.ReadOnly = true;
            this.dcResponseMessage.Width = 350;
            // 
            // dcCDRFileName
            // 
            this.dcCDRFileName.DataPropertyName = "CDRFileName";
            this.dcCDRFileName.HeaderText = "CDR Archivo";
            this.dcCDRFileName.Name = "dcCDRFileName";
            this.dcCDRFileName.ReadOnly = true;
            this.dcCDRFileName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dcCDRFileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dcCDRFileName.Width = 150;
            // 
            // frmConsultarEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultarEnvios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmConsultarEnvios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DateTimePicker dtpDate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDate2;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcDocumentTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcDocumentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcDocumentIssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcSentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcStatusDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcResponseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcResponseMessage;
        private System.Windows.Forms.DataGridViewLinkColumn dcCDRFileName;
    }
}