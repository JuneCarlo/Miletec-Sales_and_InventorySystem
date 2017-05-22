namespace Miletec_Sales_and_Inventory
{
    partial class frm_Forgot_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Forgot_Password));
            this.cmbSecretQuestion = new System.Windows.Forms.ComboBox();
            this.txtSecretAnswer = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsecretquestion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
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
            this.cmbSecretQuestion.Location = new System.Drawing.Point(39, 98);
            this.cmbSecretQuestion.Name = "cmbSecretQuestion";
            this.cmbSecretQuestion.Size = new System.Drawing.Size(371, 26);
            this.cmbSecretQuestion.TabIndex = 1;
            this.cmbSecretQuestion.SelectedIndexChanged += new System.EventHandler(this.cmbSecretQuestion_SelectedIndexChanged);
            this.cmbSecretQuestion.Click += new System.EventHandler(this.cmbSecretQuestion_Click);
            this.cmbSecretQuestion.Leave += new System.EventHandler(this.cmbSecretQuestion_Leave);
            // 
            // txtSecretAnswer
            // 
            this.txtSecretAnswer.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretAnswer.ForeColor = System.Drawing.Color.Black;
            this.txtSecretAnswer.Location = new System.Drawing.Point(39, 134);
            this.txtSecretAnswer.Name = "txtSecretAnswer";
            this.txtSecretAnswer.Size = new System.Drawing.Size(371, 26);
            this.txtSecretAnswer.TabIndex = 2;
            this.txtSecretAnswer.Text = "Secret_Answer";
            this.txtSecretAnswer.Click += new System.EventHandler(this.txtSecretAnswer_Click);
            this.txtSecretAnswer.TextChanged += new System.EventHandler(this.txtSecretAnswer_TextChanged);
            this.txtSecretAnswer.Leave += new System.EventHandler(this.txtSecretAnswer_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(39, 62);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(371, 26);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(156)))));
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(39, 170);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(173, 27);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "RETRIEVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(432, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblsecretquestion
            // 
            this.lblsecretquestion.AutoSize = true;
            this.lblsecretquestion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecretquestion.ForeColor = System.Drawing.Color.Black;
            this.lblsecretquestion.Location = new System.Drawing.Point(39, 102);
            this.lblsecretquestion.Name = "lblsecretquestion";
            this.lblsecretquestion.Size = new System.Drawing.Size(132, 18);
            this.lblsecretquestion.TabIndex = 56;
            this.lblsecretquestion.Text = "Secret_Question";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 3);
            this.panel1.TabIndex = 57;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(457, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 255);
            this.panel2.TabIndex = 58;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 3);
            this.panel3.TabIndex = 59;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 252);
            this.panel4.TabIndex = 60;
            // 
            // frm_Forgot_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(460, 258);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblsecretquestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.cmbSecretQuestion);
            this.Controls.Add(this.txtSecretAnswer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Forgot_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Forgot_Password";
            this.Load += new System.EventHandler(this.frm_Forgot_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSecretQuestion;
        private System.Windows.Forms.TextBox txtSecretAnswer;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsecretquestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}