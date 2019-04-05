namespace GitTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnPull = new System.Windows.Forms.Button();
            this.btnFetch = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.listViewRepositoryList = new System.Windows.Forms.ListView();
            this.clmnCheckBox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RepositoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtOutPut = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1013, 37);
            this.panelHeader.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCommit);
            this.panel1.Controls.Add(this.btnPull);
            this.panel1.Controls.Add(this.btnFetch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 47);
            this.panel1.TabIndex = 1;
            // 
            // btnCommit
            // 
            this.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCommit.Location = new System.Drawing.Point(892, 7);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(108, 27);
            this.btnCommit.TabIndex = 2;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            // 
            // btnPull
            // 
            this.btnPull.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPull.Location = new System.Drawing.Point(757, 7);
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(108, 27);
            this.btnPull.TabIndex = 1;
            this.btnPull.Text = "Pull";
            this.btnPull.UseVisualStyleBackColor = true;
            this.btnPull.Click += new System.EventHandler(this.btnPull_Click);
            // 
            // btnFetch
            // 
            this.btnFetch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFetch.Location = new System.Drawing.Point(622, 7);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(108, 27);
            this.btnFetch.TabIndex = 1;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 37);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.listViewRepositoryList);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.txtOutPut);
            this.splitContainer.Size = new System.Drawing.Size(1013, 407);
            this.splitContainer.SplitterDistance = 750;
            this.splitContainer.TabIndex = 2;
            // 
            // listViewRepositoryList
            // 
            this.listViewRepositoryList.CheckBoxes = true;
            this.listViewRepositoryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnCheckBox,
            this.RepositoryName});
            this.listViewRepositoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRepositoryList.Location = new System.Drawing.Point(0, 0);
            this.listViewRepositoryList.Name = "listViewRepositoryList";
            this.listViewRepositoryList.Size = new System.Drawing.Size(750, 407);
            this.listViewRepositoryList.TabIndex = 0;
            this.listViewRepositoryList.UseCompatibleStateImageBehavior = false;
            this.listViewRepositoryList.View = System.Windows.Forms.View.Details;
            // 
            // clmnCheckBox
            // 
            this.clmnCheckBox.Text = "Select";
            // 
            // RepositoryName
            // 
            this.RepositoryName.Text = "RepositoryName";
            // 
            // txtOutPut
            // 
            this.txtOutPut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutPut.Location = new System.Drawing.Point(0, 0);
            this.txtOutPut.Multiline = true;
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.Size = new System.Drawing.Size(259, 407);
            this.txtOutPut.TabIndex = 1;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 491);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.Name = "FrmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListView listViewRepositoryList;
        private System.Windows.Forms.TextBox txtOutPut;
        private System.Windows.Forms.Button btnPull;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.ColumnHeader clmnCheckBox;
        private System.Windows.Forms.ColumnHeader RepositoryName;
        private System.Windows.Forms.Button btnCommit;
    }
}

