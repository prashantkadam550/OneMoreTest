namespace EventOneTask
{
    partial class FrmHome
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSelector = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.chkFirebirdODBC = new System.Windows.Forms.CheckBox();
            this.chkMySQLODBC = new System.Windows.Forms.CheckBox();
            this.chkFoxPro = new System.Windows.Forms.CheckBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.prgbStatus = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.lstStatus = new System.Windows.Forms.ListView();
            this.clmnProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnDriver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnMoreInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelHeader.SuspendLayout();
            this.panelSelector.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1020, 54);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select one or more products and click install";
            // 
            // panelSelector
            // 
            this.panelSelector.Controls.Add(this.btnClose);
            this.panelSelector.Controls.Add(this.btnInstall);
            this.panelSelector.Controls.Add(this.chkFirebirdODBC);
            this.panelSelector.Controls.Add(this.chkMySQLODBC);
            this.panelSelector.Controls.Add(this.chkFoxPro);
            this.panelSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSelector.Location = new System.Drawing.Point(0, 54);
            this.panelSelector.Name = "panelSelector";
            this.panelSelector.Size = new System.Drawing.Size(1020, 48);
            this.panelSelector.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(1024, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Enabled = false;
            this.btnInstall.Location = new System.Drawing.Point(930, 12);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 3;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // chkFirebirdODBC
            // 
            this.chkFirebirdODBC.AutoSize = true;
            this.chkFirebirdODBC.Location = new System.Drawing.Point(306, 16);
            this.chkFirebirdODBC.Name = "chkFirebirdODBC";
            this.chkFirebirdODBC.Size = new System.Drawing.Size(93, 17);
            this.chkFirebirdODBC.TabIndex = 2;
            this.chkFirebirdODBC.Text = "Firebird ODBC";
            this.chkFirebirdODBC.UseVisualStyleBackColor = true;
            this.chkFirebirdODBC.CheckedChanged += new System.EventHandler(this.chkFirebirdODBC_CheckedChanged);
            // 
            // chkMySQLODBC
            // 
            this.chkMySQLODBC.AutoSize = true;
            this.chkMySQLODBC.Location = new System.Drawing.Point(207, 16);
            this.chkMySQLODBC.Name = "chkMySQLODBC";
            this.chkMySQLODBC.Size = new System.Drawing.Size(97, 17);
            this.chkMySQLODBC.TabIndex = 1;
            this.chkMySQLODBC.Text = "MySQL ODBC ";
            this.chkMySQLODBC.UseVisualStyleBackColor = true;
            this.chkMySQLODBC.CheckedChanged += new System.EventHandler(this.chkMySQLODBC_CheckedChanged);
            // 
            // chkFoxPro
            // 
            this.chkFoxPro.AutoSize = true;
            this.chkFoxPro.Location = new System.Drawing.Point(23, 16);
            this.chkFoxPro.Name = "chkFoxPro";
            this.chkFoxPro.Size = new System.Drawing.Size(175, 17);
            this.chkFoxPro.TabIndex = 0;
            this.chkFoxPro.Text = "Microsoft Visual FoxPro OLEDB";
            this.chkFoxPro.UseVisualStyleBackColor = true;
            this.chkFoxPro.CheckedChanged += new System.EventHandler(this.chkFoxPro_CheckedChanged);
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.prgbStatus);
            this.panelFooter.Controls.Add(this.lblProgress);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 322);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1020, 32);
            this.panelFooter.TabIndex = 2;
            // 
            // prgbStatus
            // 
            this.prgbStatus.Location = new System.Drawing.Point(76, 4);
            this.prgbStatus.Name = "prgbStatus";
            this.prgbStatus.Size = new System.Drawing.Size(1024, 23);
            this.prgbStatus.TabIndex = 1;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(13, 7);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(41, 17);
            this.lblProgress.TabIndex = 0;
            this.lblProgress.Text = "0 / 0";
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.lstStatus);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 102);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1020, 220);
            this.panelBody.TabIndex = 3;
            // 
            // lstStatus
            // 
            this.lstStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnProduct,
            this.clmnDriver,
            this.clmnStatus,
            this.clmnMoreInfo});
            this.lstStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStatus.Location = new System.Drawing.Point(0, 0);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(1020, 220);
            this.lstStatus.TabIndex = 0;
            this.lstStatus.UseCompatibleStateImageBehavior = false;
            this.lstStatus.View = System.Windows.Forms.View.Details;
            // 
            // clmnProduct
            // 
            this.clmnProduct.Text = "Product";
            this.clmnProduct.Width = 300;
            // 
            // clmnDriver
            // 
            this.clmnDriver.Text = "Driver";
            this.clmnDriver.Width = 300;
            // 
            // clmnStatus
            // 
            this.clmnStatus.Text = "Status";
            this.clmnStatus.Width = 100;
            // 
            // clmnMoreInfo
            // 
            this.clmnMoreInfo.Text = "More Info";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1020, 354);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelSelector);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmHome";
            this.Text = "Database Driver Installer";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSelector.ResumeLayout(false);
            this.panelSelector.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSelector;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.CheckBox chkFirebirdODBC;
        private System.Windows.Forms.CheckBox chkMySQLODBC;
        private System.Windows.Forms.CheckBox chkFoxPro;
        private System.Windows.Forms.ListView lstStatus;
        private System.Windows.Forms.ColumnHeader clmnProduct;
        private System.Windows.Forms.ColumnHeader clmnDriver;
        private System.Windows.Forms.ColumnHeader clmnStatus;
        private System.Windows.Forms.ColumnHeader clmnMoreInfo;
        private System.Windows.Forms.ProgressBar prgbStatus;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInstall;
    }
}

