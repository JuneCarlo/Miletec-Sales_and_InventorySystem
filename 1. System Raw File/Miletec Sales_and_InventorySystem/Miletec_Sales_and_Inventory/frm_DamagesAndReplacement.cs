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
    public partial class frm_DamagesAndReplacement : Form
    {
        public frm_DamagesAndReplacement()
        {
            InitializeComponent();
        }
        public static db_MiletecDataContext db = null;
        public string productID, productName,Date;
        public int qtyLeft = 0, qtydamages = 0,glassQtyOrdered = 0;
        private void frm_DamagesAndReplacement_Load(object sender, EventArgs e)
        {
            GenReplacementID(txtReplacementNo);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gbTransaction.Show();
            gbDandR.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDeliveryNo_TextChanged(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            tblCustomerDeliveryDetail getId = new tblCustomerDeliveryDetail();
            getId.DeliveryNo = txtDeliveryNo.Text;
            if (txtDeliveryNo.Text == getId.DeliveryNo)
            {
                dgvTransactionDetails.DataSource = db.sp_view_CustomerDeliveryDetails(txtDeliveryNo.Text);
            }
        }

        private void dgvViewTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDeliveryNo.Text = dgvViewTransaction.CurrentRow.Cells[0].Value.ToString();
            txtTransactionID.Text = dgvViewTransaction.CurrentRow.Cells[1].Value.ToString();
            Date = dgvViewTransaction.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvViewTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDeliveryNo.Text = dgvViewTransaction.CurrentRow.Cells[0].Value.ToString();
            txtTransactionID.Text = dgvViewTransaction.CurrentRow.Cells[1].Value.ToString();
            Date = dgvViewTransaction.CurrentRow.Cells[2].Value.ToString();
           
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            if (txtNoofDamages.Text != "Damages (Quanity)" && txtDeliveryNo.Text != "Delivery No." && txtTransactionID.Text != "Transaction ID")
            {
              
                
                var query_StockQty = db.sp_RetrieveStocksQuantity(txtproductid.Text,productName);
                foreach (sp_RetrieveStocksQuantityResult entry in query_StockQty.ToList())
                {
                    productID = entry.productid.ToString();
                    qtyLeft = int.Parse(entry.availqty.ToString());
                    qtydamages = qtyLeft - int.Parse(txtNoofDamages.Text);

                    if (txtproductid.Text == productID)
                    {
                        db.sp_Update_StocksQty(txtproductid.Text, qtydamages);
                    }
          

                }

                if (qtyLeft >= int.Parse(txtNoofDamages.Text))
                {
                     if (Convert.ToInt32(txtNoofDamages.Text) > Convert.ToInt32(dgvTransactionDetails.CurrentRow.Cells[4].Value.ToString()))
                        {
                            MessageBox.Show("Quantity is larger than the ordered quantity");
                        }
                        else
                        {
                            MessageBox.Show("Damaged product replaced!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            db.sp_insert_DamagesAndReplacement(txtReplacementNo.Text, txtTransactionID.Text, txtDeliveryNo.Text, txtproductid.Text, productName, DateTime.Now, int.Parse(txtNoofDamages.Text));
                            dgvReplacements.Rows.Add(txtproductid.Text, productName, txtNoofDamages.Text);
                        }
                  
                }


                else if (qtyLeft < int.Parse(txtNoofDamages.Text))
                {

                        var query_StockQty1 = db.sp_RetrieveStocksQuantity(txtproductid.Text,productName);
                        foreach (sp_RetrieveStocksQuantityResult entry in query_StockQty1.ToList())
                        {
                            productID = entry.productid.ToString();
                            qtyLeft = int.Parse(entry.availqty.ToString());
                            qtydamages = qtyLeft + int.Parse(txtNoofDamages.Text);

                            if (txtproductid.Text == productID)
                            {
                                db.sp_Update_StocksQty(txtproductid.Text, qtydamages);
                            }

                        }
                    MessageBox.Show("Low Stocks");
                }
              

            }
            else
            {
                MessageBox.Show("Please fill up everything first!!", "NOTE",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            
            gbDandR.Show();
        }

        private void dgvTransactionDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //productID = dgvTransactionDetails.CurrentRow.Cells[2].Value.ToString();
            productName = dgvTransactionDetails.CurrentRow.Cells[3].Value.ToString();
            txtproductid.Text = dgvTransactionDetails.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvTransactionDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //productID = dgvTransactionDetails.CurrentRow.Cells[2].Value.ToString();
            productName = dgvTransactionDetails.CurrentRow.Cells[3].Value.ToString();
            txtproductid.Text = dgvTransactionDetails.CurrentRow.Cells[2].Value.ToString();
        }
        public static string GenReplacementID(TextBox txtReplacementNo)
        {

            int iicount = 0;
            string ID = "";
            db = new db_MiletecDataContext();
            var query = db.sp_generate_DandR_ID();

            foreach (sp_generate_DandR_IDResult count in query)
            {
                iicount = count.count.Value;
                iicount = iicount++;
            }
            ++iicount;
            if (iicount.ToString().Length.Equals(1))
            {
                ID = "ReplacementNo-" + iicount.ToString().PadLeft(4, '0').ToString();
            }
            else if (iicount.ToString().Length.Equals(2))
            {
                ID = "ReplacementNo-" + iicount.ToString().PadLeft(3, '0').ToString();
            }
            else
            {
                ID = "ReplacementNo-" + iicount.ToString().PadLeft(2, '0').ToString();
            }

            return txtReplacementNo.Text = ID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvReplacements.Rows.Clear();
            MessageBox.Show("Successfully Saved!!");
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbTransaction.Hide();
            gbDandR.Show();
        }

        private void txtNoofDamages_Leave(object sender, EventArgs e)
        {
            if (txtNoofDamages.Text == "")
            {
                txtNoofDamages.Text = "Damages(Quantity)";
            }
        }

        private void txtNoofDamages_Click(object sender, EventArgs e)
        {
            if (txtNoofDamages.Text == "Damages(Quantity)")
            {
                txtNoofDamages.Text = "";
            }
        }

       

      
    }
}
