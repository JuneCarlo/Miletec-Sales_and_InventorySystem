namespace Miletec_Sales_and_Inventory
{
    partial class frm_view_order_from_supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_view_order_from_supplier));
            this.dgvorderfromsupplier = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderFromSupplier = new Miletec_Sales_and_Inventory.OrderFromSupplier();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.btnview = new System.Windows.Forms.Button();
            this.dvgviewdetails = new System.Windows.Forms.DataGridView();
            this.tblOrderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetails = new Miletec_Sales_and_Inventory.OrderDetails();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnok = new System.Windows.Forms.Button();
            this.tblOrdersTableAdapter = new Miletec_Sales_and_Inventory.OrderFromSupplierTableAdapters.tblOrdersTableAdapter();
            this.tblOrderDetailsTableAdapter = new Miletec_Sales_and_Inventory.OrderDetailsTableAdapters.tblOrderDetailsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderfromsupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderFromSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgviewdetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvorderfromsupplier
            // 
            this.dgvorderfromsupplier.AllowUserToAddRows = false;
            this.dgvorderfromsupplier.AllowUserToDeleteRows = false;
            this.dgvorderfromsupplier.AutoGenerateColumns = false;
            this.dgvorderfromsupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvorderfromsupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderByDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvorderfromsupplier.DataSource = this.tblOrdersBindingSource;
            this.dgvorderfromsupplier.Location = new System.Drawing.Point(16, 45);
            this.dgvorderfromsupplier.Name = "dgvorderfromsupplier";
            this.dgvorderfromsupplier.ReadOnly = true;
            this.dgvorderfromsupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvorderfromsupplier.Size = new System.Drawing.Size(601, 150);
            this.dgvorderfromsupplier.TabIndex = 0;
            this.dgvorderfromsupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvorderfromsupplier_CellClick);
            this.dgvorderfromsupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvorderfromsupplier_CellContentClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // orderByDataGridViewTextBoxColumn
            // 
            this.orderByDataGridViewTextBoxColumn.DataPropertyName = "OrderBy";
            this.orderByDataGridViewTextBoxColumn.HeaderText = "OrderBy";
            this.orderByDataGridViewTextBoxColumn.Name = "orderByDataGridViewTextBoxColumn";
            this.orderByDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderByDataGridViewTextBoxColumn.Width = 120;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 120;
            // 
            // tblOrdersBindingSource
            // 
            this.tblOrdersBindingSource.DataMember = "tblOrders";
            this.tblOrdersBindingSource.DataSource = this.orderFromSupplier;
            // 
            // orderFromSupplier
            // 
            this.orderFromSupplier.DataSetName = "OrderFromSupplier";
            this.orderFromSupplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(16, 17);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(218, 26);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.Click += new System.EventHandler(this.txtsearch_Click);
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.Leave += new System.EventHandler(this.txtsearch_Leave);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.Color.White;
            this.lblsearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.ForeColor = System.Drawing.Color.Black;
            this.lblsearch.Location = new System.Drawing.Point(19, 21);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(59, 18);
            this.lblsearch.TabIndex = 2;
            this.lblsearch.Text = "Search";
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnview.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.Location = new System.Drawing.Point(542, 201);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 27);
            this.btnview.TabIndex = 3;
            this.btnview.Text = "View Details";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // dvgviewdetails
            // 
            this.dvgviewdetails.AllowUserToAddRows = false;
            this.dvgviewdetails.AllowUserToDeleteRows = false;
            this.dvgviewdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgviewdetails.Location = new System.Drawing.Point(16, 240);
            this.dvgviewdetails.Name = "dvgviewdetails";
            this.dvgviewdetails.ReadOnly = true;
            this.dvgviewdetails.Size = new System.Drawing.Size(601, 150);
            this.dvgviewdetails.TabIndex = 4;
            // 
            // tblOrderDetailsBindingSource
            // 
            this.tblOrderDetailsBindingSource.DataMember = "tblOrderDetails";
            this.tblOrderDetailsBindingSource.DataSource = this.orderDetails;
            // 
            // orderDetails
            // 
            this.orderDetails.DataSetName = "OrderDetails";
            this.orderDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblsearch);
            this.groupBox1.Controls.Add(this.btnok);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.dvgviewdetails);
            this.groupBox1.Controls.Add(this.dgvorderfromsupplier);
            this.groupBox1.Controls.Add(this.btnview);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 461);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnok.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.Location = new System.Drawing.Point(542, 402);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 26);
            this.btnok.TabIndex = 5;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // tblOrdersTableAdapter
            // 
            this.tblOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // tblOrderDetailsTableAdapter
            // 
            this.tblOrderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(636, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 519);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 3);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 519);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 3);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(659, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 516);
            this.panel4.TabIndex = 10;
            // 
            // frm_view_order_from_supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(662, 522);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_view_order_from_supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_view_order_from_supplier";
            this.Load += new System.EventHandler(this.frm_view_order_from_supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderfromsupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderFromSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgviewdetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvorderfromsupplier;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.DataGridView dvgviewdetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnok;
        private OrderFromSupplier orderFromSupplier;
        private System.Windows.Forms.BindingSource tblOrdersBindingSource;
        private OrderFromSupplierTableAdapters.tblOrdersTableAdapter tblOrdersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private OrderDetails orderDetails;
        private System.Windows.Forms.BindingSource tblOrderDetailsBindingSource;
        private OrderDetailsTableAdapters.tblOrderDetailsTableAdapter tblOrderDetailsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}