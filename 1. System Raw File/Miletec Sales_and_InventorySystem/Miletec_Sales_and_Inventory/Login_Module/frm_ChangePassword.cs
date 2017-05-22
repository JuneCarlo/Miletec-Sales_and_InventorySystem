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
    public partial class frm_ChangePassword : Form
    {
        public frm_ChangePassword()
        {
            InitializeComponent();
        }
        db_MiletecDataContext db = null;
        public string password, status, username;
        private void btnsave_Click(object sender, EventArgs e)
        {
            //if all fields are filled up
            if (lbloldpassword.Visible != true && lblnewpassword.Visible != true && lblconfirmnewpassword.Visible != true)
            {
                int stoper = 0;
                db = new db_MiletecDataContext();
                var query_login = db.sp_verifyusernamepass(txtusername.Text, txtoldpass.Text);
                foreach (sp_verifyusernamepassResult entry in query_login.ToList())
                {

                    password = entry.Password.ToString();
                    username = entry.Username.ToString();
                    //if new password do not match
                    if (txtconnewpass.Text != txtnewpass.Text)
                    {
                        MessageBox.Show("New Password does not match!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtnewpass.Clear();
                        txtconnewpass.Clear();
                    }
                    //if they match..
                    else
                    {
                        //if old password is correct
                        if (txtoldpass.Text == password)
                        {
                            db.sp_changepass(txtusername.Text, txtnewpass.Text, txtoldpass.Text);
                            MessageBox.Show("Successfuly Updated!!", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtusername.Text = "Username";
                            txtoldpass.Clear();
                            txtnewpass.Clear();
                            txtconnewpass.Clear();
                            lbloldpassword.Visible = true;
                            lblnewpassword.Visible = true;
                            lblconfirmnewpassword.Visible = true;
                            this.Close();
                        }
                    }
                    stoper++;
                }
                //if old password is incorrect, prompt message...
                if (stoper == 0)
                {
                    MessageBox.Show("Incorrect old password!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
       
                //if some of the fields are empty
            else
            {
                MessageBox.Show("Please fill up everything", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frm_ChangePassword_Load(object sender, EventArgs e)
        {
            //once the forms loads
            txtusername.Focus();
            txtusername.Text = Form1.Username.ToString();
            status = Form1.Status.ToString();
            username = Form1.Username.ToString();

            if (username == txtusername.Text && status == "Staff")
            {
                btnresetform.Visible = false;
            }

           
        }

        private void btnnote_Click(object sender, EventArgs e)
        {
        }

        private void btnresetform_Click(object sender, EventArgs e)
        {
            gbchangepass.Hide();
            gbreset.Show();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();


            if (txtpasswordreset.Text != "Password")
            {
                db.sp_resetUserPass(txtusernamereset.Text);
                db.SubmitChanges();
                MessageBox.Show("Reset Succesful!","NOTE",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void btncancelreset_Click(object sender, EventArgs e)
        {
            gbreset.Hide();
            gbchangepass.Show();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            wndw_Main_Admin main = new wndw_Main_Admin();
            main.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "Username";
            }
        }

        private void txtusername_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "Username")
            {
                txtusername.Text = "";
            }
        }

        private void txtoldpass_Leave(object sender, EventArgs e)
        {
            if (lbloldpassword.Text == "" && txtoldpass.Text == "")
            {
                lbloldpassword.Text = "Old Password";
            }
        }

        private void txtoldpass_Click(object sender, EventArgs e)
        {
            if (lbloldpassword.Text == "Old Password")
            {
                lbloldpassword.Text = "";
            }
        }

        private void txtnewpass_Leave(object sender, EventArgs e)
        {
            if (lblnewpassword.Text == "" && txtnewpass.Text == "")
            {
                lblnewpassword.Text = "New Password";
            }
        }

        private void txtnewpass_Click(object sender, EventArgs e)
        {
            if (lblnewpassword.Text == "New Password")
            {
                lblnewpassword.Text = "";
            }
        }

        private void txtconnewpass_Leave(object sender, EventArgs e)
        {
            if (lblconfirmnewpassword.Text == "" && txtconnewpass.Text == "")
            {
                lblconfirmnewpassword.Text = "Confirm NewPassword";
            }
        }

        private void txtconnewpass_Click(object sender, EventArgs e)
        {
            if (lblconfirmnewpassword.Text == "Confirm NewPassword")
            {
                lblconfirmnewpassword.Text = "";
            }
        }

        private void txtoldpass_TabIndexChanged(object sender, EventArgs e)
        {
            if (lbloldpassword.Text == "Old Password")
            {
                lbloldpassword.Text = "";
                lbloldpassword.Visible = false;
            }
        }

        private void txtnewpass_TabIndexChanged(object sender, EventArgs e)
        {
            if (lblnewpassword.Text == "New Password")
            {
                lblnewpassword.Text = "";
                lblnewpassword.Visible = false;
            }
        }

        private void txtconnewpass_TabIndexChanged(object sender, EventArgs e)
        {
            if (lblconfirmnewpassword.Text == "Confirm NewPassword")
            {
                lblconfirmnewpassword.Text = "";
                lblconfirmnewpassword.Visible = false;
            }
        }

        private void txtoldpass_TextChanged(object sender, EventArgs e)
        {
            if (txtoldpass.TabIndex == 1 && txtoldpass.Text != "")
            {
                lbloldpassword.Visible = false;
            }
            if (txtoldpass.Text == "")
            {
                lbloldpassword.Visible = true;
            }
        }

        private void txtnewpass_TextChanged(object sender, EventArgs e)
        {
            if (txtnewpass.TabIndex == 2 && txtnewpass.Text != "")
            {
                lblnewpassword.Visible = false;
            }

            if (txtnewpass.Text == "")
            {
                lblnewpassword.Visible = true;
            }
        }

        private void txtconnewpass_TextChanged(object sender, EventArgs e)
        {
            if (txtconnewpass.TabIndex == 3 && txtconnewpass.Text != "")
            {
                lblconfirmnewpassword.Visible = false;
            }
            if (txtconnewpass.Text == "")
            {
                lblconfirmnewpassword.Visible = true;
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
