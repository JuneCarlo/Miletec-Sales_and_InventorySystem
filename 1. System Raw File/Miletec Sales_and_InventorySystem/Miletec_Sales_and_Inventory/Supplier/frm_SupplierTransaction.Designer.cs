namespace Miletec_Sales_and_Inventory
{
    partial class frm_SupplierTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SupplierTransaction));
            this.gbSupplierDetails = new System.Windows.Forms.GroupBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtsearchj = new System.Windows.Forms.TextBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnsupcancel = new System.Windows.Forms.Button();
            this.dgvsupplierdetails = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContact2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContact1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.gbProduct_Details = new System.Windows.Forms.GroupBox();
            this.lblproductid = new System.Windows.Forms.Label();
            this.btncancelprod = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtShowSupplier = new System.Windows.Forms.TextBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbProductID = new System.Windows.Forms.ComboBox();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnaddsup = new System.Windows.Forms.Button();
            this.dtpProductDetails = new System.Windows.Forms.DateTimePicker();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtOrderBy = new System.Windows.Forms.TextBox();
            this.txtQuantityOrder = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbSupplierDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsupplierdetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbProduct_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSupplierDetails
            // 
            this.gbSupplierDetails.BackColor = System.Drawing.Color.Transparent;
            this.gbSupplierDetails.Controls.Add(this.lblsearch);
            this.gbSupplierDetails.Controls.Add(this.txtsearchj);
            this.gbSupplierDetails.Controls.Add(this.btnProceed);
            this.gbSupplierDetails.Controls.Add(this.btnsupcancel);
            this.gbSupplierDetails.Controls.Add(this.dgvsupplierdetails);
            this.gbSupplierDetails.Controls.Add(this.groupBox1);
            this.gbSupplierDetails.Location = new System.Drawing.Point(104, 50);
            this.gbSupplierDetails.Name = "gbSupplierDetails";
            this.gbSupplierDetails.Size = new System.Drawing.Size(491, 429);
            this.gbSupplierDetails.TabIndex = 3;
            this.gbSupplierDetails.TabStop = false;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.Color.White;
            this.lblsearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(10, 37);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(59, 18);
            this.lblsearch.TabIndex = 15;
            this.lblsearch.Text = "Search";
            // 
            // txtsearchj
            // 
            this.txtsearchj.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchj.Location = new System.Drawing.Point(9, 33);
            this.txtsearchj.Name = "txtsearchj";
            this.txtsearchj.Size = new System.Drawing.Size(186, 26);
            this.txtsearchj.TabIndex = 14;
            this.txtsearchj.Click += new System.EventHandler(this.txtsearchj_Click);
            this.txtsearchj.TextChanged += new System.EventHandler(this.txtsearchj_TextChanged);
            this.txtsearchj.Leave += new System.EventHandler(this.txtsearchj_Leave);
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProceed.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Location = new System.Drawing.Point(373, 394);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(104, 27);
            this.btnProceed.TabIndex = 7;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnsupcancel
            // 
            this.btnsupcancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnsupcancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsupcancel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupcancel.ForeColor = System.Drawing.Color.White;
            this.btnsupcancel.Location = new System.Drawing.Point(9, 394);
            this.btnsupcancel.Name = "btnsupcancel";
            this.btnsupcancel.Size = new System.Drawing.Size(104, 27);
            this.btnsupcancel.TabIndex = 6;
            this.btnsupcancel.Text = "CANCEL";
            this.btnsupcancel.UseVisualStyleBackColor = false;
            // 
            // dgvsupplierdetails
            // 
            this.dgvsupplierdetails.AllowUserToAddRows = false;
            this.dgvsupplierdetails.AllowUserToDeleteRows = false;
            this.dgvsupplierdetails.AllowUserToResizeColumns = false;
            this.dgvsupplierdetails.AllowUserToResizeRows = false;
            this.dgvsupplierdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsupplierdetails.Location = new System.Drawing.Point(9, 63);
            this.dgvsupplierdetails.Name = "dgvsupplierdetails";
            this.dgvsupplierdetails.ReadOnly = true;
            this.dgvsupplierdetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsupplierdetails.Size = new System.Drawing.Size(470, 327);
            this.dgvsupplierdetails.TabIndex = 1;
            this.dgvsupplierdetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsupplierdetails_CellClick);
            this.dgvsupplierdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsupplierdetails_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtContactPerson);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtContact2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtContact1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSupplierName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSupplierID);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(95, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SUPPLIER DETAILS";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(261, 203);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(144, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "+639";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(144, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "+639";
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(147, 176);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(270, 20);
            this.txtContactPerson.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(29, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Contact Person:";
            // 
            // txtContact2
            // 
            this.txtContact2.Location = new System.Drawing.Point(177, 150);
            this.txtContact2.MaxLength = 9;
            this.txtContact2.Name = "txtContact2";
            this.txtContact2.Size = new System.Drawing.Size(240, 20);
            this.txtContact2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(44, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Contact No.2:";
            // 
            // txtContact1
            // 
            this.txtContact1.Location = new System.Drawing.Point(177, 124);
            this.txtContact1.MaxLength = 9;
            this.txtContact1.Name = "txtContact1";
            this.txtContact1.Size = new System.Drawing.Size(240, 20);
            this.txtContact1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(44, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contact No.1:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(147, 98);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(270, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(69, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(147, 72);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(270, 20);
            this.txtSupplierName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(207, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supplier ID:";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(300, 41);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(117, 20);
            this.txtSupplierID.TabIndex = 0;
            // 
            // gbProduct_Details
            // 
            this.gbProduct_Details.BackColor = System.Drawing.Color.Transparent;
            this.gbProduct_Details.Controls.Add(this.lblproductid);
            this.gbProduct_Details.Controls.Add(this.btncancelprod);
            this.gbProduct_Details.Controls.Add(this.btnadd);
            this.gbProduct_Details.Controls.Add(this.txtShowSupplier);
            this.gbProduct_Details.Controls.Add(this.btnPurchase);
            this.gbProduct_Details.Controls.Add(this.dgvOrderDetails);
            this.gbProduct_Details.Controls.Add(this.cmbProductID);
            this.gbProduct_Details.Controls.Add(this.btnremove);
            this.gbProduct_Details.Controls.Add(this.btnaddsup);
            this.gbProduct_Details.Controls.Add(this.dtpProductDetails);
            this.gbProduct_Details.Controls.Add(this.txtOrderID);
            this.gbProduct_Details.Controls.Add(this.txtOrderBy);
            this.gbProduct_Details.Controls.Add(this.txtQuantityOrder);
            this.gbProduct_Details.Controls.Add(this.txtProductName);
            this.gbProduct_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProduct_Details.ForeColor = System.Drawing.Color.Black;
            this.gbProduct_Details.Location = new System.Drawing.Point(47, 50);
            this.gbProduct_Details.Name = "gbProduct_Details";
            this.gbProduct_Details.Size = new System.Drawing.Size(611, 434);
            this.gbProduct_Details.TabIndex = 8;
            this.gbProduct_Details.TabStop = false;
            this.gbProduct_Details.Enter += new System.EventHandler(this.gbProduct_Details_Enter);
            // 
            // lblproductid
            // 
            this.lblproductid.AutoSize = true;
            this.lblproductid.BackColor = System.Drawing.Color.Gainsboro;
            this.lblproductid.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductid.ForeColor = System.Drawing.Color.Gray;
            this.lblproductid.Location = new System.Drawing.Point(32, 98);
            this.lblproductid.Name = "lblproductid";
            this.lblproductid.Size = new System.Drawing.Size(86, 18);
            this.lblproductid.TabIndex = 14;
            this.lblproductid.Text = "Product ID";
            // 
            // btncancelprod
            // 
            this.btncancelprod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btncancelprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelprod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelprod.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelprod.ForeColor = System.Drawing.Color.White;
            this.btncancelprod.Location = new System.Drawing.Point(48, 338);
            this.btncancelprod.Name = "btncancelprod";
            this.btncancelprod.Size = new System.Drawing.Size(93, 27);
            this.btncancelprod.TabIndex = 10;
            this.btncancelprod.Text = "CANCEL";
            this.btncancelprod.UseVisualStyleBackColor = false;
            this.btncancelprod.Click += new System.EventHandler(this.btncancelprod_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(374, 160);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(95, 27);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtShowSupplier
            // 
            this.txtShowSupplier.Enabled = false;
            this.txtShowSupplier.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowSupplier.Location = new System.Drawing.Point(30, 33);
            this.txtShowSupplier.Name = "txtShowSupplier";
            this.txtShowSupplier.Size = new System.Drawing.Size(164, 26);
            this.txtShowSupplier.TabIndex = 0;
            this.txtShowSupplier.Text = "Supplier ID";
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPurchase.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Location = new System.Drawing.Point(517, 348);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(76, 27);
            this.btnPurchase.TabIndex = 12;
            this.btnPurchase.Text = "SAVE";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.AllowUserToResizeColumns = false;
            this.dgvOrderDetails.AllowUserToResizeRows = false;
            this.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Quantity});
            this.dgvOrderDetails.Location = new System.Drawing.Point(48, 197);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.ReadOnly = true;
            this.dgvOrderDetails.RowHeadersVisible = false;
            this.dgvOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetails.Size = new System.Drawing.Size(545, 135);
            this.dgvOrderDetails.TabIndex = 13;
            this.dgvOrderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellClick);
            this.dgvOrderDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellContentClick);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // cmbProductID
            // 
            this.cmbProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductID.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductID.FormattingEnabled = true;
            this.cmbProductID.Items.AddRange(new object[] {
            "ProductID-0001",
            "ProductID-0002",
            "ProductID-0003"});
            this.cmbProductID.Location = new System.Drawing.Point(30, 94);
            this.cmbProductID.Name = "cmbProductID";
            this.cmbProductID.Size = new System.Drawing.Size(230, 26);
            this.cmbProductID.TabIndex = 3;
            this.cmbProductID.SelectedIndexChanged += new System.EventHandler(this.cmbProductID_SelectedIndexChanged);
            this.cmbProductID.TextChanged += new System.EventHandler(this.cmbProductID_TextChanged);
            this.cmbProductID.Click += new System.EventHandler(this.cmbProductID_Click);
            this.cmbProductID.Leave += new System.EventHandler(this.cmbProductID_Leave);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnremove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnremove.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.ForeColor = System.Drawing.Color.White;
            this.btnremove.Location = new System.Drawing.Point(498, 160);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(95, 27);
            this.btnremove.TabIndex = 11;
            this.btnremove.Text = "REMOVE";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnaddsup
            // 
            this.btnaddsup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnaddsup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddsup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddsup.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddsup.ForeColor = System.Drawing.Color.White;
            this.btnaddsup.Location = new System.Drawing.Point(201, 32);
            this.btnaddsup.Name = "btnaddsup";
            this.btnaddsup.Size = new System.Drawing.Size(60, 27);
            this.btnaddsup.TabIndex = 1;
            this.btnaddsup.Text = "Add";
            this.btnaddsup.UseVisualStyleBackColor = false;
            this.btnaddsup.Click += new System.EventHandler(this.btnaddsup_Click);
            // 
            // dtpProductDetails
            // 
            this.dtpProductDetails.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpProductDetails.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProductDetails.Location = new System.Drawing.Point(324, 30);
            this.dtpProductDetails.Name = "dtpProductDetails";
            this.dtpProductDetails.Size = new System.Drawing.Size(184, 26);
            this.dtpProductDetails.TabIndex = 8;
            this.dtpProductDetails.Value = new System.DateTime(2016, 10, 10, 0, 0, 0, 0);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Enabled = false;
            this.txtOrderID.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderID.Location = new System.Drawing.Point(30, 63);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(231, 26);
            this.txtOrderID.TabIndex = 2;
            this.txtOrderID.Text = "Order ID";
            this.txtOrderID.Click += new System.EventHandler(this.txtOrderID_Click);
            this.txtOrderID.Leave += new System.EventHandler(this.txtOrderID_Leave);
            // 
            // txtOrderBy
            // 
            this.txtOrderBy.Enabled = false;
            this.txtOrderBy.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderBy.Location = new System.Drawing.Point(323, 65);
            this.txtOrderBy.Name = "txtOrderBy";
            this.txtOrderBy.Size = new System.Drawing.Size(184, 26);
            this.txtOrderBy.TabIndex = 5;
            this.txtOrderBy.Text = "Order By";
            // 
            // txtQuantityOrder
            // 
            this.txtQuantityOrder.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityOrder.Location = new System.Drawing.Point(323, 95);
            this.txtQuantityOrder.Name = "txtQuantityOrder";
            this.txtQuantityOrder.Size = new System.Drawing.Size(184, 26);
            this.txtQuantityOrder.TabIndex = 7;
            this.txtQuantityOrder.Text = "Quantity Order";
            this.txtQuantityOrder.Click += new System.EventHandler(this.txtQuantityOrder_Click);
            this.txtQuantityOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantityOrder_KeyPress);
            this.txtQuantityOrder.Leave += new System.EventHandler(this.txtQuantityOrder_Leave);
            // 
            // txtProductName
            // 
            this.txtProductName.Enabled = false;
            this.txtProductName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(30, 126);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(230, 26);
            this.txtProductName.TabIndex = 4;
            this.txtProductName.Text = "Product Name";
            this.txtProductName.Click += new System.EventHandler(this.txtProductName_Click);
            this.txtProductName.Leave += new System.EventHandler(this.txtProductName_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label16.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(679, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 23);
            this.label16.TabIndex = 9;
            this.label16.Text = "X";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 3);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(701, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 488);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 488);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(701, 3);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 485);
            this.panel4.TabIndex = 13;
            // 
            // frm_SupplierTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(704, 491);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.gbProduct_Details);
            this.Controls.Add(this.gbSupplierDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SupplierTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SupplierTransaction";
            this.Load += new System.EventHandler(this.frm_SupplierTransaction_Load);
            this.gbSupplierDetails.ResumeLayout(false);
            this.gbSupplierDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsupplierdetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbProduct_Details.ResumeLayout(false);
            this.gbProduct_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSupplierDetails;
        private System.Windows.Forms.DataGridView dgvsupplierdetails;
        private System.Windows.Forms.GroupBox gbProduct_Details;
        private System.Windows.Forms.TextBox txtShowSupplier;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.ComboBox cmbProductID;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancelprod;
        private System.Windows.Forms.Button btnaddsup;
        private System.Windows.Forms.DateTimePicker dtpProductDetails;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtOrderBy;
        private System.Windows.Forms.TextBox txtQuantityOrder;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblproductid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnsupcancel;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox txtsearchj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContact2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContact1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplierID;
    }
}