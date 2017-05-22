namespace Miletec_Sales_and_Inventory
{
    partial class frm_Customer_Delivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Customer_Delivery));
            this.gbDelivery = new System.Windows.Forms.GroupBox();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProductDetails = new System.Windows.Forms.DataGridView();
            this.txttimetodeliver = new System.Windows.Forms.TextBox();
            this.txtdatetodeliver = new System.Windows.Forms.TextBox();
            this.txtcusID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txttransactionid = new System.Windows.Forms.TextBox();
            this.txtDateOrdered = new System.Windows.Forms.TextBox();
            this.txtPreparedBy = new System.Windows.Forms.TextBox();
            this.gbminidelivery = new System.Windows.Forms.GroupBox();
            this.dgvDeliverditems = new System.Windows.Forms.DataGridView();
            this.ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateToDel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblreceivedby = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbOrderDetails = new System.Windows.Forms.GroupBox();
            this.btnCancelOrderDetails = new System.Windows.Forms.Button();
            this.btnProceedOrderDet = new System.Windows.Forms.Button();
            this.lblsearch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvviewtransactiondetails = new System.Windows.Forms.DataGridView();
            this.transactionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcustomertransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miletecDataSet3 = new Miletec_Sales_and_Inventory.MiletecDataSet3();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtDeliveryNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tblcustomertransactionTableAdapter = new Miletec_Sales_and_Inventory.MiletecDataSet3TableAdapters.tblcustomertransactionTableAdapter();
            this.gbDelivery.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).BeginInit();
            this.gbminidelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverditems)).BeginInit();
            this.gbOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewtransactiondetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomertransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDelivery
            // 
            this.gbDelivery.BackColor = System.Drawing.Color.Transparent;
            this.gbDelivery.Controls.Add(this.btnDeliver);
            this.gbDelivery.Controls.Add(this.groupBox1);
            this.gbDelivery.Controls.Add(this.gbminidelivery);
            this.gbDelivery.Location = new System.Drawing.Point(29, 83);
            this.gbDelivery.Name = "gbDelivery";
            this.gbDelivery.Size = new System.Drawing.Size(628, 547);
            this.gbDelivery.TabIndex = 12;
            this.gbDelivery.TabStop = false;
            // 
            // btnDeliver
            // 
            this.btnDeliver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnDeliver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeliver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeliver.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliver.ForeColor = System.Drawing.Color.White;
            this.btnDeliver.Location = new System.Drawing.Point(461, 320);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(91, 23);
            this.btnDeliver.TabIndex = 14;
            this.btnDeliver.Text = "DELIVER";
            this.btnDeliver.UseVisualStyleBackColor = false;
            this.btnDeliver.Click += new System.EventHandler(this.btnproceed_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProductDetails);
            this.groupBox1.Controls.Add(this.txttimetodeliver);
            this.groupBox1.Controls.Add(this.txtdatetodeliver);
            this.groupBox1.Controls.Add(this.txtcusID);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txttransactionid);
            this.groupBox1.Controls.Add(this.txtDateOrdered);
            this.groupBox1.Controls.Add(this.txtPreparedBy);
            this.groupBox1.Location = new System.Drawing.Point(44, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 297);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // dgvProductDetails
            // 
            this.dgvProductDetails.AllowUserToAddRows = false;
            this.dgvProductDetails.AllowUserToDeleteRows = false;
            this.dgvProductDetails.AllowUserToResizeColumns = false;
            this.dgvProductDetails.AllowUserToResizeRows = false;
            this.dgvProductDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDetails.Location = new System.Drawing.Point(41, 138);
            this.dgvProductDetails.Name = "dgvProductDetails";
            this.dgvProductDetails.ReadOnly = true;
            this.dgvProductDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductDetails.Size = new System.Drawing.Size(473, 137);
            this.dgvProductDetails.TabIndex = 6;
            this.dgvProductDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDetails_CellClick);
            this.dgvProductDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDetails_CellContentClick);
            this.dgvProductDetails.SelectionChanged += new System.EventHandler(this.dgvProductDetails_SelectionChanged);
            // 
            // txttimetodeliver
            // 
            this.txttimetodeliver.Enabled = false;
            this.txttimetodeliver.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimetodeliver.Location = new System.Drawing.Point(238, 160);
            this.txttimetodeliver.Name = "txttimetodeliver";
            this.txttimetodeliver.Size = new System.Drawing.Size(223, 26);
            this.txttimetodeliver.TabIndex = 14;
            this.txttimetodeliver.Text = "Time to Deliver";
            // 
            // txtdatetodeliver
            // 
            this.txtdatetodeliver.Enabled = false;
            this.txtdatetodeliver.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatetodeliver.Location = new System.Drawing.Point(308, 55);
            this.txtdatetodeliver.Name = "txtdatetodeliver";
            this.txtdatetodeliver.Size = new System.Drawing.Size(223, 26);
            this.txtdatetodeliver.TabIndex = 13;
            this.txtdatetodeliver.Text = "Date to Deliver";
            // 
            // txtcusID
            // 
            this.txtcusID.Enabled = false;
            this.txtcusID.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusID.Location = new System.Drawing.Point(42, 91);
            this.txtcusID.Name = "txtcusID";
            this.txtcusID.Size = new System.Drawing.Size(223, 26);
            this.txtcusID.TabIndex = 4;
            this.txtcusID.Text = "Customer ID";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(202, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txttransactionid
            // 
            this.txttransactionid.Enabled = false;
            this.txttransactionid.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttransactionid.Location = new System.Drawing.Point(42, 19);
            this.txttransactionid.Name = "txttransactionid";
            this.txttransactionid.Size = new System.Drawing.Size(154, 26);
            this.txttransactionid.TabIndex = 0;
            this.txttransactionid.Text = "Transaction ID";
            this.txttransactionid.TextChanged += new System.EventHandler(this.txttransactionid_TextChanged);
            // 
            // txtDateOrdered
            // 
            this.txtDateOrdered.Enabled = false;
            this.txtDateOrdered.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateOrdered.Location = new System.Drawing.Point(42, 55);
            this.txtDateOrdered.Name = "txtDateOrdered";
            this.txtDateOrdered.Size = new System.Drawing.Size(223, 26);
            this.txtDateOrdered.TabIndex = 0;
            this.txtDateOrdered.Text = "Date Ordered";
            // 
            // txtPreparedBy
            // 
            this.txtPreparedBy.Enabled = false;
            this.txtPreparedBy.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreparedBy.Location = new System.Drawing.Point(308, 20);
            this.txtPreparedBy.Name = "txtPreparedBy";
            this.txtPreparedBy.Size = new System.Drawing.Size(223, 26);
            this.txtPreparedBy.TabIndex = 0;
            this.txtPreparedBy.Text = "Prepared By";
            this.txtPreparedBy.TextChanged += new System.EventHandler(this.txtPreparedBy_TextChanged);
            // 
            // gbminidelivery
            // 
            this.gbminidelivery.Controls.Add(this.dgvDeliverditems);
            this.gbminidelivery.Controls.Add(this.lblreceivedby);
            this.gbminidelivery.Controls.Add(this.btnSave);
            this.gbminidelivery.Controls.Add(this.label6);
            this.gbminidelivery.Location = new System.Drawing.Point(44, 331);
            this.gbminidelivery.Name = "gbminidelivery";
            this.gbminidelivery.Size = new System.Drawing.Size(537, 193);
            this.gbminidelivery.TabIndex = 5;
            this.gbminidelivery.TabStop = false;
            // 
            // dgvDeliverditems
            // 
            this.dgvDeliverditems.AllowUserToAddRows = false;
            this.dgvDeliverditems.AllowUserToDeleteRows = false;
            this.dgvDeliverditems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliverditems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdID,
            this.ProductName,
            this.quantty,
            this.DateToDel});
            this.dgvDeliverditems.Location = new System.Drawing.Point(41, 16);
            this.dgvDeliverditems.Name = "dgvDeliverditems";
            this.dgvDeliverditems.ReadOnly = true;
            this.dgvDeliverditems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliverditems.Size = new System.Drawing.Size(472, 117);
            this.dgvDeliverditems.TabIndex = 11;
            // 
            // ProdID
            // 
            this.ProdID.HeaderText = "ProductID";
            this.ProdID.Name = "ProdID";
            this.ProdID.ReadOnly = true;
            this.ProdID.Width = 133;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 133;
            // 
            // quantty
            // 
            this.quantty.HeaderText = "Quantity";
            this.quantty.Name = "quantty";
            this.quantty.ReadOnly = true;
            this.quantty.Width = 133;
            // 
            // DateToDel
            // 
            this.DateToDel.HeaderText = "Date to Deliver";
            this.DateToDel.Name = "DateToDel";
            this.DateToDel.ReadOnly = true;
            this.DateToDel.Width = 133;
            // 
            // lblreceivedby
            // 
            this.lblreceivedby.AutoSize = true;
            this.lblreceivedby.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreceivedby.ForeColor = System.Drawing.Color.White;
            this.lblreceivedby.Location = new System.Drawing.Point(172, 91);
            this.lblreceivedby.Name = "lblreceivedby";
            this.lblreceivedby.Size = new System.Drawing.Size(11, 16);
            this.lblreceivedby.TabIndex = 9;
            this.lblreceivedby.Text = ".";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(433, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(83, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Received By:";
            // 
            // gbOrderDetails
            // 
            this.gbOrderDetails.BackColor = System.Drawing.Color.Transparent;
            this.gbOrderDetails.Controls.Add(this.btnCancelOrderDetails);
            this.gbOrderDetails.Controls.Add(this.btnProceedOrderDet);
            this.gbOrderDetails.Controls.Add(this.lblsearch);
            this.gbOrderDetails.Controls.Add(this.textBox1);
            this.gbOrderDetails.Controls.Add(this.dgvviewtransactiondetails);
            this.gbOrderDetails.Location = new System.Drawing.Point(29, 102);
            this.gbOrderDetails.Name = "gbOrderDetails";
            this.gbOrderDetails.Size = new System.Drawing.Size(624, 522);
            this.gbOrderDetails.TabIndex = 13;
            this.gbOrderDetails.TabStop = false;
            // 
            // btnCancelOrderDetails
            // 
            this.btnCancelOrderDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnCancelOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelOrderDetails.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrderDetails.ForeColor = System.Drawing.Color.White;
            this.btnCancelOrderDetails.Location = new System.Drawing.Point(69, 478);
            this.btnCancelOrderDetails.Name = "btnCancelOrderDetails";
            this.btnCancelOrderDetails.Size = new System.Drawing.Size(95, 27);
            this.btnCancelOrderDetails.TabIndex = 4;
            this.btnCancelOrderDetails.Text = "CANCEL";
            this.btnCancelOrderDetails.UseVisualStyleBackColor = false;
            this.btnCancelOrderDetails.Click += new System.EventHandler(this.btnCancelOrderDetails_Click_1);
            // 
            // btnProceedOrderDet
            // 
            this.btnProceedOrderDet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnProceedOrderDet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProceedOrderDet.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceedOrderDet.ForeColor = System.Drawing.Color.White;
            this.btnProceedOrderDet.Location = new System.Drawing.Point(506, 478);
            this.btnProceedOrderDet.Name = "btnProceedOrderDet";
            this.btnProceedOrderDet.Size = new System.Drawing.Size(95, 27);
            this.btnProceedOrderDet.TabIndex = 3;
            this.btnProceedOrderDet.Text = "PROCEED";
            this.btnProceedOrderDet.UseVisualStyleBackColor = false;
            this.btnProceedOrderDet.Click += new System.EventHandler(this.btnProceedOrderDet_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.Color.White;
            this.lblsearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.ForeColor = System.Drawing.Color.Black;
            this.lblsearch.Location = new System.Drawing.Point(27, 24);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(59, 18);
            this.lblsearch.TabIndex = 2;
            this.lblsearch.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(24, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // dgvviewtransactiondetails
            // 
            this.dgvviewtransactiondetails.AllowUserToAddRows = false;
            this.dgvviewtransactiondetails.AllowUserToDeleteRows = false;
            this.dgvviewtransactiondetails.AllowUserToResizeColumns = false;
            this.dgvviewtransactiondetails.AllowUserToResizeRows = false;
            this.dgvviewtransactiondetails.AutoGenerateColumns = false;
            this.dgvviewtransactiondetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvviewtransactiondetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.dateOrderDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvviewtransactiondetails.DataSource = this.tblcustomertransactionBindingSource;
            this.dgvviewtransactiondetails.Location = new System.Drawing.Point(6, 52);
            this.dgvviewtransactiondetails.Name = "dgvviewtransactiondetails";
            this.dgvviewtransactiondetails.ReadOnly = true;
            this.dgvviewtransactiondetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvviewtransactiondetails.Size = new System.Drawing.Size(612, 420);
            this.dgvviewtransactiondetails.TabIndex = 0;
            this.dgvviewtransactiondetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvviewtransactiondetails_CellClick);
            this.dgvviewtransactiondetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvviewtransactiondetails_CellContentClick);
            // 
            // transactionidDataGridViewTextBoxColumn
            // 
            this.transactionidDataGridViewTextBoxColumn.DataPropertyName = "transactionid";
            this.transactionidDataGridViewTextBoxColumn.HeaderText = "Transaction ID";
            this.transactionidDataGridViewTextBoxColumn.Name = "transactionidDataGridViewTextBoxColumn";
            this.transactionidDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionidDataGridViewTextBoxColumn.Width = 130;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date(Delivery)";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOrderDataGridViewTextBoxColumn
            // 
            this.dateOrderDataGridViewTextBoxColumn.DataPropertyName = "dateOrder";
            this.dateOrderDataGridViewTextBoxColumn.HeaderText = "Date(Ordered)";
            this.dateOrderDataGridViewTextBoxColumn.Name = "dateOrderDataGridViewTextBoxColumn";
            this.dateOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time(Delivery)";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblcustomertransactionBindingSource
            // 
            this.tblcustomertransactionBindingSource.DataMember = "tblcustomertransaction";
            this.tblcustomertransactionBindingSource.DataSource = this.miletecDataSet3;
            // 
            // miletecDataSet3
            // 
            this.miletecDataSet3.DataSetName = "MiletecDataSet3";
            this.miletecDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(535, 54);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(122, 26);
            this.dtpDate.TabIndex = 11;
            this.dtpDate.Value = new System.DateTime(2016, 10, 11, 0, 0, 0, 0);
            // 
            // txtDeliveryNo
            // 
            this.txtDeliveryNo.Enabled = false;
            this.txtDeliveryNo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryNo.Location = new System.Drawing.Point(29, 57);
            this.txtDeliveryNo.Name = "txtDeliveryNo";
            this.txtDeliveryNo.Size = new System.Drawing.Size(176, 26);
            this.txtDeliveryNo.TabIndex = 8;
            this.txtDeliveryNo.Text = "Delivery No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(32, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "View  Order Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(657, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 23);
            this.label13.TabIndex = 14;
            this.label13.Text = "X";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 646);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 3);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(683, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 643);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 643);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(680, 3);
            this.panel4.TabIndex = 18;
            // 
            // tblcustomertransactionTableAdapter
            // 
            this.tblcustomertransactionTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Customer_Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(686, 646);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtDeliveryNo);
            this.Controls.Add(this.gbDelivery);
            this.Controls.Add(this.gbOrderDetails);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Customer_Delivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Customer_Delivery";
            this.Load += new System.EventHandler(this.frm_Customer_Delivery_Load);
            this.gbDelivery.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).EndInit();
            this.gbminidelivery.ResumeLayout(false);
            this.gbminidelivery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverditems)).EndInit();
            this.gbOrderDetails.ResumeLayout(false);
            this.gbOrderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewtransactiondetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomertransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDelivery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txttransactionid;
        private System.Windows.Forms.TextBox txtDateOrdered;
        private System.Windows.Forms.TextBox txtPreparedBy;
        private System.Windows.Forms.GroupBox gbminidelivery;
        private System.Windows.Forms.Label lblreceivedby;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbOrderDetails;
        private System.Windows.Forms.Button btnCancelOrderDetails;
        private System.Windows.Forms.Button btnProceedOrderDet;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvviewtransactiondetails;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtDeliveryNo;
        private System.Windows.Forms.TextBox txtcusID;
        private System.Windows.Forms.DataGridView dgvProductDetails;
        private System.Windows.Forms.DataGridView dgvDeliverditems;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantty;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateToDel;
        private System.Windows.Forms.TextBox txtdatetodeliver;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttimetodeliver;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MiletecDataSet3 miletecDataSet3;
        private System.Windows.Forms.BindingSource tblcustomertransactionBindingSource;
        private MiletecDataSet3TableAdapters.tblcustomertransactionTableAdapter tblcustomertransactionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}