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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string UserID,Isactive,Status,name,Username,Password;
        db_MiletecDataContext db = new db_MiletecDataContext();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int Counter2 = 0;
            db = new db_MiletecDataContext();
            if(txtUsername.Text != "Username" && txtPassword.Text != "Password")
            {
                var query_Login = db.sp_verify_usernamepass(txtUsername.Text,txtPassword.Text);
                foreach(sp_verify_usernamepassResult entry in query_Login.ToList())
                {
                    UserID = entry.UserID.ToString();
                    Isactive = entry.isactive.ToString();
                    Status = entry.Status.ToString();
                    Username = entry.Username.ToString();
                    Password = entry.Password.ToString();

                    name = entry.LastName.ToString() + "," +" "+ entry.FirstName.ToString() + " " + entry.MiddleName.ToString();
                    if (Status == "Administrator")
                    {
                        if (txtUsername.Text == "New User")
                        {
                            this.Hide();
                            MessageBox.Show("You must update your account first!!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            frm_Update_AdminInfo updateUser = new frm_Update_AdminInfo();
                            updateUser.Show();
                        }
                        else
                        {
                            this.Hide();
                            MessageBox.Show("Succesfully Log-in!!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            wndw_Main_Admin maid = new wndw_Main_Admin();
                            maid.Show();
                        }
                    }
                    else if (txtUsername.Text == "New User")
                    {
                        this.Hide();
                        MessageBox.Show("You must update your account first!!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        frm_Update_AdminInfo updateUser = new frm_Update_AdminInfo();
                        updateUser.Show();
                    }
                    else if (Isactive != "Active")
                    {
                        MessageBox.Show("Contact Administrator to activate account", "Account Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        this.Hide();
                        MessageBox.Show("Succesfully Log-in!!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        wndw_Main_Staff staff = new wndw_Main_Staff();
                        staff.Show();

                    }
                    Counter2++;
                }
                string pass;
                if (Counter2 == 0)
                {
                    
                    int Counter1 = 0;
                    var queryusername = db.sp_verify_Username(txtUsername.Text);
                    foreach (sp_verify_UsernameResult entry in queryusername)
                    {
                        pass = entry.Password.ToString();
                        if (txtPassword.Text != pass && txtPassword.Text != string.Empty)
                        {
                            MessageBox.Show("Incorrect Password!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Clear();
                            txtPassword.Focus();
                            lblpassword.Text = "";
                        }
                        else if (txtPassword.Text == string.Empty && txtUsername.Text != "Username")
                        {
                            MessageBox.Show("Password should be fill up!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            txtPassword.Focus();

                        }
                        Counter1++;
                    }
                    
                    if (Counter1 == 0)
                    {
                        MessageBox.Show("Invalid Account", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();
                    }

                }
             
            }
            else
            {
                MessageBox.Show("Fill up Everything ", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Focus();
            }

            }

        private void lblforgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_Forgot_Password forgot = new frm_Forgot_Password();
            forgot.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.TabIndex == 0)
            {
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnLogin.PerformClick();
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Exit?", "NOTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.TabIndex == 1 && txtPassword.Text != "")
            {
              
                lblpassword.Visible = false;
            }

            if(txtPassword.Text == "")
            {
                lblpassword.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Forgot_Password forgot = new frm_Forgot_Password();
            forgot.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (lblpassword.Text == "Password")
            {
                lblpassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (lblpassword.Text == "" && txtPassword.Text == "")
            {
                lblpassword.Text = "Password";
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TabIndexChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtPassword_TabIndexChanged(object sender, EventArgs e)
        {
            if (lblpassword.Text == "Password")
            {
                lblpassword.Text = "";
                lblpassword.Visible = false;
            }
        }

        private void txtPassword_TabStopChanged(object sender, EventArgs e)
        {
            if (lblpassword.Text == "Password")
            {
                lblpassword.Text = "";
            }
        }
     
    }

}
    

