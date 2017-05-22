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
    public partial class Supplier_Details : Form
    {
        public Supplier_Details()
        {
            InitializeComponent();
            Display();
        }


        static db_MiletecDataContext db = null;

        public void Display()
        {
            db = new db_MiletecDataContext();
            var display = db.sp_ViewSupplierDetails();
            foreach(sp_ViewSupplierDetailsResult list in display)
            {
                dgvsupplierdetails.DataSource = db.sp_ViewSupplierDetails().ToList<sp_ViewSupplierDetailsResult>();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string user;
            if (txtSupplierName.Text != "Supplier Name" && txtAddress.Text != "Address" && txtContact1.Text != "Contact No.1" && txtContact2.Text != "Contact No.2"
                && txtContactPerson.Text != "Contact Person")
            {
                db = new db_MiletecDataContext();
                user = Form1.UserID.ToString();
                db.sp_SupplierDetails(user, txtSupplierID.Text, txtSupplierName.Text, txtAddress.Text,
                                      int.Parse(txtContact1.Text), int.Parse(txtContact2.Text), txtContactPerson.Text);
                db.SubmitChanges();
                MessageBox.Show("Successfully Save!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                GenID(txtSupplierID);
                Display();
                  txtSupplierName.Text = "Supplier Name";
                txtAddress.Text = "Address";
                txtContact1.Text = "Contact No.1";
                txtContact2.Text = "Contact No.2";
                txtContactPerson.Text = "Contact Person";
            }
            else
            {
                MessageBox.Show("Please fill up everything first.", "NOTE",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnsupcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string GenID(TextBox txtSupplierID)
        {

            int iicount = 0;
            string ID = "";
            db = new db_MiletecDataContext();
            var query = db.sp_GetSupplierDetails();

            foreach (sp_GetSupplierDetailsResult count in query)
            {
                iicount = count.Count.Value;
                iicount = iicount++;
            }
            ++iicount;
            if (iicount.ToString().Length.Equals(1))
            {
                ID = "SupplierID-" + iicount.ToString().PadLeft(4, '0').ToString();
            }
            else if (iicount.ToString().Length.Equals(2))
            {
                ID = "SupplierID-" + iicount.ToString().PadLeft(3, '0').ToString();
            }
            else
            {
                ID = "SupplierID-" + iicount.ToString().PadLeft(2, '0').ToString();
            }

            return txtSupplierID.Text = ID;
        }

        private void Supplier_Details_Load(object sender, EventArgs e)
        {
            GenID(txtSupplierID);

            Display();

            btnedit.Enabled = false;
           
        }



        private void dgvsupplierdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = false;
            txtSupplierID.Text = dgvsupplierdetails.CurrentRow.Cells[1].Value.ToString();
            txtSupplierName.Text = dgvsupplierdetails.CurrentRow.Cells[2].Value.ToString();
            txtAddress.Text = dgvsupplierdetails.CurrentRow.Cells[3].Value.ToString();
            txtContact1.Text = dgvsupplierdetails.CurrentRow.Cells[4].Value.ToString();
            txtContact2.Text = dgvsupplierdetails.CurrentRow.Cells[5].Value.ToString();
            txtContactPerson.Text = dgvsupplierdetails.CurrentRow.Cells[6].Value.ToString();
            btnedit.Enabled = true;
           
       
        }

        private void dgvsupplierdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = false;          
            txtSupplierID.Text = dgvsupplierdetails.CurrentRow.Cells[1].Value.ToString();
            txtSupplierName.Text = dgvsupplierdetails.CurrentRow.Cells[2].Value.ToString();
            txtAddress.Text = dgvsupplierdetails.CurrentRow.Cells[3].Value.ToString();
            txtContact1.Text = dgvsupplierdetails.CurrentRow.Cells[4].Value.ToString();
            txtContact2.Text = dgvsupplierdetails.CurrentRow.Cells[5].Value.ToString();
            txtContactPerson.Text = dgvsupplierdetails.CurrentRow.Cells[6].Value.ToString();
            btnedit.Enabled = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContact2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactPerson_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupplierName_Leave(object sender, EventArgs e)
        {
            if (txtSupplierName.Text == "")
            {
                txtSupplierName.Text = "Supplier Name";
            }
        }

        private void txtSupplierName_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text == "Supplier Name")
            {
                txtSupplierName.Text = "";
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.Text = "Address";
            }
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Address")
            {
                txtAddress.Text = "";
            }
        }

        private void txtContact1_Leave(object sender, EventArgs e)
        {
            if (txtContact1.Text == "")
            {
                txtContact1.Text = "Contact No.1";
            }
        }

        private void txtContact1_Click(object sender, EventArgs e)
        {
            if (txtContact1.Text == "Contact No.1")
            {
                txtContact1.Text = "";
            }
        }

        private void txtContact2_Leave(object sender, EventArgs e)
        {
            if (txtContact2.Text == "")
            {
                txtContact2.Text = "Contact No.2";
            }
        }

        private void txtContact2_Click(object sender, EventArgs e)
        {
            if (txtContact2.Text == "Contact No.2")
            {
                txtContact2.Text = "";
            }
        }

        private void txtContactPerson_Leave(object sender, EventArgs e)
        {
            if (txtContactPerson.Text == "")
            {
                txtContactPerson.Text = "Contact Person";
            }
        }

        private void txtContactPerson_Click(object sender, EventArgs e)
        {
            if (txtContactPerson.Text == "Contact Person")
            {
                txtContactPerson.Text = "";
            }
        }

        private void txtContact1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Cannot input characters!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void txtContact2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Cannot input characters!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            if (txtSupplierName.Text != "Supplier Name" && txtAddress.Text != "Address" && txtContact1.Text != "Contact No.1" && txtContact2.Text != "Contact No.2"
              && txtContactPerson.Text != "Contact Person")
            {
                db.sp_Update_SupplierDetails(txtSupplierID.Text, txtSupplierName.Text, txtAddress.Text,
                                          int.Parse(txtContact1.Text), int.Parse(txtContact2.Text), txtContactPerson.Text);
                db.SubmitChanges();
                MessageBox.Show("Successfuly Updated.", "NOTE",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Display();
                txtSupplierName.Text = "Supplier Name";
                txtAddress.Text = "Address";
                txtContact1.Text = "Contact No.1";
                txtContact2.Text = "Contact No.2";
                txtContactPerson.Text = "Contact Person";
            }
            else
            {
                       MessageBox.Show("Please fill up everything first.", "NOTE",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            btnedit.Enabled = false;
            btnSave.Enabled = true;
        }
     }
     
 }
