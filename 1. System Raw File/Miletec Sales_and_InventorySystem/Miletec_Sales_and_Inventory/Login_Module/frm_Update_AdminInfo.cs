using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miletec_Sales_and_Inventory
{
    public partial class frm_Update_AdminInfo : Form
    {
        public frm_Update_AdminInfo()
        {
            InitializeComponent();
        }
        db_MiletecDataContext db = null;
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int counter = 0;
            db = new db_MiletecDataContext();
            if (txtUsername.Text != "Username" && txtNewPassword.Text != "" && txtConfirm.Text != ""
                && cmbSecretQuestion.Text != null && txtSecretAnswer.Text != "Secret_Answer")
            {
                if (counter == 0)
                {
                    var result = (from row in db.tblUsers where row.Username == txtUsername.Text.ToString() select row).ToList();
                    if (result.Count() != 0)
                    {
                        MessageBox.Show("Username already existed!!","NOTE",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    }
                    else if(txtConfirm.Text != txtNewPassword.Text)
                    {
                        MessageBox.Show("Password do not match!!","NOTE",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        db.sp_Update_User(Form1.UserID.ToString(), txtUsername.Text, txtNewPassword.Text, cmbSecretQuestion.Text,
                                           txtSecretAnswer.Text);
                        db.SubmitChanges();
                        MessageBox.Show("Succesfuly Updated!");
                        this.Close();
                        if (Form1.Status.ToString() == "Administrator")
                        {
                            wndw_Main_Admin admin = new wndw_Main_Admin();
                            admin.Show();
                        }
                        else
                        {
                            wndw_Main_Staff staff = new wndw_Main_Staff();
                            staff.Show();
                        }
                    }
                }
            }
            else 
            {
                MessageBox.Show("Please fill up everything!!","NOTE",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            
        }

        private void frm_Update_AdminInfo_Load(object sender, EventArgs e)
        {

        }

        private void txtSecretAnswer_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                
            }
        }

        private void txtNewPassword_Leave(object sender, EventArgs e)
        {
            if(lblnewpassword.Text== "" && txtNewPassword.Text == "")
            {
                lblnewpassword.Text = "New Password";
                txtUsername.Clear();
            }
        }

        private void txtNewPassword_Click(object sender, EventArgs e)
        {
            if (lblnewpassword.Text == "New Password")
            {
                lblnewpassword.Text = "";
            }
        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            if (lblconfirmpassword.Text == "" && txtConfirm.Text == "")
            {
                lblconfirmpassword.Text = "Confirm Password";
                txtConfirm.Clear();
            }
        }

        private void txtConfirm_Click(object sender, EventArgs e)
        {
            if (lblconfirmpassword.Text == "Confirm Password")
            {
               lblconfirmpassword.Text = "";
            }
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirm.TabIndex == 2 && txtConfirm.Text != "")
            {
                lblconfirmpassword.Visible = false;
            }
            if (txtConfirm.Text == "")
            {
                lblconfirmpassword.Visible = true;
            }
        }

        private void cmbSecretQuestion_Leave(object sender, EventArgs e)
        {
            if (lblsecretquestion.Text == "" && cmbSecretQuestion.Text == "")
            {
                lblsecretquestion.Text = "Secret_Question";
                cmbSecretQuestion.SelectedItem = null;
            }
        }

        private void cmbSecretQuestion_Click(object sender, EventArgs e)
        {
            if (cmbSecretQuestion.Text == "Secret_Question")
            {
                lblsecretquestion.Text = "";
            }
        }

        private void txtSecretAnswer_Leave(object sender, EventArgs e)
        {
            if (txtSecretAnswer.Text == "Secret_Answer")
            {
                txtSecretAnswer.Text = "";
                
            }
        }

        private void txtSecretAnswer_Click(object sender, EventArgs e)
        {

            if (txtSecretAnswer.Text == "")
            {
                txtSecretAnswer.Text = "Secret_Answer";
                
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPassword.TabIndex == 1 && txtNewPassword.Text != "")
            {
                lblnewpassword.Visible = false;
            }
            if (txtNewPassword.Text == "")
            {
                lblnewpassword.Visible = true;
            }
        }

        private void lblconfirmpassword_Click(object sender, EventArgs e)
        {

        }

        private void cmbSecretQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSecretQuestion.TabIndex == 3 && cmbSecretQuestion.Text != "")
            {
                lblsecretquestion.Visible = false;
            }

            if (cmbSecretQuestion.Text == "")
            {
                lblsecretquestion.Visible = true;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
