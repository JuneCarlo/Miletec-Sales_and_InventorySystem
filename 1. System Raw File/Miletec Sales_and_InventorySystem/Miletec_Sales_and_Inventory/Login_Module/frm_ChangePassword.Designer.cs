namespace Miletec_Sales_and_Inventory
{
    partial class frm_ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChangePassword));
            this.lblconfirmnewpassword = new System.Windows.Forms.Label();
            this.lblnewpassword = new System.Windows.Forms.Label();
            this.lbloldpassword = new System.Windows.Forms.Label();
            this.txtconnewpass = new System.Windows.Forms.TextBox();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.txtoldpass = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.gbchangepass = new System.Windows.Forms.GroupBox();
            this.gbreset = new System.Windows.Forms.GroupBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btncancelreset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpasswordreset = new System.Windows.Forms.TextBox();
            this.txtusernamereset = new System.Windows.Forms.TextBox();
            this.btnresetform = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbchangepass.SuspendLayout();
            this.gbreset.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblconfirmnewpassword
            // 
            this.lblconfirmnewpassword.AutoSize = true;
            this.lblconfirmnewpassword.BackColor = System.Drawing.Color.White;
            this.lblconfirmnewpassword.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmnewpassword.ForeColor = System.Drawing.Color.Black;
            this.lblconfirmnewpassword.Location = new System.Drawing.Point(41, 158);
            this.lblconfirmnewpassword.Name = "lblconfirmnewpassword";
            this.lblconfirmnewpassword.Size = new System.Drawing.Size(177, 18);
            this.lblconfirmnewpassword.TabIndex = 6;
            this.lblconfirmnewpassword.Text = "Confirm NewPassword";
            // 
            // lblnewpassword
            // 
            this.lblnewpassword.AutoSize = true;
            this.lblnewpassword.BackColor = System.Drawing.Color.White;
            this.lblnewpassword.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpassword.ForeColor = System.Drawing.Color.Black;
            this.lblnewpassword.Location = new System.Drawing.Point(41, 120);
            this.lblnewpassword.Name = "lblnewpassword";
            this.lblnewpassword.Size = new System.Drawing.Size(118, 18);
            this.lblnewpassword.TabIndex = 7;
            this.lblnewpassword.Text = "New Password";
            // 
            // lbloldpassword
            // 
            this.lbloldpassword.AutoSize = true;
            this.lbloldpassword.BackColor = System.Drawing.Color.White;
            this.lbloldpassword.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloldpassword.ForeColor = System.Drawing.Color.Black;
            this.lbloldpassword.Location = new System.Drawing.Point(41, 83);
            this.lbloldpassword.Name = "lbloldpassword";
            this.lbloldpassword.Size = new System.Drawing.Size(109, 18);
            this.lbloldpassword.TabIndex = 8;
            this.lbloldpassword.Text = "Old Password";
            // 
            // txtconnewpass
            // 
            this.txtconnewpass.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconnewpass.Location = new System.Drawing.Point(40, 154);
            this.txtconnewpass.Name = "txtconnewpass";
            this.txtconnewpass.Size = new System.Drawing.Size(351, 26);
            this.txtconnewpass.TabIndex = 3;
            this.txtconnewpass.UseSystemPasswordChar = true;
            this.txtconnewpass.Click += new System.EventHandler(this.txtconnewpass_Click);
            this.txtconnewpass.TabIndexChanged += new System.EventHandler(this.txtconnewpass_TabIndexChanged);
            this.txtconnewpass.TextChanged += new System.EventHandler(this.txtconnewpass_TextChanged);
            this.txtconnewpass.Leave += new System.EventHandler(this.txtconnewpass_Leave);
            // 
            // txtnewpass
            // 
            this.txtnewpass.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpass.Location = new System.Drawing.Point(40, 116);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(351, 26);
            this.txtnewpass.TabIndex = 2;
            this.txtnewpass.UseSystemPasswordChar = true;
            this.txtnewpass.Click += new System.EventHandler(this.txtnewpass_Click);
            this.txtnewpass.TabIndexChanged += new System.EventHandler(this.txtnewpass_TabIndexChanged);
            this.txtnewpass.TextChanged += new System.EventHandler(this.txtnewpass_TextChanged);
            this.txtnewpass.Leave += new System.EventHandler(this.txtnewpass_Leave);
            // 
            // txtoldpass
            // 
            this.txtoldpass.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoldpass.Location = new System.Drawing.Point(40, 79);
            this.txtoldpass.Name = "txtoldpass";
            this.txtoldpass.Size = new System.Drawing.Size(351, 26);
            this.txtoldpass.TabIndex = 1;
            this.txtoldpass.UseSystemPasswordChar = true;
            this.txtoldpass.Click += new System.EventHandler(this.txtoldpass_Click);
            this.txtoldpass.TabIndexChanged += new System.EventHandler(this.txtoldpass_TabIndexChanged);
            this.txtoldpass.TextChanged += new System.EventHandler(this.txtoldpass_TextChanged);
            this.txtoldpass.Leave += new System.EventHandler(this.txtoldpass_Leave);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.White;
            this.txtusername.Enabled = false;
            this.txtusername.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(40, 33);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(351, 26);
            this.txtusername.TabIndex = 0;
            this.txtusername.Text = "Username";
            this.txtusername.Click += new System.EventHandler(this.txtusername_Click);
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            this.txtusername.Leave += new System.EventHandler(this.txtusername_Leave);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(182, 198);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(97, 27);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(293, 198);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(97, 27);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // gbchangepass
            // 
            this.gbchangepass.BackColor = System.Drawing.Color.Transparent;
            this.gbchangepass.Controls.Add(this.lblconfirmnewpassword);
            this.gbchangepass.Controls.Add(this.lblnewpassword);
            this.gbchangepass.Controls.Add(this.lbloldpassword);
            this.gbchangepass.Controls.Add(this.btncancel);
            this.gbchangepass.Controls.Add(this.txtusername);
            this.gbchangepass.Controls.Add(this.txtoldpass);
            this.gbchangepass.Controls.Add(this.btnsave);
            this.gbchangepass.Controls.Add(this.txtnewpass);
            this.gbchangepass.Controls.Add(this.txtconnewpass);
            this.gbchangepass.Location = new System.Drawing.Point(23, 54);
            this.gbchangepass.Name = "gbchangepass";
            this.gbchangepass.Size = new System.Drawing.Size(424, 244);
            this.gbchangepass.TabIndex = 12;
            this.gbchangepass.TabStop = false;
            // 
            // gbreset
            // 
            this.gbreset.BackColor = System.Drawing.Color.Transparent;
            this.gbreset.Controls.Add(this.btnreset);
            this.gbreset.Controls.Add(this.btncancelreset);
            this.gbreset.Controls.Add(this.label7);
            this.gbreset.Controls.Add(this.label6);
            this.gbreset.Controls.Add(this.txtpasswordreset);
            this.gbreset.Controls.Add(this.txtusernamereset);
            this.gbreset.Location = new System.Drawing.Point(82, 54);
            this.gbreset.Name = "gbreset";
            this.gbreset.Size = new System.Drawing.Size(329, 192);
            this.gbreset.TabIndex = 15;
            this.gbreset.TabStop = false;
            this.gbreset.Text = "RESET FORM";
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnreset.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.Location = new System.Drawing.Point(198, 123);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(90, 25);
            this.btnreset.TabIndex = 2;
            this.btnreset.Text = "RESET";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btncancelreset
            // 
            this.btncancelreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btncancelreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelreset.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelreset.ForeColor = System.Drawing.Color.White;
            this.btncancelreset.Location = new System.Drawing.Point(102, 123);
            this.btncancelreset.Name = "btncancelreset";
            this.btncancelreset.Size = new System.Drawing.Size(90, 25);
            this.btncancelreset.TabIndex = 3;
            this.btncancelreset.Text = "CANCEL";
            this.btncancelreset.UseVisualStyleBackColor = false;
            this.btncancelreset.Click += new System.EventHandler(this.btncancelreset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Username:";
            // 
            // txtpasswordreset
            // 
            this.txtpasswordreset.Enabled = false;
            this.txtpasswordreset.Location = new System.Drawing.Point(129, 83);
            this.txtpasswordreset.Name = "txtpasswordreset";
            this.txtpasswordreset.Size = new System.Drawing.Size(159, 20);
            this.txtpasswordreset.TabIndex = 0;
            this.txtpasswordreset.Text = "Passwrod";
            // 
            // txtusernamereset
            // 
            this.txtusernamereset.Location = new System.Drawing.Point(129, 45);
            this.txtusernamereset.Name = "txtusernamereset";
            this.txtusernamereset.Size = new System.Drawing.Size(159, 20);
            this.txtusernamereset.TabIndex = 0;
            // 
            // btnresetform
            // 
            this.btnresetform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnresetform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnresetform.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnresetform.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetform.ForeColor = System.Drawing.Color.White;
            this.btnresetform.Location = new System.Drawing.Point(54, 321);
            this.btnresetform.Name = "btnresetform";
            this.btnresetform.Size = new System.Drawing.Size(112, 51);
            this.btnresetform.TabIndex = 6;
            this.btnresetform.Text = "RESET";
            this.btnresetform.UseVisualStyleBackColor = false;
            this.btnresetform.Click += new System.EventHandler(this.btnresetform_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(454, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 427);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 424);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 3);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(477, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 424);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(474, 3);
            this.panel4.TabIndex = 23;
            // 
            // frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(480, 427);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnresetform);
            this.Controls.Add(this.gbchangepass);
            this.Controls.Add(this.gbreset);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ChangePassword";
            this.Load += new System.EventHandler(this.frm_ChangePassword_Load);
            this.gbchangepass.ResumeLayout(false);
            this.gbchangepass.PerformLayout();
            this.gbreset.ResumeLayout(false);
            this.gbreset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblconfirmnewpassword;
        private System.Windows.Forms.Label lblnewpassword;
        private System.Windows.Forms.Label lbloldpassword;
        private System.Windows.Forms.TextBox txtconnewpass;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.TextBox txtoldpass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.GroupBox gbchangepass;
        private System.Windows.Forms.GroupBox gbreset;
        private System.Windows.Forms.Button btncancelreset;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpasswordreset;
        private System.Windows.Forms.TextBox txtusernamereset;
        private System.Windows.Forms.Button btnresetform;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}