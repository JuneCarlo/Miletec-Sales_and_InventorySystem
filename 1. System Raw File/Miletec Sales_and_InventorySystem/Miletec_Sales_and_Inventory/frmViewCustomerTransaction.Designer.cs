namespace Miletec_Sales_and_Inventory
{
    partial class frmViewCustomerTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewCustomerTransaction));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTransactionDetails = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.dgvCustomerTransaction = new System.Windows.Forms.DataGridView();
            this.transactionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashrenderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcustomertransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewCustomerTransaction = new Miletec_Sales_and_Inventory.ViewCustomerTransaction();
            this.tblcustomertransactionTableAdapter = new Miletec_Sales_and_Inventory.ViewCustomerTransactionTableAdapters.tblcustomertransactionTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDetails)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomertransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomerTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 463);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Transactions";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(624, 426);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 27);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvTransactionDetails);
            this.groupBox3.Location = new System.Drawing.Point(16, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(703, 187);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Transaction Details";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dgvTransactionDetails
            // 
            this.dgvTransactionDetails.AllowUserToAddRows = false;
            this.dgvTransactionDetails.AllowUserToDeleteRows = false;
            this.dgvTransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionDetails.Location = new System.Drawing.Point(16, 19);
            this.dgvTransactionDetails.Name = "dgvTransactionDetails";
            this.dgvTransactionDetails.ReadOnly = true;
            this.dgvTransactionDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactionDetails.Size = new System.Drawing.Size(671, 150);
            this.dgvTransactionDetails.TabIndex = 0;
            this.dgvTransactionDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactionDetails_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnView);
            this.groupBox2.Controls.Add(this.dgvCustomerTransaction);
            this.groupBox2.Location = new System.Drawing.Point(16, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 226);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(541, 193);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(145, 29);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View Details";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dgvCustomerTransaction
            // 
            this.dgvCustomerTransaction.AllowUserToAddRows = false;
            this.dgvCustomerTransaction.AllowUserToDeleteRows = false;
            this.dgvCustomerTransaction.AllowUserToResizeColumns = false;
            this.dgvCustomerTransaction.AllowUserToResizeRows = false;
            this.dgvCustomerTransaction.AutoGenerateColumns = false;
            this.dgvCustomerTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionidDataGridViewTextBoxColumn,
            this.dateOrderDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.customeridDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.gtotalDataGridViewTextBoxColumn,
            this.cashrenderedDataGridViewTextBoxColumn,
            this.unitpriceDataGridViewTextBoxColumn,
            this.changeDataGridViewTextBoxColumn});
            this.dgvCustomerTransaction.DataSource = this.tblcustomertransactionBindingSource;
            this.dgvCustomerTransaction.Location = new System.Drawing.Point(16, 19);
            this.dgvCustomerTransaction.Name = "dgvCustomerTransaction";
            this.dgvCustomerTransaction.ReadOnly = true;
            this.dgvCustomerTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerTransaction.Size = new System.Drawing.Size(671, 171);
            this.dgvCustomerTransaction.TabIndex = 0;
            this.dgvCustomerTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerTransaction_CellClick);
            this.dgvCustomerTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerTransaction_CellContentClick);
            // 
            // transactionidDataGridViewTextBoxColumn
            // 
            this.transactionidDataGridViewTextBoxColumn.DataPropertyName = "transactionid";
            this.transactionidDataGridViewTextBoxColumn.HeaderText = "Transaction ID";
            this.transactionidDataGridViewTextBoxColumn.Name = "transactionidDataGridViewTextBoxColumn";
            this.transactionidDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactionidDataGridViewTextBoxColumn.Width = 130;
            // 
            // dateOrderDataGridViewTextBoxColumn
            // 
            this.dateOrderDataGridViewTextBoxColumn.DataPropertyName = "dateOrder";
            this.dateOrderDataGridViewTextBoxColumn.HeaderText = "Date Ordered";
            this.dateOrderDataGridViewTextBoxColumn.Name = "dateOrderDataGridViewTextBoxColumn";
            this.dateOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date(Delivery)";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time(Delivery)";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customerid";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "Customer ID";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.customeridDataGridViewTextBoxColumn.Width = 130;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // gtotalDataGridViewTextBoxColumn
            // 
            this.gtotalDataGridViewTextBoxColumn.DataPropertyName = "Gtotal";
            this.gtotalDataGridViewTextBoxColumn.HeaderText = "Grand Total";
            this.gtotalDataGridViewTextBoxColumn.Name = "gtotalDataGridViewTextBoxColumn";
            this.gtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cashrenderedDataGridViewTextBoxColumn
            // 
            this.cashrenderedDataGridViewTextBoxColumn.DataPropertyName = "Cashrendered";
            this.cashrenderedDataGridViewTextBoxColumn.HeaderText = "Cash Rendered";
            this.cashrenderedDataGridViewTextBoxColumn.Name = "cashrenderedDataGridViewTextBoxColumn";
            this.cashrenderedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitpriceDataGridViewTextBoxColumn
            // 
            this.unitpriceDataGridViewTextBoxColumn.DataPropertyName = "unitprice";
            this.unitpriceDataGridViewTextBoxColumn.HeaderText = "Unit Price";
            this.unitpriceDataGridViewTextBoxColumn.Name = "unitpriceDataGridViewTextBoxColumn";
            this.unitpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // changeDataGridViewTextBoxColumn
            // 
            this.changeDataGridViewTextBoxColumn.DataPropertyName = "change";
            this.changeDataGridViewTextBoxColumn.HeaderText = "Change";
            this.changeDataGridViewTextBoxColumn.Name = "changeDataGridViewTextBoxColumn";
            this.changeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblcustomertransactionBindingSource
            // 
            this.tblcustomertransactionBindingSource.DataMember = "tblcustomertransaction";
            this.tblcustomertransactionBindingSource.DataSource = this.viewCustomerTransaction;
            // 
            // viewCustomerTransaction
            // 
            this.viewCustomerTransaction.DataSetName = "ViewCustomerTransaction";
            this.viewCustomerTransaction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcustomertransactionTableAdapter
            // 
            this.tblcustomertransactionTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(733, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 3);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(755, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 520);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 520);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(755, 3);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 517);
            this.panel4.TabIndex = 6;
            // 
            // frmViewCustomerTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(758, 523);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewCustomerTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ViewOrdersFromCustomer";
            this.Load += new System.EventHandler(this.frm_ViewOrdersFromCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionDetails)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomertransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomerTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCustomerTransaction;
        private ViewCustomerTransaction viewCustomerTransaction;
        private System.Windows.Forms.BindingSource tblcustomertransactionBindingSource;
        private ViewCustomerTransactionTableAdapters.tblcustomertransactionTableAdapter tblcustomertransactionTableAdapter;
        private System.Windows.Forms.DataGridView dgvTransactionDetails;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashrenderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;

    }
}