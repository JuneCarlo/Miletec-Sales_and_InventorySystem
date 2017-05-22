namespace Miletec_Sales_and_Inventory
{
    partial class frm_view_stocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_view_stocks));
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvviewstocks = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStocksBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.miletecDataSet9 = new Miletec_Sales_and_Inventory.MiletecDataSet9();
            this.tblStocksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.miletecDataSet8 = new Miletec_Sales_and_Inventory.MiletecDataSet8();
            this.tblstocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miletecDataSet2 = new Miletec_Sales_and_Inventory.MiletecDataSet2();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.tblstocksTableAdapter = new Miletec_Sales_and_Inventory.MiletecDataSet2TableAdapters.tblstocksTableAdapter();
            this.tblStocksTableAdapter1 = new Miletec_Sales_and_Inventory.MiletecDataSet8TableAdapters.tblStocksTableAdapter();
            this.tblStocksTableAdapter2 = new Miletec_Sales_and_Inventory.MiletecDataSet9TableAdapters.tblStocksTableAdapter();
            this.txtProductname = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewstocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStocksBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStocksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(44, 122);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(304, 26);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.Text = "Price";
            this.txtPrice.Click += new System.EventHandler(this.txtPrice_Click);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(246, 157);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 26);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvviewstocks
            // 
            this.dgvviewstocks.AllowUserToAddRows = false;
            this.dgvviewstocks.AllowUserToDeleteRows = false;
            this.dgvviewstocks.AllowUserToResizeColumns = false;
            this.dgvviewstocks.AllowUserToResizeRows = false;
            this.dgvviewstocks.AutoGenerateColumns = false;
            this.dgvviewstocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvviewstocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.availqtyDataGridViewTextBoxColumn,
            this.price});
            this.dgvviewstocks.DataSource = this.tblStocksBindingSource2;
            this.dgvviewstocks.Location = new System.Drawing.Point(44, 195);
            this.dgvviewstocks.Name = "dgvviewstocks";
            this.dgvviewstocks.ReadOnly = true;
            this.dgvviewstocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvviewstocks.Size = new System.Drawing.Size(506, 183);
            this.dgvviewstocks.TabIndex = 3;
            this.dgvviewstocks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvviewstocks_CellClick);
            this.dgvviewstocks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvviewstocks_CellContentClick);
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "productid";
            this.productidDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            this.productidDataGridViewTextBoxColumn.Width = 130;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "productname";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productnameDataGridViewTextBoxColumn.Width = 130;
            // 
            // availqtyDataGridViewTextBoxColumn
            // 
            this.availqtyDataGridViewTextBoxColumn.DataPropertyName = "availqty";
            this.availqtyDataGridViewTextBoxColumn.HeaderText = "Available Quantity";
            this.availqtyDataGridViewTextBoxColumn.Name = "availqtyDataGridViewTextBoxColumn";
            this.availqtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // tblStocksBindingSource2
            // 
            this.tblStocksBindingSource2.DataMember = "tblStocks";
            this.tblStocksBindingSource2.DataSource = this.miletecDataSet9;
            // 
            // miletecDataSet9
            // 
            this.miletecDataSet9.DataSetName = "MiletecDataSet9";
            this.miletecDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStocksBindingSource1
            // 
            this.tblStocksBindingSource1.DataMember = "tblStocks";
            this.tblStocksBindingSource1.DataSource = this.miletecDataSet8;
            // 
            // miletecDataSet8
            // 
            this.miletecDataSet8.DataSetName = "MiletecDataSet8";
            this.miletecDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblstocksBindingSource
            // 
            this.tblstocksBindingSource.DataMember = "tblstocks";
            this.tblstocksBindingSource.DataSource = this.miletecDataSet2;
            // 
            // miletecDataSet2
            // 
            this.miletecDataSet2.DataSetName = "MiletecDataSet2";
            this.miletecDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(44, 59);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(187, 26);
            this.txtProductID.TabIndex = 1;
            this.txtProductID.Text = "Product ID";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(472, 384);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 32);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tblstocksTableAdapter
            // 
            this.tblstocksTableAdapter.ClearBeforeFill = true;
            // 
            // tblStocksTableAdapter1
            // 
            this.tblStocksTableAdapter1.ClearBeforeFill = true;
            // 
            // tblStocksTableAdapter2
            // 
            this.tblStocksTableAdapter2.ClearBeforeFill = true;
            // 
            // txtProductname
            // 
            this.txtProductname.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductname.Location = new System.Drawing.Point(44, 91);
            this.txtProductname.Name = "txtProductname";
            this.txtProductname.Size = new System.Drawing.Size(304, 26);
            this.txtProductname.TabIndex = 11;
            this.txtProductname.Text = "Product Name";
            this.txtProductname.Click += new System.EventHandler(this.txtProductname_Click);
            this.txtProductname.LocationChanged += new System.EventHandler(this.txtProductname_LocationChanged);
            this.txtProductname.Leave += new System.EventHandler(this.txtProductname_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(87, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 26);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "ADD PRODUCT";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(574, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(597, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 419);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 3);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 416);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(594, 3);
            this.panel4.TabIndex = 17;
            // 
            // frm_view_stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 419);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProductname);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvviewstocks);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.txtPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_view_stocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_view_stocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewstocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStocksBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStocksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvviewstocks;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnOK;
        private MiletecDataSet2 miletecDataSet2;
        private System.Windows.Forms.BindingSource tblstocksBindingSource;
        private MiletecDataSet2TableAdapters.tblstocksTableAdapter tblstocksTableAdapter;
        private MiletecDataSet8 miletecDataSet8;
        private System.Windows.Forms.BindingSource tblStocksBindingSource1;
        private MiletecDataSet8TableAdapters.tblStocksTableAdapter tblStocksTableAdapter1;
        private MiletecDataSet9 miletecDataSet9;
        private System.Windows.Forms.BindingSource tblStocksBindingSource2;
        private MiletecDataSet9TableAdapters.tblStocksTableAdapter tblStocksTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.TextBox txtProductname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}