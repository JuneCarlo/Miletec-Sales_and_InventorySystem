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
    public partial class frm_Add_Employee : Form
    {
        public frm_Add_Employee()
        {
            InitializeComponent();
        }

       static db_MiletecDataContext db = null;
        int count = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            //staff registration
            if (cmbUser.Text == "Staff")
            {
                if (txtLastName.Text != string.Empty && txtFirstName.Text != string.Empty && txtMiddleName.Text != string.Empty && txtUserName.Text != string.Empty && txtPassword.Text != string.Empty)
                {

                    if (count == 0)
                    {
                        if (txtFirstName.Text == "Firstname" && txtLastName.Text == "Lastname" && txtMiddleName.Text == "Middle Name")
                        {
                            MessageBox.Show("Please fill up everything!!","NOTE",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                        }
                        else if (txtUserName.Text == "Username" || txtPassword.Text == "Password")
                        {
                            MessageBox.Show("Generate Username and Password first!!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            db.sp_insert_User(txtUserStaffID.Text, txtLastName.Text, txtFirstName.Text, txtMiddleName.Text,
                                              txtUserName.Text, txtPassword.Text, "Active", null, null, cmbUser.Text);
                            db.SubmitChanges();
                            MessageBox.Show("Registered Successfully!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            txtFirstName.Text = "Firstname";
                            txtLastName.Text = "Lastname";
                            txtMiddleName.Text = "Middle Name";
                            txtUserName.Text = "Username";
                            txtPassword.Text = "Password";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please fill up everything!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (cmbUser.Text == "Administrator")
            {
                db = new db_MiletecDataContext();


                if (count == 0)
                {
                    if (txtFirstName.Text == "Firstname" && txtLastName.Text == "Lastname" && txtMiddleName.Text == "Middle Name")
                        {
                            MessageBox.Show("Please fill up everything!!","NOTE",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                        }
                    else if (txtUserName.Text == "Username" || txtPassword.Text == "Password")
                    {
                        MessageBox.Show("Generate Username and Password first!!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {

                        db.sp_insert_User(txtUserStaffID.Text, txtLastName.Text, txtFirstName.Text, txtMiddleName.Text,
                                          txtUserName.Text, txtPassword.Text, "Active", null, null, cmbUser.Text);
                        db.SubmitChanges();
                        MessageBox.Show("Registered Successfully!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtFirstName.Text = "Firstname";
                        txtLastName.Text = "Lastname";
                        txtMiddleName.Text = "Middle Name";
                        txtUserName.Text = "Username";
                        txtPassword.Text = "Password";
                    }
                }

            }
            else
            {

                MessageBox.Show("Please Fill up everything!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
            }

            
            GenerateUserID(txtUserStaffID);

        }

        public static string GenerateUserID(TextBox txtUserStaffID)
        {


            
            int iicount = 0;
            string ID = "";
            db = new db_MiletecDataContext();
            var query = db.sp_Get_User_ID();

            foreach (sp_Get_User_IDResult count in query)
            {
                iicount = count.Count.Value;
                iicount = iicount - 1;
            }
            ++iicount;
            if (iicount.ToString().Length.Equals(1))
            {
                ID = "User-" + iicount.ToString().PadLeft(4, '0').ToString();
            }
            else if (iicount.ToString().Length.Equals(2))
            {
                ID = "User-" + iicount.ToString().PadLeft(3, '0').ToString();
            }
            else
            {
                ID = "User-" + iicount.ToString().PadLeft(2, '0').ToString();
            }

            return txtUserStaffID.Text = ID;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            GenerateUserID(txtUserStaffID);
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            
            txtUserName.Text = "New User";
            txtPassword.Text = CreateRandomPassword(8);
            txtPassword.ForeColor = Color.Black;
        }

        private void txtLastName_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Lastname")
            {
                txtLastName.Text = "";
                txtLastName.ForeColor = Color.Black;
            }
        }
        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                txtLastName.Text = "Lastname";
                
            }
        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "Firstname")
            {
                txtFirstName.Text = "";
                txtFirstName.ForeColor = Color.Black;
            }
        }
        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                txtFirstName.Text = "Firstname";
                
            }
        }


        private void txtMiddleName_Click(object sender, EventArgs e)
        {

            if (txtMiddleName.Text == "Middle Name")
            {
                txtMiddleName.Text = "";
                txtMiddleName.ForeColor = Color.Black;
            }
        }

        private void txtMiddleName_Leave(object sender, EventArgs e)
        {
            if (txtMiddleName.Text == "")
            {
                txtMiddleName.Text = "Middle Name";
 
            }
        }
        public static string CreateRandomPassword(int PasswordLength)
        { 
        string _allowedChars = "0123456789abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ";
        Random randNum = new Random();
        char[] chars = new char[PasswordLength];
        int allowedCharCount = _allowedChars.Length;
        for (int i = 0; i < PasswordLength; i++)
        {
            chars[i] = _allowedChars[(int)((_allowedChars.Length) * randNum.NextDouble())];
        }
         return new string(chars);
        }

        private void frm_Add_Employee_Load(object sender, EventArgs e)
        {
            GenerateUserID(txtUserStaffID);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbUser_Click(object sender, EventArgs e)
        {
            if (lbltype.Text == "User Type")
            {
                lbltype.Text = "";
            }
        }

        private void cmbUser_Leave(object sender, EventArgs e)
        {
            if (lbltype.Text == "" && cmbUser.Text == "")
            {
                lbltype.Text = "User Type";
                cmbUser.SelectedItem = null;
            }
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUser.TabIndex == 4 && cmbUser.Text != "")
            {
                lbltype.Visible = false;
            }

            if (cmbUser.Text == "")
            {
                lbltype.Visible = true;
            }
        }
        
    }
}
