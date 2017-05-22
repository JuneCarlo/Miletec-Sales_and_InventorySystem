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
    public partial class frm_Delivery_Supplier : Form
    {
        public frm_Delivery_Supplier()
        {
            InitializeComponent();
        }

        static db_MiletecDataContext db = null;

        public string ProductID, ProductName,Qty;
        public int oldQty = 0, newQty = 0;

        private void frm_Delivery_Supplier_Load(object sender, EventArgs e)
        {
            GenDelID(txtDeliveryNo);
            txtPreparedBy.Text = Form1.UserID.ToString();      
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtOrderID.Text != "Order No.")
            {
                DialogResult result = MessageBox.Show("Are you sure you want cancel the delivery?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    db.sp_delete_DeliverySupplier(txtOrderID.Text);
                    GenDelID(txtDeliveryNo);
                    gbDelivery.Hide();
                    gbOrderDetails.Show();
                    
                }
            }
            else
            {
                gbDelivery.Hide();
                gbOrderDetails.Show();
            }
            btnProceed.Hide();
        }

        private void gbOrderDetails_Enter(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();

            dgvViewOrderDetails.DataSource = clsrepository.displayprod();
           
        }

        private void btnProceedOrderDet_Click(object sender, EventArgs e)
        {
            if (dgvViewOrderDetails.CurrentRow.Cells[4].Value.ToString() == "Delivered")
            {
                MessageBox.Show("Already Delivered!!");
                txtOrderID.Clear();
                txtDateOrdered.Clear();
            }
            else
            {
                 DialogResult result = MessageBox.Show("Continue Delivery?", "NOTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (result == DialogResult.Yes)
                 {
                     db.sp_DeliverySupplier(txtDeliveryNo.Text, txtOrderID.Text, DateTime.Now, txtPreparedBy.Text, null);
                     gbOrderDetails.Hide();
                     gbDelivery.Show();
                     btnProceed.Show();
                   
                 }
            }
           
        }

        private void dgvViewOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderID.Text = dgvViewOrderDetails.CurrentRow.Cells[0].Value.ToString();
            txtDateOrdered.Text = dgvViewOrderDetails.CurrentRow.Cells[2].Value.ToString();
            //txtAddress.Text = dgvViewOrderDetails.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvViewOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderID.Text = dgvViewOrderDetails.CurrentRow.Cells[0].Value.ToString();
            txtDateOrdered.Text = dgvViewOrderDetails.CurrentRow.Cells[2].Value.ToString();
        }

    

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
            tblOrderDetail order = new tblOrderDetail();
            
            order.OrderID = txtOrderID.Text;
            if (txtOrderID.Text == order.OrderID)
            {
                dgvProductDetails.DataSource = db.sp_view_OrderDetails(txtOrderID.Text);
            }
            
        }

        private void dgvDeliverditems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static string GenDelID(TextBox txtDeliveryNo)
        {

            int iicount = 0;
            string ID = "";
            db = new db_MiletecDataContext();
            var query = db.sp_GetDeliveryID();

            foreach (sp_GetDeliveryIDResult count in query)
            {
                iicount = count.Count.Value;
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

        private void btnProceed_Click(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            if (txtOrderID.Text != "Order No.")
            {
              
            
                    if (dgvProductDetails.CurrentRow.Cells[3].Value.ToString() == "Delivered")
                    {
                        MessageBox.Show("Product was already delivered!!");
                        dgvProductDetails.Rows.Remove(dgvProductDetails.CurrentRow);
                    }

                    else if (txtOrderID.Text != "Order No." && txtDeliveryNo.Text != "Delivery No.")
                    {
                        db.sp_DeliveryDetails(txtDeliveryNo.Text, txtOrderID.Text, txtProdID.Text,DateTime.Parse(dtpDate.Text), ProductName, int.Parse(Qty));
                        dgvDeliverditems.Rows.Add(txtProdID.Text, ProductName, DateTime.Now);
                        lblreceivedby.Text = Form1.name.ToString();                     
                        MessageBox.Show("Successfully delivered!!");
                        db.sp_update_tblOrderDetails(txtOrderID.Text, txtProdID.Text, "Delivered");
                        var query_Price = db.sp_RetrieveStocksQuantity(txtProdID.Text, ProductName);
                        foreach (sp_RetrieveStocksQuantityResult entry in query_Price.ToList())
                        {
                            oldQty = int.Parse(entry.availqty.ToString());
                            newQty = int.Parse(Qty) + oldQty;
                            if (txtProdID.Text == "ProductID-0001")
                            {
                                db.sp_Update_StocksQty(txtProdID.Text, newQty);
                            }
                            else if (txtProdID.Text == "Product-0002")
                            {
                                db.sp_Update_StocksQty(txtProdID.Text, newQty);
                            }
                            else
                            {
                                db.sp_Update_StocksQty(txtProdID.Text, newQty);
                            }



                        }
                        dgvProductDetails.Rows.Remove(dgvProductDetails.CurrentRow);
                    }

                    else
                    {
                        MessageBox.Show("Please Add first the OrderID that you want to be delivered!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                
            }

            //GenDelID(txtDeliveryNo);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            if (lblreceivedby.Text != "." && txtDeliveredBy.Text != "Delivered By")
            {
                
                db.sp_update_tblDeliverySupplier(txtDeliveryNo.Text,txtDeliveredBy.Text); //db.sp_DeliverySupplier(txtDeliveryNo.Text, txtOrderID.Text, DateTime.Now, txtPreparedBy.Text, txtDeliveredBy.Text);
                db.SubmitChanges();
                dgvDeliverditems.Rows.Clear();
                txtDeliveredBy.Clear();
                MessageBox.Show("Successfully Save!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtOrderID.Text = "Order No.";
                txtDateOrdered.Text = "Date Ordered";
                txtPreparedBy.Text = "Prepared By";
                GenDelID(txtDeliveryNo);
                if (dgvProductDetails.Rows.Count == 0)
                {
                    db.sp_update_tblOrders(txtOrderID.Text, "Delivered");
                }
            }
            else
            {
                MessageBox.Show("Please choose you want to deliver!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPreparedBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvProductDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProdID.Text = dgvProductDetails.CurrentRow.Cells[0].Value.ToString();
            ProductName = dgvProductDetails.CurrentRow.Cells[1].Value.ToString();
            Qty = dgvProductDetails.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void btnCancelOrderDetails_Click(object sender, EventArgs e)
        {
            gbOrderDetails.Hide();
            gbDelivery.Show();
            btnProceed.Show();
        }

        private void dgvProductDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProdID.Text = dgvProductDetails.CurrentRow.Cells[0].Value.ToString();
            ProductName = dgvProductDetails.CurrentRow.Cells[1].Value.ToString();
            Qty = dgvProductDetails.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvProductDetails_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtProdID.Text = dgvProductDetails.CurrentRow.Cells[0].Value.ToString();
                ProductName = dgvProductDetails.CurrentRow.Cells[1].Value.ToString();
                Qty = dgvProductDetails.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            { }
        }

        private void txtDateOrdered_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDeliveredBy_Leave(object sender, EventArgs e)
        {
            if (txtDeliveredBy.Text == "")
            {
                txtDeliveredBy.Text = "Delivered By";
            }
        }

        private void txtDeliveredBy_Click(object sender, EventArgs e)
        {
            if (txtDeliveredBy.Text == "Delivered By")
            {
                txtDeliveredBy.Text = "";
            }

        }


      
    }
}
