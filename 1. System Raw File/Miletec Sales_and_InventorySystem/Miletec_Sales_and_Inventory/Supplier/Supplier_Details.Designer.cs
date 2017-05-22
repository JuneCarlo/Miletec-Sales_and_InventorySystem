namespace Miletec_Sales_and_Inventory
{
    partial class Supplier_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier_Details));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsupcancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.txtContact2 = new System.Windows.Forms.TextBox();
            this.txtContact1 = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.dgvsupplierdetails = new System.Windows.Forms.DataGridView();
            this.gbSupplierDetails = new System.Windows.Forms.GroupBox();
            this.miletecDataSet = new Miletec_Sales_and_Inventory.MiletecDataSet();
            this.tblOrderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblOrderDetailsTableAdapter = new Miletec_Sales_and_Inventory.MiletecDataSetTableAdapters.tblOrderDetailsTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnedit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsupplierdetails)).BeginInit();
            this.gbSupplierDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.btnsupcancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtContactPerson);
            this.groupBox1.Controls.Add(this.txtContact2);
            this.groupBox1.Controls.Add(this.txtContact1);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtSupplierName);
            this.groupBox1.Controls.Add(this.txtSupplierID);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnsupcancel
            // 
            this.btnsupcancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnsupcancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsupcancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsupcancel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupcancel.ForeColor = System.Drawing.Color.White;
            this.btnsupcancel.Location = new System.Drawing.Point(329, 222);
            this.btnsupcancel.Name = "btnsupcancel";
            this.btnsupcancel.Size = new System.Drawing.Size(86, 29);
            this.btnsupcancel.TabIndex = 7;
            this.btnsupcancel.Text = "CANCEL";
            this.btnsupcancel.UseVisualStyleBackColor = false;
            this.btnsupcancel.Click += new System.EventHandler(this.btnsupcancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(227, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(42, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "+639";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "+639";
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPerson.Location = new System.Drawing.Point(43, 178);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(399, 26);
            this.txtContactPerson.TabIndex = 5;
            this.txtContactPerson.Text = "Contact Person";
            this.txtContactPerson.Click += new System.EventHandler(this.txtContactPerson_Click);
            this.txtContactPerson.TextChanged += new System.EventHandler(this.txtContactPerson_TextChanged);
            this.txtContactPerson.Leave += new System.EventHandler(this.txtContactPerson_Leave);
            // 
            // txtContact2
            // 
            this.txtContact2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact2.Location = new System.Drawing.Point(98, 147);
            this.txtContact2.MaxLength = 9;
            this.txtContact2.Name = "txtContact2";
            this.txtContact2.Size = new System.Drawing.Size(344, 26);
            this.txtContact2.TabIndex = 4;
            this.txtContact2.Text = "Contact No.2";
            this.txtContact2.Click += new System.EventHandler(this.txtContact2_Click);
            this.txtContact2.TextChanged += new System.EventHandler(this.txtContact2_TextChanged);
            this.txtContact2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact2_KeyPress);
            this.txtContact2.Leave += new System.EventHandler(this.txtContact2_Leave);
            // 
            // txtContact1
            // 
            this.txtContact1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact1.Location = new System.Drawing.Point(98, 115);
            this.txtContact1.MaxLength = 9;
            this.txtContact1.Name = "txtContact1";
            this.txtContact1.Size = new System.Drawing.Size(344, 26);
            this.txtContact1.TabIndex = 3;
            this.txtContact1.Text = "Contact No.1";
            this.txtContact1.Click += new System.EventHandler(this.txtContact1_Click);
            this.txtContact1.TextChanged += new System.EventHandler(this.txtContact1_TextChanged);
            this.txtContact1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact1_KeyPress);
            this.txtContact1.Leave += new System.EventHandler(this.txtContact1_Leave);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(45, 83);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(397, 26);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Text = "Address";
            this.txtAddress.Click += new System.EventHandler(this.txtAddress_Click);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(45, 51);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(397, 26);
            this.txtSupplierName.TabIndex = 1;
            this.txtSupplierName.Text = "Supplier Name";
            this.txtSupplierName.Click += new System.EventHandler(this.txtSupplierName_Click);
            this.txtSupplierName.TextChanged += new System.EventHandler(this.txtSupplierName_TextChanged);
            this.txtSupplierName.Leave += new System.EventHandler(this.txtSupplierName_Leave);
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Enabled = false;
            this.txtSupplierID.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierID.Location = new System.Drawing.Point(45, 19);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(164, 26);
            this.txtSupplierID.TabIndex = 0;
            // 
            // dgvsupplierdetails
            // 
            this.dgvsupplierdetails.AllowUserToAddRows = false;
            this.dgvsupplierdetails.AllowUserToDeleteRows = false;
            this.dgvsupplierdetails.AllowUserToResizeColumns = false;
            this.dgvsupplierdetails.AllowUserToResizeRows = false;
            this.dgvsupplierdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsupplierdetails.Location = new System.Drawing.Point(9, 268);
            this.dgvsupplierdetails.Name = "dgvsupplierdetails";
            this.dgvsupplierdetails.ReadOnly = true;
            this.dgvsupplierdetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsupplierdetails.Size = new System.Drawing.Size(470, 151);
            this.dgvsupplierdetails.TabIndex = 1;
            this.dgvsupplierdetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsupplierdetails_CellClick);
            this.dgvsupplierdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsupplierdetails_CellContentClick);
            // 
            // gbSupplierDetails
            // 
            this.gbSupplierDetails.BackColor = System.Drawing.Color.Transparent;
            this.gbSupplierDetails.Controls.Add(this.groupBox1);
            this.gbSupplierDetails.Controls.Add(this.dgvsupplierdetails);
            this.gbSupplierDetails.Location = new System.Drawing.Point(38, 54);
            this.gbSupplierDetails.Name = "gbSupplierDetails";
            this.gbSupplierDetails.Size = new System.Drawing.Size(491, 426);
            this.gbSupplierDetails.TabIndex = 2;
            this.gbSupplierDetails.TabStop = false;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(545, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 3);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(568, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 482);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 482);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(568, 3);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 479);
            this.panel4.TabIndex = 7;
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnedit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(124, 222);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(85, 27);
            this.btnedit.TabIndex = 8;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // Supplier_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(571, 485);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbSupplierDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supplier_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier_Details";
            this.Load += new System.EventHandler(this.Supplier_Details_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsupplierdetails)).EndInit();
            this.gbSupplierDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.miletecDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.TextBox txtContact2;
        private System.Windows.Forms.TextBox txtContact1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.DataGridView dgvsupplierdetails;
        private System.Windows.Forms.GroupBox gbSupplierDetails;
        private System.Windows.Forms.Button btnsupcancel;
        private MiletecDataSet miletecDataSet;
        private System.Windows.Forms.BindingSource tblOrderDetailsBindingSource;
        private MiletecDataSetTableAdapters.tblOrderDetailsTableAdapter tblOrderDetailsTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnedit;
    }
}