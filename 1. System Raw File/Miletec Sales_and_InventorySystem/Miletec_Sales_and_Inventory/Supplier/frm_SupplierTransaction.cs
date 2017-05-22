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
    public partial class frm_SupplierTransaction : Form
    {
        public frm_SupplierTransaction()
        {
            InitializeComponent();
        }
        static db_MiletecDataContext db = null;
        public int sum = 0;
        private void btnremove_Click(object sender, EventArgs e)
        {
            tblOrderDetail orderdetails = new tblOrderDetail();
            orderdetails.OrderID = txtOrderID.Text;
            orderdetails.ProdID = cmbProductID.Text;
            if (cmbProductID.Text != "" && txtProductName.Text != "" && txtQuantityOrder.Text != "")
            {

                DialogResult result = MessageBox.Show
            (" Are you sure you want to remove?", " Confirmation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    if (txtOrderID.Text == orderdetails.OrderID && cmbProductID.Text == orderdetails.ProdID)
                    {
                        clsrepository.delete(orderdetails);
                    }
                    dgvOrderDetails.Rows.Remove(dgvOrderDetails.CurrentRow);
                    cmbProductID.SelectedItem = null;
                    txtProductName.Clear();
                    txtQuantityOrder.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please choose what you want to remove!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();

            if (txtQuantityOrder.Text != "Quantity Order" && txtShowSupplier.Text != "Supplier ID" && cmbProductID.Text != "" && txtProductName.Text != "Product Name")
            {
               

                if (int.Parse(txtQuantityOrder.Text) <= 0)
                {
                    MessageBox.Show("fill up quantity first!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                 {
                    MessageBox.Show("Successfully Added!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    dgvOrderDetails.Rows.Add(cmbProductID.Text, txtProductName.Text, int.Parse(txtQuantityOrder.Text));
                    db.sp_OrderDetails(txtOrderID.Text, cmbProductID.Text, txtProductName.Text, int.Parse(txtQuantityOrder.Text), "To Deliver");
                    db.sp_Products(txtSupplierID.Text, cmbProductID.Text, txtProductName.Text, int.Parse(txtQuantityOrder.Text));
                    db.SubmitChanges();
                    cmbProductID.SelectedItem = null;
                    lblproductid.Text = "Product ID";
                    txtProductName.Text = "Product Name";
                    txtQuantityOrder.Text = "Quantity Order";
                    btnPurchase.Enabled = true;
                    
                }
            }
            else
            {
                MessageBox.Show("Please fill up everything!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrderDetails.CurrentRow.Cells[0].Value.ToString() != string.Empty)
                {
                    dgvOrderDetails.Rows.Clear();
                    MessageBox.Show("Product Ordered!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    GenOrderID(txtOrderID);
                    txtShowSupplier.Text = "Supplier ID";
                    txtOrderID.Text = "Order ID";
                }
            }
            catch(Exception)
            {
                    MessageBox.Show("plese make an order first!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        public static string GenOrderID(TextBox txtOrderID)
        {

            int iicount = 0;
            string ID = "";
            db = new db_MiletecDataContext();
            var query = db.sp_GetOrderID();

            foreach (sp_GetOrderIDResult count in query)
            {
                iicount = count.Count.Value;
                iicount = iicount++;
            }
            ++iicount;
            if (iicount.ToString().Length.Equals(1))
            {
                ID = "OrderID-" + iicount.ToString().PadLeft(4, '0').ToString();
            }
            else if (iicount.ToString().Length.Equals(2))
            {
                ID = "OrderID-" + iicount.ToString().PadLeft(3, '0').ToString();
            }
            else
            {
                ID = "OrderID-" + iicount.ToString().PadLeft(2, '0').ToString();
            }

            return txtOrderID.Text = ID;
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

        private void frm_SupplierTransaction_Load(object sender, EventArgs e)
        {
            GenID(txtSupplierID);
            GenOrderID(txtOrderID);
            txtOrderBy.Text = Form1.UserID.ToString();
            dgvsupplierdetails.DataSource = clsrepository.displaysupdetails();
            btnPurchase.Enabled = false;
        }

        private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbProductID.Text = dgvOrderDetails.CurrentRow.Cells[0].Value.ToString();
            txtProductName.Text = dgvOrderDetails.CurrentRow.Cells[1].Value.ToString();
            txtQuantityOrder.Text = dgvOrderDetails.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbProductID.Text = dgvOrderDetails.CurrentRow.Cells[0].Value.ToString();
            txtProductName.Text = dgvOrderDetails.CurrentRow.Cells[1].Value.ToString();
            txtQuantityOrder.Text = dgvOrderDetails.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvsupplierdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = false;
            txtShowSupplier.Text = dgvsupplierdetails.CurrentRow.Cells[1].Value.ToString();
            txtSupplierID.Text = dgvsupplierdetails.CurrentRow.Cells[1].Value.ToString();
            txtSupplierName.Text = dgvsupplierdetails.CurrentRow.Cells[2].Value.ToString();
            txtAddress.Text = dgvsupplierdetails.CurrentRow.Cells[3].Value.ToString();
            txtContact1.Text = dgvsupplierdetails.CurrentRow.Cells[4].Value.ToString();
            txtContact2.Text = dgvsupplierdetails.CurrentRow.Cells[5].Value.ToString();
            txtContactPerson.Text = dgvsupplierdetails.CurrentRow.Cells[6].Value.ToString();
            if (dgvsupplierdetails.SelectedRows.Count == 0)
            {
                btnProceed.Enabled = false;
            }
            else
            {
                btnProceed.Enabled = true;
            }
        }

        private void dgvsupplierdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = false;
            txtShowSupplier.Text = dgvsupplierdetails.CurrentRow.Cells[1].Value.ToString();
            txtSupplierID.Text = dgvsupplierdetails.CurrentRow.Cells[1].Value.ToString();
            txtSupplierName.Text = dgvsupplierdetails.CurrentRow.Cells[2].Value.ToString();
            txtAddress.Text = dgvsupplierdetails.CurrentRow.Cells[3].Value.ToString();
            txtContact1.Text = dgvsupplierdetails.CurrentRow.Cells[4].Value.ToString();
            txtContact2.Text = dgvsupplierdetails.CurrentRow.Cells[5].Value.ToString();
            txtContactPerson.Text = dgvsupplierdetails.CurrentRow.Cells[6].Value.ToString();
            if (dgvsupplierdetails.SelectedRows.Count == 0)
            {
                btnProceed.Enabled = false;
            }
            else
            {
                btnProceed.Enabled = true;
            }
        }

        private void btnsupcancel_Click(object sender, EventArgs e)
        {
            gbSupplierDetails.Hide();
            gbProduct_Details.Show();
            txtShowSupplier.Clear();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext(); 
            db.sp_Order(txtOrderID.Text, txtSupplierID.Text, DateTime.Parse(dtpProductDetails.Text), txtOrderBy.Text, "To Deliver");
            gbSupplierDetails.Hide();
            gbProduct_Details.Show();
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string user;
            if (txtSupplierName.Text != "" && txtAddress.Text != "" && txtContact1.Text != "" && txtContact2.Text != ""
                && txtContactPerson.Text != "")
            {
                db = new db_MiletecDataContext();
                user = Form1.UserID.ToString();
                db.sp_SupplierDetails(user, txtSupplierID.Text, txtSupplierName.Text, txtAddress.Text,
                                      int.Parse(txtContact1.Text), int.Parse(txtContact2.Text), txtContactPerson.Text);
                db.SubmitChanges();
                MessageBox.Show("Successfully Save!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                dgvsupplierdetails.DataSource = clsrepository.displaysupdetails();
                if (dgvsupplierdetails.Rows.Count == 0)
                {
                    btnProceed.Enabled = false;
                }
                else
                {
                    btnProceed.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Please fill up everything first!!");
            }
        }

        private void cmbProductID_TextChanged(object sender, EventArgs e)
        {
            if (cmbProductID.Text == "ProductID-0001")
            {
                txtProductName.Text = "Glass";
            }
            else if (cmbProductID.Text == "ProductID-0002")
            {
                txtProductName.Text = "Around Tube Aluminum";
            }
            else
            {
                txtProductName.Text = "Stainless Tube Aluminum";
            }
        }

        private void btncancelprod_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnaddsup_Click(object sender, EventArgs e)
        {
            if (txtShowSupplier.Text != "Supplier ID")
            {
                DialogResult result = MessageBox.Show("Are you sure you want cancel the transaction?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    db.sp_delete_Order(txtOrderID.Text);
                    GenID(txtSupplierID);
                    gbProduct_Details.Hide();
                    gbSupplierDetails.Show();
                    txtSupplierName.Clear();
                    txtAddress.Clear();
                    txtContact1.Clear();
                    txtContact2.Clear();
                    txtContactPerson.Clear();
                    btnSave.Enabled = true;
                    txtOrderBy.Text = Form1.UserID.ToString();
                }
            }
            else
            {
                gbProduct_Details.Hide();
                gbSupplierDetails.Show();
            }
        }

        private void cmbProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPurchase.Enabled = false;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void gbProduct_Details_Enter(object sender, EventArgs e)
        {

        }

        private void txtOrderID_Leave(object sender, EventArgs e)
        {
            if (txtOrderID.Text == "")
            {
                txtOrderID.Text = "Order ID";
            }
        }

        private void txtOrderID_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text == "Order ID")
            {
                txtOrderID.Text = "";
            }
        }

        private void cmbProductID_Leave(object sender, EventArgs e)
        {
            if (cmbProductID.Text == "" && cmbProductID.Text == "")
            {
                lblproductid.Text = "Product ID"; 
            }
        }

        private void cmbProductID_Click(object sender, EventArgs e)
        {
            if ( lblproductid.Text == "Product ID")
            {
                lblproductid.Text = "";
            }
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                txtProductName.Text = "Product Name";
            }
        }

        private void txtProductName_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "Product Name")
            {
                txtProductName.Text = "";
            }
        }

        private void txtQuantityOrder_Leave(object sender, EventArgs e)
        {
            if (txtQuantityOrder.Text == "")
            {
                txtQuantityOrder.Text = "Quantity Order";
            }
        }

        private void txtQuantityOrder_Click(object sender, EventArgs e)
        {
            if (txtQuantityOrder.Text == "Quantity Order")
            {
                txtQuantityOrder.Text = "";
            }
        }

        private void txtQuantityOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Cannot input characters!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

     

        private void txtsearchj_Leave(object sender, EventArgs e)
        {
            if(lblsearch.Text == "" && txtsearchj.Text == "")
            {
                lblsearch.Text = "Search";
            }
        }

        private void txtsearchj_Click(object sender, EventArgs e)
        {
            if (lblsearch.Text == "Search")
            {
                lblsearch.Text = "";
            }
        }

        private void txtsearchj_TextChanged(object sender, EventArgs e)
        {

            db = new db_MiletecDataContext();
            dgvsupplierdetails.DataSource = db.sp_Search_SupplierDetails(txtsearchj.Text);
        }
       
    }
}
