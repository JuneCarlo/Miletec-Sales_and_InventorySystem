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
    public partial class frm_Customer_Details : Form
    {
        public frm_Customer_Details()
        {
            InitializeComponent();
        }
       static db_MiletecDataContext db = null;
        private void btnsave_Click(object sender, EventArgs e)
        {
            string user;
            //if all fields are filled
            if (txtcustomername.Text != "Customer Name" && txtaddress.Text != "Address" && txtcontactno1.Text != "Contactno.1" && txtcontactno2.Text != "Contactno.1")
            {
                db = new db_MiletecDataContext();
                user = Form1.UserID.ToString();
                db.sp_insert_customerdetails(user, txtcustomerid.Text, txtcustomername.Text, txtaddress.Text,
                                             txtcontactno1.Text, txtcontactno2.Text);
                db.SubmitChanges();
                MessageBox.Show("Save Successfuly!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dgvcustomerdetails.DataSource = clsrepository.customer();
                txtcustomername.Text = "Customer Name";
                txtaddress.Text = "Address";
                txtcontactno1.Text = "Contactno.1";
                txtcontactno2.Text = "Contactno.2";
                GencusID(txtcustomerid);
            }
                //if some fields are empty
            else
            {
                MessageBox.Show("Please fill up everything!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void frm_Customer_Details_Load(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            //display customer information
            dgvcustomerdetails.DataSource = clsrepository.customer();
            //auto-generate customer Id during form load
            GencusID(txtcustomerid);

        }

        

        public static string GencusID(TextBox txtcustomerid)
        {

            int iicount = 0;
            string ID = "";
            db = new db_MiletecDataContext();
            var query = db.sp_genCustomerID();

            foreach (sp_genCustomerIDResult count in query)
            {
                //count customer registered in the database
                iicount = count.count.Value;
                //increment
                iicount = iicount++;
            }

            ++iicount;
            //substring from lengths 1-2, padleft 4-2
            if (iicount.ToString().Length.Equals(1))
            {
                ID = "CustomerID-" + iicount.ToString().PadLeft(4, '0').ToString();
            }
            else if (iicount.ToString().Length.Equals(2))
            {
                ID = "CustomerID-" + iicount.ToString().PadLeft(3, '0').ToString();
            }
            else
            {
                ID = "CustomerID-" + iicount.ToString().PadLeft(2, '0').ToString();
            }

            return txtcustomerid.Text = ID;
        }

        private void dgvcustomerdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //customer details cell content click event
            btnsave.Enabled = false;
            btnedit.Enabled = true;
            btndelete.Enabled = true;
            txtcustomerid.Text = dgvcustomerdetails.CurrentRow.Cells[1].Value.ToString();
            txtcustomername.Text = dgvcustomerdetails.CurrentRow.Cells[2].Value.ToString();
            txtaddress.Text = dgvcustomerdetails.CurrentRow.Cells[3].Value.ToString();
            txtcontactno1.Text = dgvcustomerdetails.CurrentRow.Cells[4].Value.ToString();
            txtcontactno2.Text = dgvcustomerdetails.CurrentRow.Cells[5].Value.ToString();

        }

        private void dgvcustomerdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //customer details content click event
            btnsave.Enabled = false;
            btndelete.Enabled = true;
            btnedit.Enabled = true;
            txtcustomerid.Text = dgvcustomerdetails.CurrentRow.Cells[1].Value.ToString();
            txtcustomername.Text = dgvcustomerdetails.CurrentRow.Cells[2].Value.ToString();
            txtaddress.Text = dgvcustomerdetails.CurrentRow.Cells[3].Value.ToString();
            txtcontactno1.Text = dgvcustomerdetails.CurrentRow.Cells[4].Value.ToString();
            txtcontactno2.Text = dgvcustomerdetails.CurrentRow.Cells[5].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           //delete customer data
            if (txtcustomername.Text != "Customer Name" && txtaddress.Text != "Address" && txtcontactno1.Text != "Contactno.1" && txtcontactno2.Text != "Contactno.1")
            {
                tblcustomerdetail tbl = new tblcustomerdetail();
                tbl.CustomerID = dgvcustomerdetails.CurrentRow.Cells[1].Value.ToString();
                clsrepository.deletecus(tbl);
                dgvcustomerdetails.DataSource = clsrepository.customer();
                MessageBox.Show("Successfully delete!");
                btnsave.Enabled = true;
                txtcustomername.Text = "Customer Name";
                txtaddress.Text = "Address";
                txtcontactno1.Text = "Contactno.1";
                txtcontactno2.Text = "Contactno.2";
            }
            else
            {
                MessageBox.Show("Please choose a customer you want do delete!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            //edit customer details
            db = new db_MiletecDataContext();
            //checked if all fields are filled during the process
            if (txtcustomername.Text != "Customer Name" && txtaddress.Text != "Address" && txtcontactno1.Text != "Contactno.1" && txtcontactno2.Text != "Contactno.2")
            {
                db.sp_updatecustomerdetails(txtcustomerid.Text, txtcustomername.Text, txtaddress.Text, txtcontactno1.Text, txtcontactno2.Text);
                db.SubmitChanges();
                dgvcustomerdetails.DataSource = clsrepository.customer();
                MessageBox.Show("Successfuly update!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtcustomername.Text = "Customer Name";
                txtaddress.Text = "Address";
                txtcontactno1.Text = "Contactno.1";
                txtcontactno2.Text = "Contactno.2";
                btnsave.Enabled = true;
                GencusID(txtcustomerid);
            }
                //if some fields are empty, do not allow the user to update the custommer upadte
            else
            {
                MessageBox.Show("please choose what you want to update!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dgvcustomerdetails.DataSource = clsrepository.Search(txtsearch.Text);
        }

        private void txtcontactno1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Cannot input characters!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void txtcontactno2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Cannot input characters!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    
        private void btnadd_Click(object sender, EventArgs e)
        {
     
        }

        private void txtcontactno1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsample_TextChanged(object sender, EventArgs e)
        {

        }

        void autocomplete()
        { 
        
        }

        private void txtcustomername_Leave(object sender, EventArgs e)
        {
            if (txtcustomername.Text == "")
            {
                txtcustomername.Text = "Customer Name";
                txtcustomername.ForeColor = Color.Gray;
            }
        }

        private void txtcustomername_Click(object sender, EventArgs e)
        {
            if (txtcustomername.Text == "Customer Name")
            {
                txtcustomername.ForeColor = Color.Black;
                txtcustomername.Text = "";
            }
        }

        private void txtcustomername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddress_Leave(object sender, EventArgs e)
        {
            if (txtaddress.Text == "")
            {
                txtaddress.Text = "Address";
            }
        }

        private void txtaddress_Click(object sender, EventArgs e)
        {
            if (txtaddress.Text == "Address")
            {
                txtaddress.Text = "";
            }
        }

        private void txtcontactno1_Leave(object sender, EventArgs e)
        {
            if (txtcontactno1.Text == "")
            {
                txtcontactno1.Text = "Contactno.1";
            }
        }

        private void txtcontactno1_Click(object sender, EventArgs e)
        {

            if (txtcontactno1.Text == "Contactno.1")
            {
                txtcontactno1.Text = "";
            }
        }

        private void txtcontactno2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontactno2_Leave(object sender, EventArgs e)
        {
            if (txtcontactno2.Text == "")
            {
                txtcontactno2.Text = "Contactno.2";
            }
        }

        private void txtcontactno2_Click(object sender, EventArgs e)
        {
            if (txtcontactno2.Text == "Contactno.2")
            
                txtcontactno2.Text = "";
            }

        private void txtcustomerid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsearch_Leave(object sender, EventArgs e)
        {
            if (lblsearch.Text == "" && txtsearch.Text == "")
            {
                lblsearch.Text = "Search";
                txtsearch.Clear();
            }
        }

        private void txtsearch_Click(object sender, EventArgs e)
        {
            if (lblsearch.Text == "Search")
            {
                lblsearch.Text = "";
            }
        }

        private void lblsearch_Click(object sender, EventArgs e)
        {

        }
    }

 }

