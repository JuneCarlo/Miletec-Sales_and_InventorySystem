namespace Miletec_Sales_and_Inventory
{
    partial class frm_DamagesAndReplacement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DamagesAndReplacement));
            this.gbTransaction = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvViewTransaction = new System.Windows.Forms.DataGridView();
            this.deliveryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCustomerDeliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDeliveryReplacement = new Miletec_Sales_and_Inventory.CustomerDeliveryReplacement();
            this.gbDandR = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTransactionDetails = new System.Windows.Forms.DataGridView();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.txtDeliveryNo = new System.Windows.Forms.TextBox();
            this.txtNoofDamages = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTransactionID = new System.Windows.Forms.TextBox();
            this.txtReplacementNo = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvReplacements = new System.Windows.Forms.DataGridView();
            this.prodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcustomertransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTransaction = new Miletec_Sales_and_Inventory.CustomerTransaction();
            this.tblcustomertransactionTableAdapter = new Miletec_Sales_and_Inventory.CustomerTransactionTableAdapters.tblcustomertransactionTableAdapter();
            this.miletecDataSet6 = new Miletec_Sales_and_Inventory.MiletecDataSet6();
            this.miletecDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustomerDeliveryTableAdapter = new Miletec_Sales_and_Inventory.CustomerDeliveryReplacementTableAdapters.tblCustomerDeliveryTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.gbTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerDeliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDeliveryReplacement)).BeginInit();
            this.gbDandR.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDetails)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReplacements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomertransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet6BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTransaction
            // 
            this.gbTransaction.BackColor = System.Drawing.Color.Transparent;
            this.gbTransaction.Controls.Add(this.btnCancel);
            this.gbTransaction.Controls.Add(this.btnProceed);
            this.gbTransaction.Controls.Add(this.label1);
            this.gbTransaction.Controls.Add(this.textBox1);
            this.gbTransaction.Controls.Add(this.dgvViewTransaction);
            this.gbTransaction.Location = new System.Drawing.Point(27, 54);
            this.gbTransaction.Name = "gbTransaction";
            this.gbTransaction.Size = new System.Drawing.Size(670, 487);
            this.gbTransaction.TabIndex = 0;
            this.gbTransaction.TabStop = false;
            this.gbTransaction.Text = "View Transaction";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(15, 447);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProceed.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Location = new System.Drawing.Point(553, 447);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(113, 34);
            this.btnProceed.TabIndex = 3;
            this.btnProceed.Text = "PROCEED";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Transaction:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dgvViewTransaction
            // 
            this.dgvViewTransaction.AllowUserToAddRows = false;
            this.dgvViewTransaction.AllowUserToDeleteRows = false;
            this.dgvViewTransaction.AllowUserToResizeColumns = false;
            this.dgvViewTransaction.AllowUserToResizeRows = false;
            this.dgvViewTransaction.AutoGenerateColumns = false;
            this.dgvViewTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliveryIDDataGridViewTextBoxColumn,
            this.transactionidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.preparedbyDataGridViewTextBoxColumn});
            this.dgvViewTransaction.DataSource = this.tblCustomerDeliveryBindingSource;
            this.dgvViewTransaction.Location = new System.Drawing.Point(15, 58);
            this.dgvViewTransaction.Name = "dgvViewTransaction";
            this.dgvViewTransaction.ReadOnly = true;
            this.dgvViewTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewTransaction.Size = new System.Drawing.Size(651, 383);
            this.dgvViewTransaction.TabIndex = 0;
            this.dgvViewTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewTransaction_CellClick);
            this.dgvViewTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewTransaction_CellContentClick);
            // 
            // deliveryIDDataGridViewTextBoxColumn
            // 
            this.deliveryIDDataGridViewTextBoxColumn.DataPropertyName = "DeliveryID";
            this.deliveryIDDataGridViewTextBoxColumn.HeaderText = "Delivery No.";
            this.deliveryIDDataGridViewTextBoxColumn.Name = "deliveryIDDataGridViewTextBoxColumn";
            this.deliveryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionidDataGridViewTextBoxColumn
            // 
            this.transactionidDataGridViewTextBoxColumn.DataPropertyName = "transactionid";
            this.transactionidDataGridViewTextBoxColumn.HeaderText = "Transaction ID";
            this.transactionidDataGridViewTextBoxColumn.Name = "transactionidDataGridViewTextBoxColumn";
            this.transactionidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date(Delivery)";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preparedbyDataGridViewTextBoxColumn
            // 
            this.preparedbyDataGridViewTextBoxColumn.DataPropertyName = "preparedby";
            this.preparedbyDataGridViewTextBoxColumn.HeaderText = "Prepared By";
            this.preparedbyDataGridViewTextBoxColumn.Name = "preparedbyDataGridViewTextBoxColumn";
            this.preparedbyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblCustomerDeliveryBindingSource
            // 
            this.tblCustomerDeliveryBindingSource.DataMember = "tblCustomerDelivery";
            this.tblCustomerDeliveryBindingSource.DataSource = this.customerDeliveryReplacement;
            // 
            // customerDeliveryReplacement
            // 
            this.customerDeliveryReplacement.DataSetName = "CustomerDeliveryReplacement";
            this.customerDeliveryReplacement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbDandR
            // 
            this.gbDandR.BackColor = System.Drawing.Color.Transparent;
            this.gbDandR.Controls.Add(this.groupBox1);
            this.gbDandR.Controls.Add(this.groupBox2);
            this.gbDandR.Location = new System.Drawing.Point(27, 54);
            this.gbDandR.Name = "gbDandR";
            this.gbDandR.Size = new System.Drawing.Size(670, 488);
            this.gbDandR.TabIndex = 5;
            this.gbDandR.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTransactionDetails);
            this.groupBox1.Controls.Add(this.txtproductid);
            this.groupBox1.Controls.Add(this.txtDeliveryNo);
            this.groupBox1.Controls.Add(this.txtNoofDamages);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtTransactionID);
            this.groupBox1.Controls.Add(this.txtReplacementNo);
            this.groupBox1.Controls.Add(this.btnReplace);
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvTransactionDetails
            // 
            this.dgvTransactionDetails.AllowUserToAddRows = false;
            this.dgvTransactionDetails.AllowUserToDeleteRows = false;
            this.dgvTransactionDetails.AllowUserToResizeColumns = false;
            this.dgvTransactionDetails.AllowUserToResizeRows = false;
            this.dgvTransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionDetails.Location = new System.Drawing.Point(239, 21);
            this.dgvTransactionDetails.Name = "dgvTransactionDetails";
            this.dgvTransactionDetails.ReadOnly = true;
            this.dgvTransactionDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactionDetails.Size = new System.Drawing.Size(393, 177);
            this.dgvTransactionDetails.TabIndex = 0;
            this.dgvTransactionDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactionDetails_CellClick);
            this.dgvTransactionDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactionDetails_CellContentClick);
            // 
            // txtproductid
            // 
            this.txtproductid.Location = new System.Drawing.Point(360, 156);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(100, 20);
            this.txtproductid.TabIndex = 7;
            // 
            // txtDeliveryNo
            // 
            this.txtDeliveryNo.Enabled = false;
            this.txtDeliveryNo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryNo.Location = new System.Drawing.Point(9, 124);
            this.txtDeliveryNo.Name = "txtDeliveryNo";
            this.txtDeliveryNo.Size = new System.Drawing.Size(153, 26);
            this.txtDeliveryNo.TabIndex = 6;
            this.txtDeliveryNo.Text = "Delivery No.";
            this.txtDeliveryNo.TextChanged += new System.EventHandler(this.txtDeliveryNo_TextChanged);
            // 
            // txtNoofDamages
            // 
            this.txtNoofDamages.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoofDamages.Location = new System.Drawing.Point(9, 172);
            this.txtNoofDamages.Name = "txtNoofDamages";
            this.txtNoofDamages.Size = new System.Drawing.Size(213, 26);
            this.txtNoofDamages.TabIndex = 5;
            this.txtNoofDamages.Text = "Damages(Quantity)";
            this.txtNoofDamages.Click += new System.EventHandler(this.txtNoofDamages_Click);
            this.txtNoofDamages.Leave += new System.EventHandler(this.txtNoofDamages_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(168, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 27);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTransactionID
            // 
            this.txtTransactionID.Enabled = false;
            this.txtTransactionID.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactionID.Location = new System.Drawing.Point(6, 78);
            this.txtTransactionID.Name = "txtTransactionID";
            this.txtTransactionID.Size = new System.Drawing.Size(213, 26);
            this.txtTransactionID.TabIndex = 2;
            this.txtTransactionID.Text = "Transaction ID";
            this.txtTransactionID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtReplacementNo
            // 
            this.txtReplacementNo.Enabled = false;
            this.txtReplacementNo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReplacementNo.Location = new System.Drawing.Point(6, 35);
            this.txtReplacementNo.Name = "txtReplacementNo";
            this.txtReplacementNo.Size = new System.Drawing.Size(213, 26);
            this.txtReplacementNo.TabIndex = 2;
            this.txtReplacementNo.Text = "Replacement No.";
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnReplace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReplace.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.ForeColor = System.Drawing.Color.White;
            this.btnReplace.Location = new System.Drawing.Point(506, 207);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(126, 27);
            this.btnReplace.TabIndex = 1;
            this.btnReplace.Text = "REPLACE";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.dgvReplacements);
            this.groupBox2.Location = new System.Drawing.Point(11, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(24, 189);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 27);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "CANCEL";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(529, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 27);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvReplacements
            // 
            this.dgvReplacements.AllowUserToAddRows = false;
            this.dgvReplacements.AllowUserToDeleteRows = false;
            this.dgvReplacements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReplacements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReplacements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodID,
            this.ProdName,
            this.Quantity});
            this.dgvReplacements.Location = new System.Drawing.Point(23, 15);
            this.dgvReplacements.Name = "dgvReplacements";
            this.dgvReplacements.ReadOnly = true;
            this.dgvReplacements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReplacements.Size = new System.Drawing.Size(599, 162);
            this.dgvReplacements.TabIndex = 5;
            // 
            // prodID
            // 
            this.prodID.HeaderText = "Product ID";
            this.prodID.Name = "prodID";
            this.prodID.ReadOnly = true;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "Product Name";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "     Quantity (Replacement)";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // tblcustomertransactionBindingSource
            // 
            this.tblcustomertransactionBindingSource.DataMember = "tblcustomertransaction";
            this.tblcustomertransactionBindingSource.DataSource = this.customerTransaction;
            // 
            // customerTransaction
            // 
            this.customerTransaction.DataSetName = "CustomerTransaction";
            this.customerTransaction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcustomertransactionTableAdapter
            // 
            this.tblcustomertransactionTableAdapter.ClearBeforeFill = true;
            // 
            // miletecDataSet6
            // 
            this.miletecDataSet6.DataSetName = "MiletecDataSet6";
            this.miletecDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // miletecDataSet6BindingSource
            // 
            this.miletecDataSet6BindingSource.DataSource = this.miletecDataSet6;
            this.miletecDataSet6BindingSource.Position = 0;
            // 
            // tblCustomerDeliveryTableAdapter
            // 
            this.tblCustomerDeliveryTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(697, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // frm_DamagesAndReplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(723, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbDandR);
            this.Controls.Add(this.gbTransaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DamagesAndReplacement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DamagesAndReplacement";
            this.Load += new System.EventHandler(this.frm_DamagesAndReplacement_Load);
            this.gbTransaction.ResumeLayout(false);
            this.gbTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerDeliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDeliveryReplacement)).EndInit();
            this.gbDandR.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDetails)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReplacements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomertransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet6BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTransaction;
        private System.Windows.Forms.DataGridView dgvViewTransaction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private CustomerTransaction customerTransaction;
        private System.Windows.Forms.BindingSource tblcustomertransactionBindingSource;
        private CustomerTransactionTableAdapters.tblcustomertransactionTableAdapter tblcustomertransactionTableAdapter;
        private System.Windows.Forms.GroupBox gbDandR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTransactionID;
        private System.Windows.Forms.TextBox txtReplacementNo;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.DataGridView dgvTransactionDetails;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvReplacements;
        private System.Windows.Forms.TextBox txtNoofDamages;
        private System.Windows.Forms.TextBox txtDeliveryNo;
        private System.Windows.Forms.BindingSource miletecDataSet6BindingSource;
        private MiletecDataSet6 miletecDataSet6;
        private CustomerDeliveryReplacement customerDeliveryReplacement;
        private System.Windows.Forms.BindingSource tblCustomerDeliveryBindingSource;
        private CustomerDeliveryReplacementTableAdapters.tblCustomerDeliveryTableAdapter tblCustomerDeliveryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparedbyDataGridViewTextBoxColumn;
    }
}