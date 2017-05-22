namespace Miletec_Sales_and_Inventory
{
    partial class frm_installation_customerService
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_installation_customerService));
            this.gbinstallation = new System.Windows.Forms.GroupBox();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dgvinstallation = new System.Windows.Forms.DataGridView();
            this.tblcustomertransactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.frm_installation = new Miletec_Sales_and_Inventory.frm_installation();
            this.miletecDataSet11 = new Miletec_Sales_and_Inventory.MiletecDataSet11();
            this.tblcustomertransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblcustomertransactionTableAdapter = new Miletec_Sales_and_Inventory.MiletecDataSet11TableAdapters.tblcustomertransactionTableAdapter();
            this.tblcustomertransactionTableAdapter1 = new Miletec_Sales_and_Inventory.frm_installationTableAdapters.tblcustomertransactionTableAdapter();
            this.lblclose = new System.Windows.Forms.Label();
            this.gbinstallation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomertransactionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frm_installation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomertransactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbinstallation
            // 
            this.gbinstallation.BackColor = System.Drawing.Color.Transparent;
            this.gbinstallation.Controls.Add(this.dtpdate);
            this.gbinstallation.Controls.Add(this.lblsearch);
            this.gbinstallation.Controls.Add(this.txtsearch);
            this.gbinstallation.Controls.Add(this.dgvinstallation);
            this.gbinstallation.Location = new System.Drawing.Point(12, 64);
            this.gbinstallation.Name = "gbinstallation";
            this.gbinstallation.Size = new System.Drawing.Size(697, 286);
            this.gbinstallation.TabIndex = 3;
            this.gbinstallation.TabStop = false;
            this.gbinstallation.Text = " ";
            // 
            // dtpdate
            // 
            this.dtpdate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate.Location = new System.Drawing.Point(397, 17);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(276, 26);
            this.dtpdate.TabIndex = 8;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.Color.White;
            this.lblsearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(17, 32);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(59, 18);
            this.lblsearch.TabIndex = 5;
            this.lblsearch.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(13, 29);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(231, 26);
            this.txtsearch.TabIndex = 4;
            this.txtsearch.Click += new System.EventHandler(this.txtsearch_Click);
            this.txtsearch.Leave += new System.EventHandler(this.txtsearch_Leave);
            // 
            // dgvinstallation
            // 
            this.dgvinstallation.AllowUserToAddRows = false;
            this.dgvinstallation.AllowUserToDeleteRows = false;
            this.dgvinstallation.AllowUserToResizeColumns = false;
            this.dgvinstallation.AllowUserToResizeRows = false;
            this.dgvinstallation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinstallation.Location = new System.Drawing.Point(13, 65);
            this.dgvinstallation.Name = "dgvinstallation";
            this.dgvinstallation.ReadOnly = true;
            this.dgvinstallation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvinstallation.Size = new System.Drawing.Size(660, 174);
            this.dgvinstallation.TabIndex = 3;
            this.dgvinstallation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinstallation_CellContentClick);
            // 
            // tblcustomertransactionBindingSource1
            // 
            this.tblcustomertransactionBindingSource1.DataMember = "tblcustomertransaction";
            this.tblcustomertransactionBindingSource1.DataSource = this.frm_installation;
            // 
            // frm_installation
            // 
            this.frm_installation.DataSetName = "frm_installation";
            this.frm_installation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // miletecDataSet11
            // 
            this.miletecDataSet11.DataSetName = "MiletecDataSet11";
            this.miletecDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcustomertransactionBindingSource
            // 
            this.tblcustomertransactionBindingSource.DataMember = "tblcustomertransaction";
            this.tblcustomertransactionBindingSource.DataSource = this.miletecDataSet11;
            // 
            // tblcustomertransactionTableAdapter
            // 
            this.tblcustomertransactionTableAdapter.ClearBeforeFill = true;
            // 
            // tblcustomertransactionTableAdapter1
            // 
            this.tblcustomertransactionTableAdapter1.ClearBeforeFill = true;
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.BackColor = System.Drawing.Color.Transparent;
            this.lblclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblclose.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclose.ForeColor = System.Drawing.Color.White;
            this.lblclose.Location = new System.Drawing.Point(703, 20);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(23, 23);
            this.lblclose.TabIndex = 5;
            this.lblclose.Text = "X";
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // frm_installation_customerService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(731, 394);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.gbinstallation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_installation_customerService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_installation_customerService_Load);
            this.gbinstallation.ResumeLayout(false);
            this.gbinstallation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstallation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomertransactionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frm_installation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomertransactionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbinstallation;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dgvinstallation;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private MiletecDataSet11 miletecDataSet11;
        private System.Windows.Forms.BindingSource tblcustomertransactionBindingSource;
        private MiletecDataSet11TableAdapters.tblcustomertransactionTableAdapter tblcustomertransactionTableAdapter;
        private frm_installation frm_installation;
        private System.Windows.Forms.BindingSource tblcustomertransactionBindingSource1;
        private frm_installationTableAdapters.tblcustomertransactionTableAdapter tblcustomertransactionTableAdapter1;
        private System.Windows.Forms.Label lblclose;
    }
}