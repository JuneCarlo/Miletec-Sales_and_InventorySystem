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
    public partial class frm_Forgot_Password : Form
    {
        public frm_Forgot_Password()
        {
            InitializeComponent();
        }

        db_MiletecDataContext db = null;

        private void btnsave_Click(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();

            if (txtUsername.Text != string.Empty && cmbSecretQuestion.Text != string.Empty && txtSecretAnswer.Text != string.Empty)
            {
                int flag = 0;
                string pass;
                db = new db_MiletecDataContext();
                var query = db.sp_Retreivepass(txtUsername.Text, cmbSecretQuestion.Text, txtSecretAnswer.Text);
                foreach (sp_RetreivepassResult result in query)
                {
                    
                    pass = result.Password.ToString();
                    MessageBox.Show(pass, "your Password is", MessageBoxButtons.OK);

                    txtUsername.Text = "Username";
                    lblsecretquestion.Text = "Secret_Question";
                    cmbSecretQuestion.SelectedItem = null;
                    txtSecretAnswer.Text = "Secret_Answer";
                    
                    flag++;
                }
                if (flag == 0)
                {
                    MessageBox.Show("Invalid Account.", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "Username";
                    lblsecretquestion.Text = "Secret_Question";
                    cmbSecretQuestion.SelectedItem = null;
                    txtSecretAnswer.Text = "Secret_Answer";
        
                }
            }
            else
            {
                MessageBox.Show("Please fill up everything!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Show();
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
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
            if (lblsecretquestion.Text == "Secret_Question")
            {
                lblsecretquestion.Text = "";
            }
        }

        private void txtSecretAnswer_Leave(object sender, EventArgs e)
        {
            if (txtSecretAnswer.Text == "")
            {
                txtSecretAnswer.Text = "Secret_Answer";
                txtSecretAnswer.ForeColor = Color.Gray;
            
            }
        }

        private void txtSecretAnswer_Click(object sender, EventArgs e)
        {
            if (txtSecretAnswer.Text == "Secret_Answer")
            {
                txtSecretAnswer.Text = "";
                txtSecretAnswer.ForeColor = Color.Black;

            }
        }

        private void txtSecretAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_Forgot_Password_Load(object sender, EventArgs e)
        {

        }

        private void cmbSecretQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSecretQuestion.TabIndex == 1 && cmbSecretQuestion.Text != "")
            {
                lblsecretquestion.Visible = false;
            }
            if (cmbSecretQuestion.Text == "")
            {
                lblsecretquestion.Visible = true;
            }
        }
    }
}
