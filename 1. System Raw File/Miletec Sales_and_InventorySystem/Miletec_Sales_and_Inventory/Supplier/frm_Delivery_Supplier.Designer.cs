namespace Miletec_Sales_and_Inventory
{
    partial class frm_Delivery_Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Delivery_Supplier));
            this.txtDeliveryNo = new System.Windows.Forms.TextBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtPreparedBy = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvProductDetails = new System.Windows.Forms.DataGridView();
            this.txtDateOrdered = new System.Windows.Forms.TextBox();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.gbDelivery = new System.Windows.Forms.GroupBox();
            this.gbminidelivery = new System.Windows.Forms.GroupBox();
            this.lblreceivedby = new System.Windows.Forms.Label();
            this.txtDeliveredBy = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDeliverditems = new System.Windows.Forms.DataGridView();
            this.DeliveryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbOrderDetails = new System.Windows.Forms.GroupBox();
            this.btnCancelOrderDetails = new System.Windows.Forms.Button();
            this.btnProceedOrderDet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miletecDataSet10 = new Miletec_Sales_and_Inventory.MiletecDataSet10();
            this.miletecDataSet = new Miletec_Sales_and_Inventory.MiletecDataSet();
            this.tblOrderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblOrderDetailsTableAdapter = new Miletec_Sales_and_Inventory.MiletecDataSetTableAdapters.tblOrderDetailsTableAdapter();
            this.tblOrdersTableAdapter = new Miletec_Sales_and_Inventory.MiletecDataSet10TableAdapters.tblOrdersTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).BeginInit();
            this.gbDelivery.SuspendLayout();
            this.gbminidelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverditems)).BeginInit();
            this.gbOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDeliveryNo
            // 
            this.txtDeliveryNo.Enabled = false;
            this.txtDeliveryNo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryNo.Location = new System.Drawing.Point(31, 60);
            this.txtDeliveryNo.Name = "txtDeliveryNo";
            this.txtDeliveryNo.Size = new System.Drawing.Size(138, 26);
            this.txtDeliveryNo.TabIndex = 0;
            this.txtDeliveryNo.Text = "Delivery No.";
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnProceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProceed.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Location = new System.Drawing.Point(490, 375);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(101, 27);
            this.btnProceed.TabIndex = 2;
            this.btnProceed.Text = "DELIVER";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Enabled = false;
            this.txtOrderID.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.Location = new System.Drawing.Point(21, 11);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(225, 26);
            this.txtOrderID.TabIndex = 0;
            this.txtOrderID.Text = "Order No.";
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // txtPreparedBy
            // 
            this.txtPreparedBy.Enabled = false;
            this.txtPreparedBy.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreparedBy.Location = new System.Drawing.Point(21, 78);
            this.txtPreparedBy.Name = "txtPreparedBy";
            this.txtPreparedBy.Size = new System.Drawing.Size(297, 26);
            this.txtPreparedBy.TabIndex = 0;
            this.txtPreparedBy.Text = "Prepared By";
            this.txtPreparedBy.TextChanged += new System.EventHandler(this.txtPreparedBy_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOrderID);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dgvProductDetails);
            this.groupBox1.Controls.Add(this.txtDateOrdered);
            this.groupBox1.Controls.Add(this.txtPreparedBy);
            this.groupBox1.Location = new System.Drawing.Point(44, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 283);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(252, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 27);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvProductDetails
            // 
            this.dgvProductDetails.AllowUserToAddRows = false;
            this.dgvProductDetails.AllowUserToDeleteRows = false;
            this.dgvProductDetails.AllowUserToResizeColumns = false;
            this.dgvProductDetails.AllowUserToResizeRows = false;
            this.dgvProductDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDetails.Location = new System.Drawing.Point(41, 118);
            this.dgvProductDetails.Name = "dgvProductDetails";
            this.dgvProductDetails.ReadOnly = true;
            this.dgvProductDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductDetails.Size = new System.Drawing.Size(473, 137);
            this.dgvProductDetails.TabIndex = 2;
            this.dgvProductDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDetails_CellClick);
            this.dgvProductDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDetails_CellContentClick);
            this.dgvProductDetails.SelectionChanged += new System.EventHandler(this.dgvProductDetails_SelectionChanged);
            // 
            // txtDateOrdered
            // 
            this.txtDateOrdered.Enabled = false;
            this.txtDateOrdered.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateOrdered.Location = new System.Drawing.Point(21, 43);
            this.txtDateOrdered.Name = "txtDateOrdered";
            this.txtDateOrdered.Size = new System.Drawing.Size(297, 26);
            this.txtDateOrdered.TabIndex = 0;
            this.txtDateOrdered.Text = "Date Ordered";
            this.txtDateOrdered.TextChanged += new System.EventHandler(this.txtDateOrdered_TextChanged);
            // 
            // txtProdID
            // 
            this.txtProdID.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdID.Location = new System.Drawing.Point(396, 62);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(141, 26);
            this.txtProdID.TabIndex = 4;
            this.txtProdID.Text = "Time to Deliver";
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(378, 60);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(278, 26);
            this.dtpDate.TabIndex = 4;
            // 
            // gbDelivery
            // 
            this.gbDelivery.BackColor = System.Drawing.Color.Transparent;
            this.gbDelivery.Controls.Add(this.groupBox1);
            this.gbDelivery.Controls.Add(this.txtProdID);
            this.gbDelivery.Controls.Add(this.gbminidelivery);
            this.gbDelivery.Location = new System.Drawing.Point(31, 92);
            this.gbDelivery.Name = "gbDelivery";
            this.gbDelivery.Size = new System.Drawing.Size(638, 542);
            this.gbDelivery.TabIndex = 6;
            this.gbDelivery.TabStop = false;
            // 
            // gbminidelivery
            // 
            this.gbminidelivery.Controls.Add(this.lblreceivedby);
            this.gbminidelivery.Controls.Add(this.txtDeliveredBy);
            this.gbminidelivery.Controls.Add(this.btnSave);
            this.gbminidelivery.Controls.Add(this.label6);
            this.gbminidelivery.Controls.Add(this.dgvDeliverditems);
            this.gbminidelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbminidelivery.ForeColor = System.Drawing.Color.Black;
            this.gbminidelivery.Location = new System.Drawing.Point(44, 302);
            this.gbminidelivery.Name = "gbminidelivery";
            this.gbminidelivery.Size = new System.Drawing.Size(537, 232);
            this.gbminidelivery.TabIndex = 5;
            this.gbminidelivery.TabStop = false;
            // 
            // lblreceivedby
            // 
            this.lblreceivedby.AutoSize = true;
            this.lblreceivedby.ForeColor = System.Drawing.Color.White;
            this.lblreceivedby.Location = new System.Drawing.Point(118, 165);
            this.lblreceivedby.Name = "lblreceivedby";
            this.lblreceivedby.Size = new System.Drawing.Size(11, 16);
            this.lblreceivedby.TabIndex = 9;
            this.lblreceivedby.Text = ".";
            // 
            // txtDeliveredBy
            // 
            this.txtDeliveredBy.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveredBy.Location = new System.Drawing.Point(303, 158);
            this.txtDeliveredBy.Name = "txtDeliveredBy";
            this.txtDeliveredBy.Size = new System.Drawing.Size(211, 26);
            this.txtDeliveredBy.TabIndex = 8;
            this.txtDeliveredBy.Text = "Delivered By";
            this.txtDeliveredBy.Click += new System.EventHandler(this.txtDeliveredBy_Click);
            this.txtDeliveredBy.Leave += new System.EventHandler(this.txtDeliveredBy_Leave);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(415, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Received By:";
            // 
            // dgvDeliverditems
            // 
            this.dgvDeliverditems.AllowUserToAddRows = false;
            this.dgvDeliverditems.AllowUserToDeleteRows = false;
            this.dgvDeliverditems.AllowUserToResizeColumns = false;
            this.dgvDeliverditems.AllowUserToResizeRows = false;
            this.dgvDeliverditems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliverditems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeliveryID,
            this.OrderID,
            this.Date});
            this.dgvDeliverditems.Location = new System.Drawing.Point(41, 19);
            this.dgvDeliverditems.Name = "dgvDeliverditems";
            this.dgvDeliverditems.ReadOnly = true;
            this.dgvDeliverditems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliverditems.Size = new System.Drawing.Size(473, 132);
            this.dgvDeliverditems.TabIndex = 0;
            this.dgvDeliverditems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliverditems_CellContentClick);
            // 
            // DeliveryID
            // 
            this.DeliveryID.HeaderText = "Product ID";
            this.DeliveryID.Name = "DeliveryID";
            this.DeliveryID.ReadOnly = true;
            this.DeliveryID.Width = 150;
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "Product Name";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // gbOrderDetails
            // 
            this.gbOrderDetails.BackColor = System.Drawing.Color.Transparent;
            this.gbOrderDetails.Controls.Add(this.btnCancelOrderDetails);
            this.gbOrderDetails.Controls.Add(this.btnProceedOrderDet);
            this.gbOrderDetails.Controls.Add(this.label8);
            this.gbOrderDetails.Controls.Add(this.textBox1);
            this.gbOrderDetails.Controls.Add(this.dgvViewOrderDetails);
            this.gbOrderDetails.Location = new System.Drawing.Point(44, 165);
            this.gbOrderDetails.Name = "gbOrderDetails";
            this.gbOrderDetails.Size = new System.Drawing.Size(612, 285);
            this.gbOrderDetails.TabIndex = 7;
            this.gbOrderDetails.TabStop = false;
            this.gbOrderDetails.Text = "View  Order Details";
            this.gbOrderDetails.Enter += new System.EventHandler(this.gbOrderDetails_Enter);
            // 
            // btnCancelOrderDetails
            // 
            this.btnCancelOrderDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnCancelOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelOrderDetails.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrderDetails.ForeColor = System.Drawing.Color.White;
            this.btnCancelOrderDetails.Location = new System.Drawing.Point(361, 241);
            this.btnCancelOrderDetails.Name = "btnCancelOrderDetails";
            this.btnCancelOrderDetails.Size = new System.Drawing.Size(85, 27);
            this.btnCancelOrderDetails.TabIndex = 4;
            this.btnCancelOrderDetails.Text = "CANCEL";
            this.btnCancelOrderDetails.UseVisualStyleBackColor = false;
            this.btnCancelOrderDetails.Click += new System.EventHandler(this.btnCancelOrderDetails_Click);
            // 
            // btnProceedOrderDet
            // 
            this.btnProceedOrderDet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnProceedOrderDet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProceedOrderDet.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceedOrderDet.ForeColor = System.Drawing.Color.White;
            this.btnProceedOrderDet.Location = new System.Drawing.Point(467, 241);
            this.btnProceedOrderDet.Name = "btnProceedOrderDet";
            this.btnProceedOrderDet.Size = new System.Drawing.Size(111, 27);
            this.btnProceedOrderDet.TabIndex = 3;
            this.btnProceedOrderDet.Text = "PROCEED";
            this.btnProceedOrderDet.UseVisualStyleBackColor = false;
            this.btnProceedOrderDet.Click += new System.EventHandler(this.btnProceedOrderDet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dgvViewOrderDetails
            // 
            this.dgvViewOrderDetails.AllowUserToAddRows = false;
            this.dgvViewOrderDetails.AllowUserToDeleteRows = false;
            this.dgvViewOrderDetails.AllowUserToResizeColumns = false;
            this.dgvViewOrderDetails.AllowUserToResizeRows = false;
            this.dgvViewOrderDetails.AutoGenerateColumns = false;
            this.dgvViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderByDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvViewOrderDetails.DataSource = this.tblOrdersBindingSource;
            this.dgvViewOrderDetails.Location = new System.Drawing.Point(24, 75);
            this.dgvViewOrderDetails.Name = "dgvViewOrderDetails";
            this.dgvViewOrderDetails.ReadOnly = true;
            this.dgvViewOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewOrderDetails.Size = new System.Drawing.Size(557, 150);
            this.dgvViewOrderDetails.TabIndex = 0;
            this.dgvViewOrderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewOrderDetails_CellClick);
            this.dgvViewOrderDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewOrderDetails_CellContentClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier ID";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "Date Ordered";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // orderByDataGridViewTextBoxColumn
            // 
            this.orderByDataGridViewTextBoxColumn.DataPropertyName = "OrderBy";
            this.orderByDataGridViewTextBoxColumn.HeaderText = "Ordered By";
            this.orderByDataGridViewTextBoxColumn.Name = "orderByDataGridViewTextBoxColumn";
            this.orderByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblOrdersBindingSource
            // 
            this.tblOrdersBindingSource.DataMember = "tblOrders";
            this.tblOrdersBindingSource.DataSource = this.miletecDataSet10;
            // 
            // miletecDataSet10
            // 
            this.miletecDataSet10.DataSetName = "MiletecDataSet10";
            this.miletecDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // miletecDataSet
            // 
            this.miletecDataSet.DataSetName = "MiletecDataSet";
            this.miletecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOrderDetailsBindingSource
            // 
            this.tblOrderDetailsBindingSource.DataMember = "tblOrderDetails";
            this.tblOrderDetailsBindingSource.DataSource = this.miletecDataSet;
            // 
            // tblOrderDetailsTableAdapter
            // 
            this.tblOrderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tblOrdersTableAdapter
            // 
            this.tblOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(680, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 3);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(700, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 633);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 633);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 3);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 630);
            this.panel4.TabIndex = 12;
            // 
            // frm_Delivery_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(703, 636);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.gbDelivery);
            this.Controls.Add(this.gbOrderDetails);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtDeliveryNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Delivery_Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Delivery_Supplier_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetails)).EndInit();
            this.gbDelivery.ResumeLayout(false);
            this.gbDelivery.PerformLayout();
            this.gbminidelivery.ResumeLayout(false);
            this.gbminidelivery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverditems)).EndInit();
            this.gbOrderDetails.ResumeLayout(false);
            this.gbOrderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeliveryNo;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtPreparedBy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProductDetails;
        private System.Windows.Forms.TextBox txtDateOrdered;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbDelivery;
        private System.Windows.Forms.GroupBox gbOrderDetails;
        private System.Windows.Forms.DataGridView dgvViewOrderDetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCancelOrderDetails;
        private System.Windows.Forms.Button btnProceedOrderDet;
        private MiletecDataSet miletecDataSet;
        private System.Windows.Forms.BindingSource tblOrderDetailsBindingSource;
        private MiletecDataSetTableAdapters.tblOrderDetailsTableAdapter tblOrderDetailsTableAdapter;
        private System.Windows.Forms.GroupBox gbminidelivery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDeliverditems;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDeliveredBy;
        private System.Windows.Forms.Label lblreceivedby;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.TextBox txtProdID;
        private MiletecDataSet10 miletecDataSet10;
        private System.Windows.Forms.BindingSource tblOrdersBindingSource;
        private MiletecDataSet10TableAdapters.tblOrdersTableAdapter tblOrdersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}