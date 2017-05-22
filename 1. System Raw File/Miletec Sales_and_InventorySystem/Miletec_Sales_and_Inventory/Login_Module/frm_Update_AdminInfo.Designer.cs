namespace Miletec_Sales_and_Inventory
{
    partial class frm_Update_AdminInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Update_AdminInfo));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbSecretQuestion = new System.Windows.Forms.ComboBox();
            this.txtSecretAnswer = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblnewpassword = new System.Windows.Forms.Label();
            this.lblconfirmpassword = new System.Windows.Forms.Label();
            this.lblsecretquestion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(61, 258);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(170, 29);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbSecretQuestion
            // 
            this.cmbSecretQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecretQuestion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSecretQuestion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbSecretQuestion.FormattingEnabled = true;
            this.cmbSecretQuestion.Items.AddRange(new object[] {
            "What is your favorite place?",
            "What is your favorite pet?",
            "What is the first name of the person who love\'s you?",
            "What is the name of the teacher who gave you failing grade?",
            "Who is your crush?"});
            this.cmbSecretQuestion.Location = new System.Drawing.Point(61, 182);
            this.cmbSecretQuestion.Name = "cmbSecretQuestion";
            this.cmbSecretQuestion.Size = new System.Drawing.Size(361, 26);
            this.cmbSecretQuestion.TabIndex = 3;
            this.cmbSecretQuestion.SelectedIndexChanged += new System.EventHandler(this.cmbSecretQuestion_SelectedIndexChanged);
            this.cmbSecretQuestion.Click += new System.EventHandler(this.cmbSecretQuestion_Click);
            this.cmbSecretQuestion.Leave += new System.EventHandler(this.cmbSecretQuestion_Leave);
            // 
            // txtSecretAnswer
            // 
            this.txtSecretAnswer.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretAnswer.ForeColor = System.Drawing.Color.Black;
            this.txtSecretAnswer.Location = new System.Drawing.Point(61, 217);
            this.txtSecretAnswer.Name = "txtSecretAnswer";
            this.txtSecretAnswer.Size = new System.Drawing.Size(361, 26);
            this.txtSecretAnswer.TabIndex = 4;
            this.txtSecretAnswer.Text = "Secret_Answer";
            this.txtSecretAnswer.Click += new System.EventHandler(this.txtSecretAnswer_Click);
            this.txtSecretAnswer.TextChanged += new System.EventHandler(this.txtSecretAnswer_TextChanged);
            this.txtSecretAnswer.Leave += new System.EventHandler(this.txtSecretAnswer_Leave);
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.Location = new System.Drawing.Point(61, 147);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(361, 26);
            this.txtConfirm.TabIndex = 2;
            this.txtConfirm.UseSystemPasswordChar = true;
            this.txtConfirm.Click += new System.EventHandler(this.txtConfirm_Click);
            this.txtConfirm.TextChanged += new System.EventHandler(this.txtConfirm_TextChanged);
            this.txtConfirm.Leave += new System.EventHandler(this.txtConfirm_Leave);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.Location = new System.Drawing.Point(61, 113);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(361, 26);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.Click += new System.EventHandler(this.txtNewPassword_Click);
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            this.txtNewPassword.Leave += new System.EventHandler(this.txtNewPassword_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(61, 78);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(361, 26);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // lblnewpassword
            // 
            this.lblnewpassword.AutoSize = true;
            this.lblnewpassword.BackColor = System.Drawing.Color.White;
            this.lblnewpassword.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpassword.ForeColor = System.Drawing.Color.Black;
            this.lblnewpassword.Location = new System.Drawing.Point(62, 116);
            this.lblnewpassword.Name = "lblnewpassword";
            this.lblnewpassword.Size = new System.Drawing.Size(118, 18);
            this.lblnewpassword.TabIndex = 49;
            this.lblnewpassword.Text = "New Password";
            // 
            // lblconfirmpassword
            // 
            this.lblconfirmpassword.AutoSize = true;
            this.lblconfirmpassword.BackColor = System.Drawing.Color.White;
            this.lblconfirmpassword.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmpassword.ForeColor = System.Drawing.Color.Black;
            this.lblconfirmpassword.Location = new System.Drawing.Point(61, 151);
            this.lblconfirmpassword.Name = "lblconfirmpassword";
            this.lblconfirmpassword.Size = new System.Drawing.Size(144, 18);
            this.lblconfirmpassword.TabIndex = 49;
            this.lblconfirmpassword.Text = "Confirm Password";
            this.lblconfirmpassword.Click += new System.EventHandler(this.lblconfirmpassword_Click);
            // 
            // lblsecretquestion
            // 
            this.lblsecretquestion.AutoSize = true;
            this.lblsecretquestion.BackColor = System.Drawing.Color.White;
            this.lblsecretquestion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecretquestion.ForeColor = System.Drawing.Color.Black;
            this.lblsecretquestion.Location = new System.Drawing.Point(62, 186);
            this.lblsecretquestion.Name = "lblsecretquestion";
            this.lblsecretquestion.Size = new System.Drawing.Size(132, 18);
            this.lblsecretquestion.TabIndex = 50;
            this.lblsecretquestion.Text = "Secret_Question";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 3);
            this.panel1.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(477, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 424);
            this.panel2.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 3);
            this.panel3.TabIndex = 53;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 421);
            this.panel4.TabIndex = 54;
            // 
            // frm_Update_AdminInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(480, 427);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblsecretquestion);
            this.Controls.Add(this.lblconfirmpassword);
            this.Controls.Add(this.lblnewpassword);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbSecretQuestion);
            this.Controls.Add(this.txtSecretAnswer);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Update_AdminInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Update_AdminInfo";
            this.Load += new System.EventHandler(this.frm_Update_AdminInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbSecretQuestion;
        private System.Windows.Forms.TextBox txtSecretAnswer;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblnewpassword;
        private System.Windows.Forms.Label lblconfirmpassword;
        private System.Windows.Forms.Label lblsecretquestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}