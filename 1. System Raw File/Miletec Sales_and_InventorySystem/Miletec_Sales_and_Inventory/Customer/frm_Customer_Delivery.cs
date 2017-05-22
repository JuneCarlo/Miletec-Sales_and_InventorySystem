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
    public partial class frm_Customer_Delivery : Form
    {
        public frm_Customer_Delivery()
        {
            InitializeComponent();
        }

        static db_MiletecDataContext db = null;
        string ProductID, ProdName,Size,Qty,TimeToDeliver;
        



        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Confirm if the user wants to cancel the delivery || change the transaction to deliver
            if (txttransactionid.Text != "Transaction ID")
            {
                DialogResult result = MessageBox.Show("Are you sure you want cancel the delivery?", 
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    
                    db.sp_delete_CustomerDelivery(txtDeliveryNo.Text);
                    GendelID(txtDeliveryNo);
                    gbDelivery.Hide();
                    gbOrderDetails.Show();
                    
                }
            }
            //Select a customer
            else
            {
                gbDelivery.Hide();
                gbOrderDetails.Show();
            }

        }

        private void frm_Customer_Delivery_Load(object sender, EventArgs e)
        {
            GendelID(txtDeliveryNo);
        }

        private void btnProceedOrderDet_Click(object sender, EventArgs e)
        {
            if (dgvviewtransactiondetails.CurrentRow.Cells[6].Value.ToString() == "Delivered")
            {
                MessageBox.Show("Already Delivered!!");
            }
            else if (dgvviewtransactiondetails.CurrentRow.Cells[6].Value.ToString() == "Walk-in Customer")
            {
                MessageBox.Show("Not Applicable for delivery!!");
            }
            else
            {
                //confirmation to delivery
                DialogResult result = MessageBox.Show("Continue Delivery?", "NOTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    gbOrderDetails.Hide();
                    gbDelivery.Show();
                    txtPreparedBy.Text = Form1.UserID.ToString();
                    db.sp_customerDelivery(txtDeliveryNo.Text, txttransactionid.Text, null, txtPreparedBy.Text, null);

                }
                else
                {
                    gbOrderDetails.Hide();
                    gbDelivery.Show();
                    txttransactionid.Text = "Transaction ID";
                    txtDateOrdered.Text = "Date Ordered";
                    txtcusID.Text = "Customer ID";
                }
            }
            
        }

        private void dgvviewtransactiondetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txttransactionid.Text = dgvviewtransactiondetails.CurrentRow.Cells[0].Value.ToString();
            txtdatetodeliver.Text = dgvviewtransactiondetails.CurrentRow.Cells[2].Value.ToString();
            txtcusID.Text = dgvviewtransactiondetails.CurrentRow.Cells[4].Value.ToString();
            txttimetodeliver.Text = dgvviewtransactiondetails.CurrentRow.Cells[3].Value.ToString();
            txtDateOrdered.Text = dgvviewtransactiondetails.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvviewtransactiondetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txttransactionid.Text = dgvviewtransactiondetails.CurrentRow.Cells[0].Value.ToString();
            txtdatetodeliver.Text = dgvviewtransactiondetails.CurrentRow.Cells[2].Value.ToString();
            txtcusID.Text = dgvviewtransactiondetails.CurrentRow.Cells[4].Value.ToString();
            txttimetodeliver.Text = dgvviewtransactiondetails.CurrentRow.Cells[3].Value.ToString();
            txtDateOrdered.Text = dgvviewtransactiondetails.CurrentRow.Cells[1].Value.ToString();
        }

        private void txttransactionid_TextChanged(object sender, EventArgs e)
        {
            //if the transaction was selected to be delivered, display transaction details
            db = new db_MiletecDataContext();
            tblcustomertrans_detail getId = new tblcustomertrans_detail();
            getId.transactionid = txttransactionid.Text;
            if (txttransactionid.Text == getId.transactionid)
            {
               dgvProductDetails.DataSource = db.sp_display_customerDetails(txttransactionid.Text);
            }
           
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
             //Saves into the database
                db = new db_MiletecDataContext();
                if (dgvProductDetails.SelectedColumns.ToString() != null && txtcusID.Text != "")
                {

                db.sp_update_DeliveryCustomer(txtDeliveryNo.Text, DateTime.Parse(txtdatetodeliver.Text), txttimetodeliver.Text);
                db.SubmitChanges();
                MessageBox.Show("Successfuly saved!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if(dgvProductDetails.Rows.Count == 0)
                    {
                        db.sp_update_CustomerDeilveryStatus(txttransactionid.Text,"Pending...");
                        dgvDeliverditems.Rows.Clear();
                       txttransactionid.Text = "Transaction ID";
                       txtDateOrdered.Text = "Date Ordered";
                       txtcusID.Text = "Customer ID";
                       txtPreparedBy.Text = "Prepared By";
                       txtdatetodeliver.Text = "Date to Deliver";
                       GendelID(txtDeliveryNo);
                    }
                }
                else
            { 
                MessageBox.Show("You must fill up everything!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        public static string GendelID(TextBox txtDeliveryNo)
        {

            int iicount = 0;
            string ID = "";
            db = new db_MiletecDataContext();
            var query = db.sp_getcustdeliveryID();

            foreach (sp_getcustdeliveryIDResult count in query)
            {
                iicount = count.count.Value;
                iicount = iicount++;
            }
            ++iicount;
            if (iicount.ToString().Length.Equals(1))
            {
                ID = "DeliveryID-" + iicount.ToString().PadLeft(4, '0').ToString();
            }
            else if (iicount.ToString().Length.Equals(2))
            {
                ID = "DeliveryID-" + iicount.ToString().PadLeft(3, '0').ToString();
            }
            else
            {
                ID = "DeliveryID-" + iicount.ToString().PadLeft(2, '0').ToString();
            }

            return txtDeliveryNo.Text = ID;
        }

        private void dgvProductDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductID = dgvProductDetails.CurrentRow.Cells[0].Value.ToString();
            Qty = dgvProductDetails.CurrentRow.Cells[1].Value.ToString();
            Size = dgvProductDetails.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void dgvProductDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductID = dgvProductDetails.CurrentRow.Cells[0].Value.ToString();
            Qty = dgvProductDetails.CurrentRow.Cells[1].Value.ToString();
            Size = dgvProductDetails.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnproceed_Click(object sender, EventArgs e)
        {
            if(ProductID == "ProductID-0001")
            {
                ProdName = "Glass";
            }
            else if(ProductID == "ProductID-0002")
            {
                ProdName = "Around Tube Aluminum";
            }
            else
            {
                ProdName = "Stainless Tube Aluminum";
            }

            if (txttransactionid.Text != "Transaction ID" && txtDateOrdered.Text != "Date Ordered" && txtcusID.Text != "Customer ID")
                {




                   db.sp_updateCusTransDetails(txttransactionid.Text, ProductID, "Pending");
                           dgvDeliverditems.Rows.Add(ProductID, ProdName, Qty, txtdatetodeliver.Text);
                        
                        db.sp_CustomerDeliveryDetails(txtDeliveryNo.Text, txttransactionid.Text, ProductID, ProdName, int.Parse(Qty), dtpDate.Text);
                        MessageBox.Show("Item is ready for delivery!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        dgvProductDetails.Rows.Remove(dgvProductDetails.CurrentRow);
                }
                else
                {
                    MessageBox.Show("You must fill up everything!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void txtPreparedBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelOrderDetails_Click(object sender, EventArgs e)
        {
            gbOrderDetails.Hide();
            gbDelivery.Show();
                txttransactionid.Text = "Transaction ID";
                txtDateOrdered.Text = "Date Ordered";
                txtcusID.Text = "Customer ID";
        }

      
        private void dgvProductDetails_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ProductID = dgvProductDetails.CurrentRow.Cells[0].Value.ToString();
                Qty = dgvProductDetails.CurrentRow.Cells[1].Value.ToString();
                Size = dgvProductDetails.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            { }
        }



        private void label13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (lblsearch.Text == "" && textBox1.Text == "")
            {
                lblsearch.Text = "Search";
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (lblsearch.Text == "Search")
            {
                lblsearch.Text = "";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            dgvviewtransactiondetails.DataSource = db.sp_Search_ViewCustomerTransaction(textBox1.Text);
        }

        private void btnCancelOrderDetails_Click_1(object sender, EventArgs e)
        {
            gbDelivery.Show();
            gbOrderDetails.Hide();
        }

    }

}
