namespace Miletec_Sales_and_Inventory
{
    partial class frm_View_Delivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_Delivery));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDeliveryDetails = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.dgvDeliveryFromSupplier = new System.Windows.Forms.DataGridView();
            this.deliveryNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparedAndReceivedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveredByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDeliverySupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miletecDataSet1 = new Miletec_Sales_and_Inventory.MiletecDataSet1();
            this.tblDelivery_SupplierTableAdapter = new Miletec_Sales_and_Inventory.MiletecDataSet1TableAdapters.tblDelivery_SupplierTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryDetails)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryFromSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeliverySupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 481);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDeliveryDetails);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(16, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(655, 195);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // dgvDeliveryDetails
            // 
            this.dgvDeliveryDetails.AllowUserToAddRows = false;
            this.dgvDeliveryDetails.AllowUserToDeleteRows = false;
            this.dgvDeliveryDetails.AllowUserToResizeColumns = false;
            this.dgvDeliveryDetails.AllowUserToResizeRows = false;
            this.dgvDeliveryDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeliveryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveryDetails.Location = new System.Drawing.Point(16, 29);
            this.dgvDeliveryDetails.Name = "dgvDeliveryDetails";
            this.dgvDeliveryDetails.ReadOnly = true;
            this.dgvDeliveryDetails.Size = new System.Drawing.Size(619, 150);
            this.dgvDeliveryDetails.TabIndex = 0;
            this.dgvDeliveryDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliveryDetails_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblsearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnShowDetails);
            this.groupBox2.Controls.Add(this.dgvDeliveryFromSupplier);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(16, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 245);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.Color.White;
            this.lblsearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.ForeColor = System.Drawing.Color.Black;
            this.lblsearch.Location = new System.Drawing.Point(17, 23);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(59, 18);
            this.lblsearch.TabIndex = 2;
            this.lblsearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(16, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(190, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnShowDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowDetails.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.ForeColor = System.Drawing.Color.White;
            this.btnShowDetails.Location = new System.Drawing.Point(518, 208);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(117, 27);
            this.btnShowDetails.TabIndex = 1;
            this.btnShowDetails.Text = "View Details";
            this.btnShowDetails.UseVisualStyleBackColor = false;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // dgvDeliveryFromSupplier
            // 
            this.dgvDeliveryFromSupplier.AllowUserToAddRows = false;
            this.dgvDeliveryFromSupplier.AllowUserToDeleteRows = false;
            this.dgvDeliveryFromSupplier.AllowUserToResizeColumns = false;
            this.dgvDeliveryFromSupplier.AllowUserToResizeRows = false;
            this.dgvDeliveryFromSupplier.AutoGenerateColumns = false;
            this.dgvDeliveryFromSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveryFromSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliveryNoDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.preparedAndReceivedByDataGridViewTextBoxColumn,
            this.deliveredByDataGridViewTextBoxColumn});
            this.dgvDeliveryFromSupplier.DataSource = this.tblDeliverySupplierBindingSource;
            this.dgvDeliveryFromSupplier.Location = new System.Drawing.Point(16, 49);
            this.dgvDeliveryFromSupplier.Name = "dgvDeliveryFromSupplier";
            this.dgvDeliveryFromSupplier.ReadOnly = true;
            this.dgvDeliveryFromSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliveryFromSupplier.Size = new System.Drawing.Size(619, 153);
            this.dgvDeliveryFromSupplier.TabIndex = 0;
            this.dgvDeliveryFromSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliveryFromSupplier_CellClick);
            this.dgvDeliveryFromSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliveryFromSupplier_CellContentClick);
            // 
            // deliveryNoDataGridViewTextBoxColumn
            // 
            this.deliveryNoDataGridViewTextBoxColumn.DataPropertyName = "DeliveryNo";
            this.deliveryNoDataGridViewTextBoxColumn.HeaderText = "Delivery No";
            this.deliveryNoDataGridViewTextBoxColumn.Name = "deliveryNoDataGridViewTextBoxColumn";
            this.deliveryNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // preparedAndReceivedByDataGridViewTextBoxColumn
            // 
            this.preparedAndReceivedByDataGridViewTextBoxColumn.DataPropertyName = "PreparedAndReceivedBy";
            this.preparedAndReceivedByDataGridViewTextBoxColumn.HeaderText = "Prepared and Received By";
            this.preparedAndReceivedByDataGridViewTextBoxColumn.Name = "preparedAndReceivedByDataGridViewTextBoxColumn";
            this.preparedAndReceivedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveredByDataGridViewTextBoxColumn
            // 
            this.deliveredByDataGridViewTextBoxColumn.DataPropertyName = "DeliveredBy";
            this.deliveredByDataGridViewTextBoxColumn.HeaderText = "Delivered By";
            this.deliveredByDataGridViewTextBoxColumn.Name = "deliveredByDataGridViewTextBoxColumn";
            this.deliveredByDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveredByDataGridViewTextBoxColumn.Width = 130;
            // 
            // tblDeliverySupplierBindingSource
            // 
            this.tblDeliverySupplierBindingSource.DataMember = "tblDelivery_Supplier";
            this.tblDeliverySupplierBindingSource.DataSource = this.miletecDataSet1;
            // 
            // miletecDataSet1
            // 
            this.miletecDataSet1.DataSetName = "MiletecDataSet1";
            this.miletecDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDelivery_SupplierTableAdapter
            // 
            this.tblDelivery_SupplierTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(685, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 3);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(708, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 540);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 540);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(708, 3);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 537);
            this.panel4.TabIndex = 5;
            // 
            // frm_View_Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(711, 543);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_View_Delivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_View_Delivery";
            this.Load += new System.EventHandler(this.frm_View_Delivery_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryDetails)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryFromSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDeliverySupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDeliveryDetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.DataGridView dgvDeliveryFromSupplier;
        private MiletecDataSet1 miletecDataSet1;
        private System.Windows.Forms.BindingSource tblDeliverySupplierBindingSource;
        private MiletecDataSet1TableAdapters.tblDelivery_SupplierTableAdapter tblDelivery_SupplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparedAndReceivedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveredByDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;

    }
}