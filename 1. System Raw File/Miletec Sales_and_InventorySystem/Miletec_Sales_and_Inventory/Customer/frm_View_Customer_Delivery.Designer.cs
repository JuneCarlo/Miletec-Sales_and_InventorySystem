namespace Miletec_Sales_and_Inventory
{
    partial class frm_View_Customer_Delivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_Customer_Delivery));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDeliveryDetails = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.dgvCustomerDelivery = new System.Windows.Forms.DataGridView();
            this.deliveryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timetoDeliverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCustomerDeliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miletecDataSet7 = new Miletec_Sales_and_Inventory.MiletecDataSet7();
            this.tblCustomerDeliveryTableAdapter = new Miletec_Sales_and_Inventory.MiletecDataSet7TableAdapters.tblCustomerDeliveryTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryDetails)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerDeliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 451);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDeliveryDetails);
            this.groupBox3.Location = new System.Drawing.Point(15, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(655, 195);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dgvDeliveryDetails
            // 
            this.dgvDeliveryDetails.AllowUserToAddRows = false;
            this.dgvDeliveryDetails.AllowUserToDeleteRows = false;
            this.dgvDeliveryDetails.AllowUserToResizeColumns = false;
            this.dgvDeliveryDetails.AllowUserToResizeRows = false;
            this.dgvDeliveryDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveryDetails.Location = new System.Drawing.Point(20, 22);
            this.dgvDeliveryDetails.Name = "dgvDeliveryDetails";
            this.dgvDeliveryDetails.ReadOnly = true;
            this.dgvDeliveryDetails.Size = new System.Drawing.Size(619, 153);
            this.dgvDeliveryDetails.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnViewDetails);
            this.groupBox2.Controls.Add(this.dgvCustomerDelivery);
            this.groupBox2.Location = new System.Drawing.Point(15, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 220);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(20, 178);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 27);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Delivery";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnViewDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewDetails.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Location = new System.Drawing.Point(507, 177);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(132, 27);
            this.btnViewDetails.TabIndex = 1;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // dgvCustomerDelivery
            // 
            this.dgvCustomerDelivery.AllowUserToAddRows = false;
            this.dgvCustomerDelivery.AllowUserToDeleteRows = false;
            this.dgvCustomerDelivery.AllowUserToResizeColumns = false;
            this.dgvCustomerDelivery.AllowUserToResizeRows = false;
            this.dgvCustomerDelivery.AutoGenerateColumns = false;
            this.dgvCustomerDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerDelivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliveryIDDataGridViewTextBoxColumn,
            this.transactionidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.preparedbyDataGridViewTextBoxColumn,
            this.timetoDeliverDataGridViewTextBoxColumn});
            this.dgvCustomerDelivery.DataSource = this.tblCustomerDeliveryBindingSource;
            this.dgvCustomerDelivery.Location = new System.Drawing.Point(20, 19);
            this.dgvCustomerDelivery.Name = "dgvCustomerDelivery";
            this.dgvCustomerDelivery.ReadOnly = true;
            this.dgvCustomerDelivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerDelivery.Size = new System.Drawing.Size(619, 153);
            this.dgvCustomerDelivery.TabIndex = 0;
            this.dgvCustomerDelivery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerDelivery_CellClick);
            this.dgvCustomerDelivery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerDelivery_CellContentClick);
            // 
            // deliveryIDDataGridViewTextBoxColumn
            // 
            this.deliveryIDDataGridViewTextBoxColumn.DataPropertyName = "DeliveryID";
            this.deliveryIDDataGridViewTextBoxColumn.HeaderText = "Delivery ID";
            this.deliveryIDDataGridViewTextBoxColumn.Name = "deliveryIDDataGridViewTextBoxColumn";
            this.deliveryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryIDDataGridViewTextBoxColumn.Width = 130;
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
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 130;
            // 
            // preparedbyDataGridViewTextBoxColumn
            // 
            this.preparedbyDataGridViewTextBoxColumn.DataPropertyName = "preparedby";
            this.preparedbyDataGridViewTextBoxColumn.HeaderText = "Prepared by";
            this.preparedbyDataGridViewTextBoxColumn.Name = "preparedbyDataGridViewTextBoxColumn";
            this.preparedbyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timetoDeliverDataGridViewTextBoxColumn
            // 
            this.timetoDeliverDataGridViewTextBoxColumn.DataPropertyName = "TimetoDeliver";
            this.timetoDeliverDataGridViewTextBoxColumn.HeaderText = "Time to Deliver";
            this.timetoDeliverDataGridViewTextBoxColumn.Name = "timetoDeliverDataGridViewTextBoxColumn";
            this.timetoDeliverDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblCustomerDeliveryBindingSource
            // 
            this.tblCustomerDeliveryBindingSource.DataMember = "tblCustomerDelivery";
            this.tblCustomerDeliveryBindingSource.DataSource = this.miletecDataSet7;
            // 
            // miletecDataSet7
            // 
            this.miletecDataSet7.DataSetName = "MiletecDataSet7";
            this.miletecDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCustomerDeliveryTableAdapter
            // 
            this.tblCustomerDeliveryTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(685, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.panel2.Size = new System.Drawing.Size(3, 526);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 526);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(708, 3);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 523);
            this.panel4.TabIndex = 5;
            // 
            // frm_View_Customer_Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(711, 529);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_View_Customer_Delivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_View_Customer_Delivery";
            this.Load += new System.EventHandler(this.frm_View_Customer_Delivery_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryDetails)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerDeliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCustomerDelivery;
        private System.Windows.Forms.DataGridView dgvDeliveryDetails;
        private MiletecDataSet7 miletecDataSet7;
        private System.Windows.Forms.BindingSource tblCustomerDeliveryBindingSource;
        private MiletecDataSet7TableAdapters.tblCustomerDeliveryTableAdapter tblCustomerDeliveryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparedbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timetoDeliverDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpdate;
    }
}