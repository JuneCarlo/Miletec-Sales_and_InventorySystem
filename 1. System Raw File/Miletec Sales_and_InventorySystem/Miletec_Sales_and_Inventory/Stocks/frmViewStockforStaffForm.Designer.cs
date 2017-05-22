namespace Miletec_Sales_and_Inventory
{
    partial class frmViewStockforStaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewStockforStaffForm));
            this.dgvviewstock = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSourceViewStock = new Miletec_Sales_and_Inventory.DataSourceViewStock();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.lblclose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tblStocksTableAdapter = new Miletec_Sales_and_Inventory.DataSourceViewStockTableAdapters.tblStocksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceViewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvviewstock
            // 
            this.dgvviewstock.AllowUserToAddRows = false;
            this.dgvviewstock.AllowUserToDeleteRows = false;
            this.dgvviewstock.AllowUserToResizeColumns = false;
            this.dgvviewstock.AllowUserToResizeRows = false;
            this.dgvviewstock.AutoGenerateColumns = false;
            this.dgvviewstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvviewstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvviewstock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.availqtyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgvviewstock.DataSource = this.tblStocksBindingSource;
            this.dgvviewstock.Location = new System.Drawing.Point(12, 83);
            this.dgvviewstock.Name = "dgvviewstock";
            this.dgvviewstock.ReadOnly = true;
            this.dgvviewstock.Size = new System.Drawing.Size(594, 225);
            this.dgvviewstock.TabIndex = 0;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "productid";
            this.productidDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "productname";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availqtyDataGridViewTextBoxColumn
            // 
            this.availqtyDataGridViewTextBoxColumn.DataPropertyName = "availqty";
            this.availqtyDataGridViewTextBoxColumn.HeaderText = "Available Quantity";
            this.availqtyDataGridViewTextBoxColumn.Name = "availqtyDataGridViewTextBoxColumn";
            this.availqtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblStocksBindingSource
            // 
            this.tblStocksBindingSource.DataMember = "tblStocks";
            this.tblStocksBindingSource.DataSource = this.dataSourceViewStock;
            // 
            // dataSourceViewStock
            // 
            this.dataSourceViewStock.DataSetName = "DataSourceViewStock";
            this.dataSourceViewStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(79, 54);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(240, 26);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.Click += new System.EventHandler(this.txtsearch_Click);
            this.txtsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtsearch.Leave += new System.EventHandler(this.txtsearch_Leave);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.Color.Transparent;
            this.lblsearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.ForeColor = System.Drawing.Color.Black;
            this.lblsearch.Location = new System.Drawing.Point(14, 59);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(59, 18);
            this.lblsearch.TabIndex = 2;
            this.lblsearch.Text = "Search";
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnok.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.Location = new System.Drawing.Point(12, 314);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(74, 27);
            this.btnok.TabIndex = 3;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.BackColor = System.Drawing.Color.Transparent;
            this.lblclose.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclose.ForeColor = System.Drawing.Color.White;
            this.lblclose.Location = new System.Drawing.Point(592, 9);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(23, 23);
            this.lblclose.TabIndex = 4;
            this.lblclose.Text = "X";
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 3);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(615, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 377);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 377);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 3);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 374);
            this.panel4.TabIndex = 8;
            // 
            // tblStocksTableAdapter
            // 
            this.tblStocksTableAdapter.ClearBeforeFill = true;
            // 
            // frmViewStockforStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(618, 380);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dgvviewstock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewStockforStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewStockforStaffForm";
            this.Load += new System.EventHandler(this.frmViewStockforStaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvviewstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSourceViewStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvviewstock;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label lblclose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DataSourceViewStock dataSourceViewStock;
        private System.Windows.Forms.BindingSource tblStocksBindingSource;
        private DataSourceViewStockTableAdapters.tblStocksTableAdapter tblStocksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}