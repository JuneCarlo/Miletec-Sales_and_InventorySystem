namespace Miletec_Sales_and_Inventory
{
    partial class frm_Customer_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Customer_Details));
            this.btnsave = new System.Windows.Forms.Button();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.dgvcustomerdetails = new System.Windows.Forms.DataGridView();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtcontactno1 = new System.Windows.Forms.TextBox();
            this.txtcontactno2 = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblsearch = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomerdetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(244, 292);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(117, 27);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Enabled = false;
            this.txtcustomerid.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomerid.Location = new System.Drawing.Point(12, 92);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(154, 26);
            this.txtcustomerid.TabIndex = 0;
            this.txtcustomerid.Text = "Customer ID";
            this.txtcustomerid.TextChanged += new System.EventHandler(this.txtcustomerid_TextChanged);
            // 
            // dgvcustomerdetails
            // 
            this.dgvcustomerdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcustomerdetails.Location = new System.Drawing.Point(6, 10);
            this.dgvcustomerdetails.Name = "dgvcustomerdetails";
            this.dgvcustomerdetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcustomerdetails.Size = new System.Drawing.Size(393, 150);
            this.dgvcustomerdetails.TabIndex = 3;
            this.dgvcustomerdetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcustomerdetails_CellClick);
            this.dgvcustomerdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcustomerdetails_CellContentClick);
            // 
            // txtcustomername
            // 
            this.txtcustomername.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomername.ForeColor = System.Drawing.Color.Black;
            this.txtcustomername.Location = new System.Drawing.Point(12, 129);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(349, 26);
            this.txtcustomername.TabIndex = 0;
            this.txtcustomername.Text = "Customer Name";
            this.txtcustomername.Click += new System.EventHandler(this.txtcustomername_Click);
            this.txtcustomername.TextChanged += new System.EventHandler(this.txtcustomername_TextChanged);
            this.txtcustomername.Leave += new System.EventHandler(this.txtcustomername_Leave);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(12, 167);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(349, 26);
            this.txtaddress.TabIndex = 1;
            this.txtaddress.Text = "Address";
            this.txtaddress.Click += new System.EventHandler(this.txtaddress_Click);
            this.txtaddress.Leave += new System.EventHandler(this.txtaddress_Leave);
            // 
            // txtcontactno1
            // 
            this.txtcontactno1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontactno1.Location = new System.Drawing.Point(12, 205);
            this.txtcontactno1.MaxLength = 11;
            this.txtcontactno1.Name = "txtcontactno1";
            this.txtcontactno1.Size = new System.Drawing.Size(349, 26);
            this.txtcontactno1.TabIndex = 2;
            this.txtcontactno1.Text = "Contactno.1";
            this.txtcontactno1.Click += new System.EventHandler(this.txtcontactno1_Click);
            this.txtcontactno1.TextChanged += new System.EventHandler(this.txtcontactno1_TextChanged);
            this.txtcontactno1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontactno1_KeyPress);
            this.txtcontactno1.Leave += new System.EventHandler(this.txtcontactno1_Leave);
            // 
            // txtcontactno2
            // 
            this.txtcontactno2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontactno2.Location = new System.Drawing.Point(12, 242);
            this.txtcontactno2.MaxLength = 11;
            this.txtcontactno2.Name = "txtcontactno2";
            this.txtcontactno2.Size = new System.Drawing.Size(349, 26);
            this.txtcontactno2.TabIndex = 3;
            this.txtcontactno2.Text = "Contactno.2";
            this.txtcontactno2.Click += new System.EventHandler(this.txtcontactno2_Click);
            this.txtcontactno2.TextChanged += new System.EventHandler(this.txtcontactno2_TextChanged);
            this.txtcontactno2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontactno2_KeyPress);
            this.txtcontactno2.Leave += new System.EventHandler(this.txtcontactno2_Leave);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(385, 95);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(228, 26);
            this.txtsearch.TabIndex = 6;
            this.txtsearch.Click += new System.EventHandler(this.txtsearch_Click);
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.Leave += new System.EventHandler(this.txtsearch_Leave);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.Enabled = false;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnedit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(429, 292);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(89, 27);
            this.btnedit.TabIndex = 5;
            this.btnedit.Text = "UPDATE";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Enabled = false;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(710, 294);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(80, 27);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(774, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.Color.White;
            this.lblsearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.ForeColor = System.Drawing.Color.Black;
            this.lblsearch.Location = new System.Drawing.Point(388, 99);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(59, 18);
            this.lblsearch.TabIndex = 8;
            this.lblsearch.Text = "Search";
            this.lblsearch.Click += new System.EventHandler(this.lblsearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvcustomerdetails);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(385, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 164);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 3);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 364);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(803, 3);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(803, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 361);
            this.panel4.TabIndex = 13;
            // 
            // frm_Customer_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(806, 367);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.txtcustomerid);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtcontactno1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtcustomername);
            this.Controls.Add(this.txtcontactno2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Customer_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Customer_Details";
            this.Load += new System.EventHandler(this.frm_Customer_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomerdetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.DataGridView dgvcustomerdetails;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtcontactno1;
        private System.Windows.Forms.TextBox txtcontactno2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}