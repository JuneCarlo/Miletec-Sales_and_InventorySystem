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
    public partial class frm_CustomerTransaction : Form
    {
        public frm_CustomerTransaction()
        {
            InitializeComponent();
        }
        static db_MiletecDataContext db = null;
        public string productQuality, productSize,services;
        public double price = 0, gtotal = 0, cashRendered = 0, amount, cashrendered = 0, glassSize = 0, ggtotal = 0,newtotal = 0,instaTotal =0;
        public int qtyLeft = 0, qtyOrdered = 0,glassqtyLeft = 0,glassQtyOrdered = 0;
        public  string productid;
        public string productname, glass, aroundtube, stainless;
        public static string TransactionID;
        

        private void txtcontactno1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if the user inputs string do not allow
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Cannot input characters!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void txtcontactno2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if the user inputs string do not allow
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Cannot input characters!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnsavepurchase_Click(object sender, EventArgs e)
        {
            //if the transaction was complete click save button
            db = new db_MiletecDataContext();
         //if all fields are not equal to empty
            if (txtgrandtotal.Text != "Grand Total" && txtcashrendered.Text != "Cash Render" && lblchange.Text != "" && txttimetodeliver.Text != "Time to Deliver")
            {
                //if the user checks the check box installation set..
                if (cbInstallation.Checked == true)
                {
                    services = "Installation";

                }
                else if (cbInstallation.Checked == false)
                {
                    services = "Delivery Only";
                    txtInstaTotal.Text = "0.00";


                }
                //execute if the stocks are greater than the quantity ordered by the customer
                if (double.Parse(txtcashrendered.Text) >= double.Parse(txtgrandtotal.Text))
                {
                    db.sp_update_CustomerTransaction(txttransactionid.Text,double.Parse(txtInstaTotal.Text),double.Parse(txtgrandtotal.Text),
                    double.Parse(txtcashrendered.Text), double.Parse(txtunitprice.Text), double.Parse(lblchange.Text), txttimetodeliver.Text,DateTime.Parse(dtpdate.Text), DateTime.Now,services, "To Deliver");
                    
                    db.SubmitChanges();
                    MessageBox.Show("Successfuly Save!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    frm_Receipt receipt = new frm_Receipt();
                    receipt.Show();
                    dgvcustomer.Rows.Clear();
                    dgvinstallation.Rows.Clear();
                   

                }

                //return to default if the user clicks the purchase button
                lblproductid.Text = "Product ID";
                cmbproductid.SelectedItem = null;
                txtProductName.Text = "ProductName/Size";
                txtquantity.Text = "Quantity";
                cbInstallation.Checked = false;
                txtInstallationName.Text = "Installation Name";
                txtInstallationName.Enabled = false;
                txtInstallationPayment.Text = "0";
                txtInstallationPayment.Enabled = false;
                txtunitprice.Text = "Unit Price";
                txtgrandtotal.Text = "0.00";
                txtcashrendered.Text = "0.00";
                lblchange.Text = "0.00";
                txtcustname.Text = "Customer Name";
                txtcustid.Text = "Customer ID";
                txtaddress.Text = "Address";
                txtcashrendered.Text = "Cash Render";
                txttimetodeliver.Text = "Time to Deliver";
                txtSubtotal.Text = "Subtotal";
            }
                //if some fields are empty
            else
            {
                MessageBox.Show("please fill up everything!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //generete id after the transaction
            GenwalkincusID(wtxttransactionid);
            GentransID(txttransactionid);
        }

        //auto generated transaction ID
        public static string GentransID(TextBox txttransactionid)
        {

            int iicount = 0;
            string ID = "";
            db = new db_MiletecDataContext();
            var query = db.sp_getcustomerid();

            foreach (sp_getcustomeridResult count in query)
            {
                iicount = count.count.Value;
                iicount = iicount++;
            }
            ++iicount;
            if (iicount.ToString().Length.Equals(1))
            {
                ID = "TransactionID-" + iicount.ToString().PadLeft(4, '0').ToString();
            }
            else if (iicount.ToString().Length.Equals(2))
            {
                ID = "TransactionID-" + iicount.ToString().PadLeft(3, '0').ToString();
            }
            else
            {
                ID = "TransactionID-" + iicount.ToString().PadLeft(2, '0').ToString();
            }

            return txttransactionid.Text = ID;
        }

        //click add button to add customer
        private void btnadd_Click(object sender, EventArgs e)
        {
            //if the user clicks the add button but he/she already chose a customer
            if (txtcustid.Text != "Customer ID")
            {

                    DialogResult result = MessageBox.Show("Are you sure you want cancel the transaction?",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        db.sp_delete_transaction(txttransactionid.Text);
                        GentransID(txttransactionid);
                        gbwalkintransaction.Hide();
                        gbcustomertransaction.Hide();
                        gbcustomerdetails.Show();
                      
                    }
            }
                //else continue transaction..
            else
            {
                gbwalkintransaction.Hide();
                gbcustomertransaction.Hide();
                gbcustomerdetails.Show();
            }
            
        }
        //click proceed button if the user had chosen a customer
        private void btnproceed_Click(object sender, EventArgs e)
        {
            dgvcustomerdetail.DataSource = clsrepository.customer();
            gbcustomerdetails.Hide();
            gbcustomertransaction.Show();
            db.sp_insertCustomerTrans(txttransactionid.Text, DateTime.Parse(dtpdate.Text), txtcustid.Text, txtcustname.Text, txtaddress.Text,null,null,
               null,null,null, null, "To Deliver");
            
        }

        private void frm_CustomerTransaction_Load(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            
            GenwalkincusID(wtxttransactionid);
            dgvcustomerdetail.DataSource = clsrepository.customer();
            
          
            GentransID(txttransactionid);
            gbcustomerdetails.Hide();
            gbcustomertransaction.Hide();
            gbwalkintransaction.Hide();
            txtInstallationPayment.Text = "0";
        }

        private void dgvcustomerdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcustid.Text = dgvcustomerdetail.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvcustomerdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcustid.Text = dgvcustomerdetail.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {

        }

        private void cmbproductid_SelectedIndexChanged(object sender, EventArgs e)
        {
           //Hide or show label

            if (cmbproductid.TabIndex == 1 && cmbproductid.Text != "")
            {
                lblproductid.Visible = false;
            }

            if (cmbproductid.Text == "")
            {
                lblproductid.Visible = true;                
            }
            //set product name for each product
                    
                 if (cmbproductid.Text == "ProductID-0001")
                 {
                     txtProductName.Text = "Glass";

                 }
                 else if (cmbproductid.Text == "ProductID-0002")
                 {

                     txtProductName.Text = "Around Tube Aluminum";
                 }
                 else if (cmbproductid.Text == "ProductID-0003")
                 {

                     txtProductName.Text = "Stainless Tube Aluminum";
                 }
                 else if (cmbproductid.Text == "ProductID-0004")
                 {
                     txtProductName.Text = "Glass(1/4)";
                 }
                 else if (cmbproductid.Text == "ProductID-0005")
                 {
                     txtProductName.Text = "Glass(1/2)";
                 }
                 else
                 {
                     txtProductName.Text = "Glass(3/4)";
                 }
                
             }

      

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
        //if txtquantity is not equal to empty
            try
            {
                if (txtquantity.Text != "")
                {
                    //Unit price(product) multiplied by the quantity ordered
                    gtotal = (double.Parse(txtunitprice.Text) * int.Parse(txtquantity.Text));
                    txtSubtotal.Text = gtotal.ToString("n2");

                }
                else
                {

                    txtSubtotal.Clear();

                }
            }
            catch { }
            
             
        }

        private void txtunitprice_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void txtcashrendered_TextChanged(object sender, EventArgs e)
        {
            //if the user inputs cash given from the customer
            if (txtcashrendered.Text != "")
            {
                try
                {
                    //cash rendered subtracted by the total amount to pay(installation payment + subtotal)
                    if(double.Parse(txtcashrendered.Text) > double.Parse(txtgrandtotal.Text))
                    {
                    cashRendered = double.Parse(txtcashrendered.Text) - double.Parse(txtgrandtotal.Text);
                    lblchange.Text = cashRendered.ToString("n2");
                    }
                    else
                    {
                        lblchange.Text = "0.00";
                        
                    }
                }

                catch (Exception)
                {

                    lblchange.Text = "0.00";
                }
            }
            
        }

        private void btnPurchase_Click_1(object sender, EventArgs e)
        {
            double sum = 0;


            db = new db_MiletecDataContext();

            double amount = 0;

            //if the all fields are filled
            if (txtcustid.Text != "Customer ID" && txtcustname.Text != "Customer Name" && cmbproductid.Text != "" && txtquantity.Text != "Quantity" && txtunitprice.Text != "Unit Price" && txtSubtotal.Text != "")
            {
                //product name for each product id
                if (cmbproductid.Text == "ProductID-0001")
                {
                    glass = "Glass";
                }
                if (cmbproductid.Text == "ProductID-0002")
                {
                    aroundtube = "Around Tube Aluminum";
                }
                if (cmbproductid.Text == "ProductID-0003")
                {
                    stainless = "Stainless Tube Aluminum";
                }

                //sizes for each product

                if (cmbproductid.Text == "ProductID-0001")
                {
                    productSize = "1";


                }
                else if (cmbproductid.Text == "ProductID-0002")
                {
                    productSize = "N/A";

                }
                else if (cmbproductid.Text == "ProductID-0003")
                {
                    productSize = "N/A";

                }
                else if (cmbproductid.Text == "ProductID-0004")
                {
                    productSize = "1/4";

                }
                else if (cmbproductid.Text == "ProductID-0005")
                {
                    productSize = "1/2";

                }
                else
                {
                    productSize = "3/4";
                }
                //get transaction id(receipt purposes)
                var transaction = db.get_TransactionID(txttransactionid.Text);
                foreach (get_TransactionIDResult a in transaction.ToList())
                {
                    TransactionID = a.transactionid.ToString();
                }
                
                //get stocks available 
                var query_StockQty = db.sp_RetrieveStocksQuantity(cmbproductid.Text, txtProductName.Text);
                foreach (sp_RetrieveStocksQuantityResult entry in query_StockQty.ToList())
                {
                    qtyLeft = int.Parse(entry.availqty.ToString());
                    qtyOrdered = qtyLeft - int.Parse(txtquantity.Text);//quantity available minus quantity ordered
                    glassSize = double.Parse(entry.Size.ToString());

                    //update stocks available
                    if (cmbproductid.Text == "ProductID-0001")
                    {
                        db.sp_Update_StocksQty(cmbproductid.Text, qtyOrdered);

                    }
                    else if (cmbproductid.Text == "ProductID-0002")
                    {
                        db.sp_Update_StocksQty(cmbproductid.Text, qtyOrdered);
                    }
                    else
                    {
                        db.sp_Update_StocksQty(cmbproductid.Text, qtyOrdered);
                    }
                }
                //if available quantity is greater than the quantity ordered
                if (qtyLeft >= int.Parse(txtquantity.Text))
                {


                    amount = int.Parse(txtquantity.Text) * double.Parse(txtunitprice.Text);
                    dgvcustomer.Rows.Add(cmbproductid.Text, txtProductName.Text, productSize, txtquantity.Text, txtunitprice.Text, amount);
                    db.sp_insertcustomertrans_Details(txttransactionid.Text, cmbproductid.Text,txtProductName.Text, int.Parse(txtquantity.Text),double.Parse(txtunitprice.Text), productSize, "To Deliver",DateTime.Now,
                                                       double.Parse(txtSubtotal.Text),"Reservation");
                   
                    for (int i = 0; i < dgvcustomer.Rows.Count; i++)
                    {

                        sum += Convert.ToDouble(dgvcustomer.Rows[i].Cells[4].Value) * Convert.ToDouble(dgvcustomer.Rows[i].Cells[3].Value);
                        dgvcustomer.Rows[i].Selected = false;

                    }
                    txtgrandtotal.Text = sum.ToString("n2");
                    dgvcustomer.Rows[dgvcustomer.Rows.Count - 1].Selected = true;
                    MessageBox.Show("Purchased!!");
                    txtProductName.Text = "ProductName/Size";
                    txtquantity.Text = "Quantity";
                   
                    cmbproductid.SelectedItem = null;

                }
                    //if quantity available is less than the quantity ordered
                else if (qtyOrdered < int.Parse(txtquantity.Text))
                {
                    

                    var query_StockQty1 = db.sp_RetrieveStocksQuantity(cmbproductid.Text, txtProductName.Text);
                    foreach (sp_RetrieveStocksQuantityResult entry in query_StockQty1.ToList())
                    {
                        qtyLeft = int.Parse(entry.availqty.ToString());
                        qtyOrdered = qtyLeft + int.Parse(txtquantity.Text);
                        glassSize = double.Parse(entry.Size.ToString());


                        if (cmbproductid.Text == "ProductID-0001")
                        {
                            db.sp_Update_StocksQty(cmbproductid.Text, qtyOrdered);

                        }
                        else if (cmbproductid.Text == "ProductID-0002")
                        {
                            db.sp_Update_StocksQty(cmbproductid.Text, qtyOrdered);
                        }
                        else
                        {
                            db.sp_Update_StocksQty(cmbproductid.Text, qtyOrdered);
                        }
                    }
                    MessageBox.Show("Not enough stocks!");
            }

                    
           }   
                //if some fields are empty
            else
            {
                MessageBox.Show("please fill up everything!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtgrandtotal_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtsearchcustomer_TextChanged(object sender, EventArgs e)
        {
            dgvcustomerdetail.DataSource = clsrepository.Search(txtsearch.Text);
        }


        public static string GencusID(TextBox txtcustomerid)
        {

            int iicount = 0;
            string ID = "";
            db = new db_MiletecDataContext();
            var query = db.sp_genCustomerID();

            foreach (sp_genCustomerIDResult count in query)
            {
                iicount = count.count.Value;
                iicount = iicount++;
            }
            ++iicount;
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



        private void dgvcustomerdetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcustid.Text = dgvcustomerdetail.CurrentRow.Cells[1].Value.ToString();
            txtcustname.Text = dgvcustomerdetail.CurrentRow.Cells[2].Value.ToString();
            txtaddress.Text = dgvcustomerdetail.CurrentRow.Cells[3].Value.ToString();
            //txtcustomerid.Text = dgvcustomerdetail.CurrentRow.Cells[1].Value.ToString();
            //txtcustomername.Text = dgvcustomerdetail.CurrentRow.Cells[2].Value.ToString();
            //txtaddress.Text = dgvcustomerdetail.CurrentRow.Cells[3].Value.ToString();
            //txtcontactno1.Text = dgvcustomerdetail.CurrentRow.Cells[4].Value.ToString();
            //txtcontactno2.Text = dgvcustomerdetail.CurrentRow.Cells[5].Value.ToString();
            //btnsave.Enabled = false;
        }

        private void dgvcustomerdetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcustid.Text = dgvcustomerdetail.CurrentRow.Cells[1].Value.ToString();
            txtcustname.Text = dgvcustomerdetail.CurrentRow.Cells[2].Value.ToString();
            txtaddress.Text = dgvcustomerdetail.CurrentRow.Cells[3].Value.ToString();
            //txtcustomerid.Text = dgvcustomerdetail.CurrentRow.Cells[1].Value.ToString();
            //txtcustomername.Text = dgvcustomerdetail.CurrentRow.Cells[2].Value.ToString();
            //txtaddress.Text = dgvcustomerdetail.CurrentRow.Cells[3].Value.ToString();
            //txtcontactno1.Text = dgvcustomerdetail.CurrentRow.Cells[4].Value.ToString();
            //txtcontactno2.Text = dgvcustomerdetail.CurrentRow.Cells[5].Value.ToString();
            //btnsave.Enabled = false;
        }

        private void txtcontactno1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Cannot input characters!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void txtcontactno2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Cannot input characters!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void dgvcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productid = dgvcustomer.CurrentRow.Cells[0].Value.ToString();
            cmbproductid.Text = dgvcustomer.CurrentRow.Cells[0].Value.ToString();
            txtquantity.Text = dgvcustomer.CurrentRow.Cells[3].Value.ToString();
            txtSubtotal.Text = dgvcustomer.CurrentRow.Cells[5].Value.ToString();
            lblproductid.Text = "";
        }

        private void btncanceldetails_Click(object sender, EventArgs e)
        {
            gbcustomerdetails.Hide();
            gbwalkintransaction.Hide();
            gbcustomertransaction.Show();
            txtcustid.Clear();
            txtcustname.Clear();


        }

        private void wbtnpurchase_Click(object sender, EventArgs e)
        {

            double sum = 0;
            db = new db_MiletecDataContext();

            double amount = 0;
            //if all fields are filled
            if (wcmbproductid.Text != "" && wtxtquantity.Text != "Quantity" && wtxtsubtotal.Text != "Sub Total" && wtxtunitprice.Text != "Unit Price")
            {
                //product sizes for each product
                if (wcmbproductid.Text == "ProductID-0001")
                {
                    productSize = "1";
                }
                else if (wcmbproductid.Text == "ProductID-0002")
                {
                    productSize = "N/A";
                }
                else if (wcmbproductid.Text == "ProductID-0003")
                {
                    productSize = "N/A";
                }
                else if (wcmbproductid.Text == "ProductID-0004")
                {
                    productSize = "1/4";
                }
                else if (wcmbproductid.Text == "ProductID-0005")
                {
                    productSize = "1/2";
                }
                else
                {
                    productSize = "3/4";
                }
                
                amount = int.Parse(wtxtquantity.Text) * double.Parse(wtxtunitprice.Text);
                //get stocks quantity available
                var query_StockQty1 = db.sp_RetrieveStocksQuantity(wcmbproductid.Text, wtxtProductName.Text);
                foreach (sp_RetrieveStocksQuantityResult entry in query_StockQty1.ToList())
                {
                    qtyLeft = int.Parse(entry.availqty.ToString());
                    qtyOrdered = qtyLeft - int.Parse(wtxtquantity.Text);//quantity available minus quantity ordered
                    glassSize = double.Parse(entry.Size.ToString());

                    //update quantity available
                    if (wcmbproductid.Text == "ProductID-0001")
                    {
                        db.sp_Update_StocksQty(wcmbproductid.Text, qtyOrdered);

                    }
                    else if (wcmbproductid.Text == "ProductID-0002")
                    {
                        db.sp_Update_StocksQty(wcmbproductid.Text, qtyOrdered);
                    }
                    else
                    {
                        db.sp_Update_StocksQty(wcmbproductid.Text, qtyOrdered);
                    }
                }

                int money = 0;
                //not equal
                if (txtquantity.Text != money.ToString())
                {
                    //quantity ordered ordered less than quantity left
                    if (int.Parse(wtxtquantity.Text) <= qtyLeft)
                    {

                        wdgvcustomerdetails.Rows.Add(wcmbproductid.Text,wtxtProductName.Text, productSize, wtxtquantity.Text, wtxtunitprice.Text, amount);
                        //count all, check if row is greater than zero, execute condition
                        for (int i = 0; i < wdgvcustomerdetails.Rows.Count; i++)
                        {
                            //get quantity ordered then multiply by unit price
                            sum += Convert.ToDouble(wdgvcustomerdetails.Rows[i].Cells[3].Value) * Convert.ToDouble(wdgvcustomerdetails.Rows[i].Cells[4].Value);
                            wdgvcustomerdetails.Rows[i].Selected = false;
                            wtxtcashrendered.Enabled = true;

                        }
                        wtxtgrandtotal.Text = sum.ToString("n2");
                        wdgvcustomerdetails.Rows[wdgvcustomerdetails.Rows.Count - 1].Selected = true;
                        db.sp_insertcustomertrans_Details(wtxttransactionid.Text, wcmbproductid.Text,wtxtProductName.Text, int.Parse(wtxtquantity.Text),double.Parse(wtxtunitprice.Text), productSize, "N/A", DateTime.Now,
                                                      double.Parse(wtxtsubtotal.Text), "Walk-in");
                        MessageBox.Show("Successfully puchased!!");
                        wcmbproductid.SelectedItem = null;
                        lblwproductid.Text = "Product ID";
                        wtxtProductName.Text = "Product Name";
                       
                        wtxtquantity.Text = "Quantity";
                        wtxtsubtotal.Text = "Sub Total";

                    }
                        //if quantity ordered is greater than the available quantity
                    else if (qtyOrdered < int.Parse(wtxtquantity.Text))
                    {
                        MessageBox.Show("Not enough stocks!");

                        var query_StockQty = db.sp_RetrieveStocksQuantity(wcmbproductid.Text, wtxtProductName.Text);
                        foreach (sp_RetrieveStocksQuantityResult entry in query_StockQty.ToList())
                        {
                            qtyLeft = int.Parse(entry.availqty.ToString());
                            qtyOrdered = qtyLeft + int.Parse(wtxtquantity.Text);
                            glassSize = double.Parse(entry.Size.ToString());


                            if (wcmbproductid.Text == "ProductID-0001")
                            {
                                db.sp_Update_StocksQty(wcmbproductid.Text, qtyOrdered);

                            }
                            else if (wcmbproductid.Text == "ProductID-0002")
                            {
                                db.sp_Update_StocksQty(wcmbproductid.Text, qtyOrdered);
                            }
                            else
                            {
                                db.sp_Update_StocksQty(wcmbproductid.Text, qtyOrdered);
                            }
                        }
                    }
                }

                else
                {
                    MessageBox.Show("please put a quantity first!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("please fill up everything!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //auto generate walk-in transaction id
        public static string GenwalkincusID(TextBox wtxttransactionid)
        {

            int iicount = 0;
            string ID = "";
            db = new db_MiletecDataContext();
            var query = db.sp_displaycustranID();

            foreach (sp_displaycustranIDResult count in query)
            {
                //count all sucessful saved transactions
                iicount = count.count.Value;
                iicount = iicount++;
            }
            ++iicount;
            //substring
            //customer transaction is equal to 1 digit
            if (iicount.ToString().Length.Equals(1))
            {
                ID = "TransactionID-" + iicount.ToString().PadLeft(4, '0').ToString();
            }
            //customer transaction is equal to 2 digit
            else if (iicount.ToString().Length.Equals(2))
            {
                ID = "TransactionID-" + iicount.ToString().PadLeft(3, '0').ToString();
            }
            else
            {
                ID = "TransactionID-" + iicount.ToString().PadLeft(2, '0').ToString();
            }

            return wtxttransactionid.Text = ID;
        }

        private void gbcustomertransaction_Enter(object sender, EventArgs e)
        {

        }

        private void wbtnsave_Click(object sender, EventArgs e)
        {
            //save into the database
            var transaction = db.get_TransactionID(txttransactionid.Text);
            foreach (get_TransactionIDResult a in transaction.ToList())
            {
                TransactionID = a.transactionid.ToString();
            }
            db = new db_MiletecDataContext();
            if (wtxtcashrendered.Text != "Cash Render" && wtxtgrandtotal.Text != "Grand Total")
            {
                if (double.Parse(wtxtcashrendered.Text) >= double.Parse(wtxtgrandtotal.Text))
                {


                    db.sp_update_CustomerTransaction(wtxttransactionid.Text, Convert.ToDouble("0"), double.Parse(wtxtgrandtotal.Text),
                   double.Parse(wtxtcashrendered.Text), double.Parse(wtxtunitprice.Text), double.Parse(wlblchange.Text),"N/A", DateTime.Now, DateTime.Now, "N/A", "Walk-in Customer");
                    
                       
                       
                        db.SubmitChanges();
                        MessageBox.Show("Successfuly Save!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        wdgvcustomerdetails.Rows.Clear();
                        wcmbproductid.SelectedItem = null;
                        wtxtquantity.Text = "Quantity";
                        wtxtProductName.Text = "Product Name";
                        wtxtunitprice.Text = "Unit Price";
                        wtxtgrandtotal.Text = "Grand Total";
                        wtxtcashrendered.Text = "Cash Render";
                        wtxtsubtotal.Text = "Sub Total";
                        wlblchange.Text = ".";
                        lblwproductid.Text = "Product ID";
                        GenwalkincusID(wtxttransactionid);
                        GentransID(txttransactionid);
                    //show receipt
                        frm_Receipt rec = new frm_Receipt();
                        rec.Show();
                }
                else
                {
                    MessageBox.Show("Insufficient amount!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("please enter your amount to pay!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void wtxtunitprice_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void wtxtcashrendered_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (wtxtcashrendered.Text != "Cash Render")
                {
                    if (double.Parse(wtxtcashrendered.Text) > double.Parse(wtxtgrandtotal.Text))
                    {
                        cashrendered = double.Parse(wtxtcashrendered.Text) - double.Parse(wtxtgrandtotal.Text);
                        wlblchange.Text = cashrendered.ToString("n2");
                    }
                    else
                    {
                        wlblchange.Text = "0.00";

                    }
                }
            }
            catch (Exception)
            { }
        }

        private void wcmbproductid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wcmbproductid.TabIndex == 0 && wcmbproductid.Text != "")
            {
                lblwproductid.Visible = false;
            }
            if (wcmbproductid.Text == "")
            {
                lblwproductid.Visible = true;
            }

            if (wcmbproductid.Text == "ProductID-0001")
            {
                wtxtProductName.Text = "Glass";
            }
            else if (wcmbproductid.Text == "ProductID-0002")
            {
                wtxtProductName.Text = "Around Tube Aluminum";
            }
            else if (wcmbproductid.Text == "ProductID-0003")
            {
                wtxtProductName.Text = "Stainless Tube Aluminum";
            }
            else if (wcmbproductid.Text == "ProductID-0004")
            {
                wtxtProductName.Text = "Glass(1/4)";
            }
            else if (wcmbproductid.Text == "ProductID-0005")
            {
                wtxtProductName.Text = "Glass(1/2)";
            }
            else
            {
                wtxtProductName.Text = "Glass(3/4)";
            }
         
           
        }

        private void btnreservation_Click(object sender, EventArgs e)
        {
            btnreservation.Hide();
            btnwalkin.Hide();
            gbcustomertransaction.Show();
            gbcustomerdetails.Show();
        }

        private void btnwalkin_Click(object sender, EventArgs e)
        {
            btnreservation.Hide();
            btnwalkin.Hide();
            gbwalkintransaction.Show();
            db.sp_insertCustomerTrans(wtxttransactionid.Text, DateTime.Parse(wdtpdate.Text), null, null, null, double.Parse("0.00"), null, null, null, null, null, "");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            gbcustomerdetails.Hide();
            gbcustomertransaction.Hide();
            gbwalkintransaction.Hide();
            btnreservation.Show();
            btnwalkin.Show();

        }

        private void btnbackk_Click(object sender, EventArgs e)
        {
            gbcustomerdetails.Hide();
            gbcustomertransaction.Hide();
            gbwalkintransaction.Hide();
            btnreservation.Show();
            btnwalkin.Show();
        }

        private void wdgvcustomerdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            wcmbproductid.Text = wdgvcustomerdetails.CurrentRow.Cells[0].Value.ToString();
            wtxtquantity.Text = wdgvcustomerdetails.CurrentRow.Cells[3].Value.ToString();
            wtxtsubtotal.Text = wdgvcustomerdetails.CurrentRow.Cells[5].Value.ToString();
        }

        private void cmbproductid_SelectedValueChanged(object sender, EventArgs e)
        {
            string presyo;

            var query_GetPrice = db.sp_get_ProductPrice(cmbproductid.Text);
            foreach (sp_get_ProductPriceResult entry in query_GetPrice.ToList())
            {
                presyo = entry.price.ToString();
                if (cmbproductid.Text == "ProductID-0001")
                {

                    txtunitprice.Text = presyo;
                }
                else if (cmbproductid.Text == "ProductID-0002")
                {

                    txtunitprice.Text = presyo;
                }
                else if (cmbproductid.Text == "ProductID-0003")
                {
                    txtunitprice.Text = presyo;
                }
                else if (cmbproductid.Text == "ProductID-0004")
                {
                    txtunitprice.Text = presyo;
                }
                else if (cmbproductid.Text == "ProductID-0005")
                {
                    txtunitprice.Text = presyo;
                }
                else
                {
                    txtunitprice.Text = presyo;
                }
            }

        }

        private void cmbproductid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void wcmbproductid_SelectedValueChanged(object sender, EventArgs e)
        {
            string presyo;

            var query_GetPrice = db.sp_get_ProductPrice(wcmbproductid.Text);
            foreach (sp_get_ProductPriceResult entry in query_GetPrice.ToList())
            {
                presyo = entry.price.ToString();
                if (wcmbproductid.Text == "ProductID-0001")
                {

                    wtxtunitprice.Text = presyo;
                }
                else if (wcmbproductid.Text == "ProductID-0002")
                {

                    wtxtunitprice.Text = presyo;
                }
                else
                {
                    wtxtunitprice.Text = presyo;

                }
            }
        }

        private void wtxtquantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (wtxtquantity.Text != "")
                {
                    ggtotal = (double.Parse(wtxtunitprice.Text) * int.Parse(wtxtquantity.Text));
                    wtxtsubtotal.Text = ggtotal.ToString("n2");

                }
                else
                {

                    wtxtsubtotal.Clear();

                }
            }
            catch (Exception ex)
            {
            }
        }

      
        private void txtcustid_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbInstallation_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInstallation.Checked == true)
            { 
                txtInstallationPayment.Enabled = true;
                txtInstallationName.Enabled = true;
                btninstall.Enabled = true;
            }
            else
            {
                txtInstallationPayment.Enabled = false;
                txtInstallationName.Enabled = false;
                btninstall.Enabled = false;
            }
        }

        private void txtInstallationPayment_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btncanceldetails_Click_1(object sender, EventArgs e)
        {
            gbcustomerdetails.Hide();
            gbcustomertransaction.Show();
            gbwalkintransaction.Hide();
            btnreservation.Hide();
            btnwalkin.Hide();
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            if (txtgrandtotal.Text == "Grand Total" || txtcashrendered.Text == "Cash Render")
            {
                DialogResult result = MessageBox.Show("Are you sure you want cancel the transaction?",
                           "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            
        }

        private void btninstall_Click(object sender, EventArgs e)
        {
            double sum = 0;
           
            

            if (cbInstallation.Checked == true)
            {
                services = "Installation";
            }
            else if (cbInstallation.Checked == false)
            {
                services = "Delivery Only";
            }

            if (txtcustid.Text != "Customer ID" && txtInstallationName.Text != "Installation Name" && txtInstallationPayment.Text != "Installation Payment")
            {
                productid = dgvcustomer.CurrentRow.Cells[0].Value.ToString();
                db.sp_insertInstallation(txtcustid.Text, txttransactionid.Text, productid, txtcustname.Text, txtInstallationName.Text, DateTime.Now, double.Parse(txtInstallationPayment.Text));
                dgvinstallation.Rows.Add(productid, txtInstallationName.Text, txtInstallationPayment.Text);
                sum += float.Parse(txtgrandtotal.Text) + Convert.ToDouble(txtInstallationPayment.Text);
                txtgrandtotal.Text = sum.ToString("n2");
                MessageBox.Show("Product Installed", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                for (int i = 0; i < dgvinstallation.Rows.Count; i++)
                {

                    instaTotal += Convert.ToDouble(dgvinstallation.Rows[i].Cells[2].Value) - Convert.ToDouble(dgvinstallation.Rows[i].Cells[2].Value) + Convert.ToDouble(txtInstallationPayment.Text);
                    txtInstallationPayment.Text = "0";
                    dgvinstallation.Rows[i].Selected = false;
                    button1.Enabled = true;

                }
                txtInstaTotal.Text = instaTotal.ToString("n2");
                dgvinstallation.Rows[dgvinstallation.Rows.Count - 1].Selected = true;

            }
            else
            {
                MessageBox.Show("please fill up everything!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
         
        private void dgvcustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productid = dgvcustomer.CurrentRow.Cells[0].Value.ToString();
            cmbproductid.Text = dgvcustomer.CurrentRow.Cells[0].Value.ToString();
            txtquantity.Text = dgvcustomer.CurrentRow.Cells[3].Value.ToString();
            txtSubtotal.Text = dgvcustomer.CurrentRow.Cells[5].Value.ToString();
            lblproductid.Text = "";
        }

        private void dgvinstallation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnprintview_Click(object sender, EventArgs e)
        {
            MiletecPrintPreviewDialog.Document = MiletecPrintDocument;
            MiletecPrintPreviewDialog.ShowDialog();
        }

        private void MiletecPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            db = new db_MiletecDataContext();


           

            if (cmbproductid.Text == "ProductID-0001")
            {
                glass = "Glass";
            }
            if (cmbproductid.Text == "ProductID-0002")
            {
                aroundtube = "Around Tube Aluminum";
            }
            if (cmbproductid.Text == "ProductID-0003")
            {
                stainless = "Stainless Tube Aluminum";
            }

           
            

            e.Graphics.DrawString("Transaction ID: " + txttransactionid.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 180));
            e.Graphics.DrawString("Customer ID: " + txtcustid.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 200));
            e.Graphics.DrawString("Customer Name: " + txtcustname.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 220));
            e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 240));


            e.Graphics.DrawString(lbldash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 290));
            e.Graphics.DrawString("Item Description " , new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 320));
            e.Graphics.DrawString("Product ID "  , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 320));
            e.Graphics.DrawString("Size ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(375, 320));
            e.Graphics.DrawString("Quantity ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, 320));
            e.Graphics.DrawString("Unit Price", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(725, 320));
            e.Graphics.DrawString(lbldash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 340));

            e.Graphics.DrawString(glass, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 360));
            e.Graphics.DrawString(stainless, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 375));
            e.Graphics.DrawString(aroundtube, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 38));
           // e.Graphics.DrawString(txtProductName.Text,  new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(375, 360));
            e.Graphics.DrawString(txtquantity.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(570, 360));
            e.Graphics.DrawString(txtunitprice.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(735, 360));

            e.Graphics.DrawString(lbldash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 410));
            e.Graphics.DrawString("Services", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 430));
            e.Graphics.DrawString("Installation Name", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(200, 430));
            e.Graphics.DrawString("Install Payment", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 430));
            e.Graphics.DrawString(lbldash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 450));

            e.Graphics.DrawString(txtInstallationName.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(230, 470));
            e.Graphics.DrawString(txtInstallationPayment.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(735, 470));

            e.Graphics.DrawString(lbldash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 500));
            e.Graphics.DrawString("Total Payment", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(25, 520));
            e.Graphics.DrawString("Grand Total", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(700, 520));
            e.Graphics.DrawString(lbldash.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 540));

            e.Graphics.DrawString("P " + txtgrandtotal.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(735, 560));

            e.Graphics.DrawString("Cash Render", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(700, 600));
            e.Graphics.DrawString("P " + txtcashrendered.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(735, 620));

            e.Graphics.DrawString("Change", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(700, 660));
            e.Graphics.DrawString("P " + lblchange.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(735, 680));


        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            MiletecPrintDocument.Print();
        }

        private void txtaddress_Leave(object sender, EventArgs e)
        {

        }

        private void cmbproductid_Leave(object sender, EventArgs e)
        {
            if (lblproductid.Text == "" && cmbproductid.Text == "")
            {
                lblproductid.Text = "Product ID";
                cmbproductid.SelectedItem = null;
            }
        }

        private void cmbproductid_Click(object sender, EventArgs e)
        {
            if (lblproductid.Text == "Product ID")
            {
                lblproductid.Text = "";
            }
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                txtProductName.Text = "ProductName/Size";
            }
        }

        private void txtProductName_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "ProductName/Size")
            {
                txtProductName.Text = "";
            }

        }

        private void txtunitprice_Leave(object sender, EventArgs e)
        {
            if (txtunitprice.Text == "")
            {
                txtunitprice.Text = "Unit Price";
            }
        }

        private void txtunitprice_Click(object sender, EventArgs e)
        {
            if (txtunitprice.Text == "Unit Price")
            {
                txtunitprice.Text = "";
            }
        }

        private void wtxtsubtotal_Leave(object sender, EventArgs e)
        {

        }

        private void wtxtsubtotal_Click(object sender, EventArgs e)
        {

        }

        private void txtquantity_Leave(object sender, EventArgs e)
        {
            if (txtquantity.Text == "")
            {
                txtquantity.Text = "Quantity";
            }
        }

        private void txtquantity_Click(object sender, EventArgs e)
        {
            if (txtquantity.Text == "Quantity")
            {
                txtquantity.Text = "";
            }
        }

        private void txtInstallationName_Leave(object sender, EventArgs e)
        {
            if (txtInstallationName.Text == "")
            {
                txtInstallationName.Text = "Installation Name";
            }
        }

        private void txtInstallationName_Click(object sender, EventArgs e)
        {
            if (txtInstallationName.Text == "Installation Name")
            {
                txtInstallationName.Text = "";
            }
        }

        private void txtgrandtotal_Leave(object sender, EventArgs e)
        {
            if (txtgrandtotal.Text == "")
            {
                txtgrandtotal.Text = "Grand Total";
            }
        }

        private void txtgrandtotal_Click(object sender, EventArgs e)
        {
            if (txtgrandtotal.Text == "Grand Total")
            {
                txtgrandtotal.Text = "";
            }
        }

        private void txtcashrendered_Leave(object sender, EventArgs e)
        {
            if (txtcashrendered.Text == "")
            {
                txtcashrendered.Text = "Cash Render";
            }
        }

        private void txtcashrendered_Click(object sender, EventArgs e)
        {
            if (txtcashrendered.Text == "Cash Render")
            {
                txtcashrendered.Text = "";
            }
        }

        private void txttimetodeliver_Leave(object sender, EventArgs e)
        {
            if (txttimetodeliver.Text == "") 
            {
                txttimetodeliver.Text = "Time to Deliver";
            }
        }

        private void txttimetodeliver_Click(object sender, EventArgs e)
        {
            if (txttimetodeliver.Text == "Time to Deliver")
            {
                txttimetodeliver.Text = "";
            }
        }

        private void txtInstallationPayment_Click(object sender, EventArgs e)
        {
            if (txtInstallationPayment.Text == "0")
            {
                txtInstallationPayment.Text = "";
            }
        }

        private void txtInstallationPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Error, cannot input characters", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     
        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Error, cannot input characters", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcashrendered_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Error, cannot input characters", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void wcmbproductid_Leave(object sender, EventArgs e)
        {
            if (lblwproductid.Text == "" && wcmbproductid.Text == "")
            {
                lblwproductid.Text = "Product ID";
                wcmbproductid.SelectedItem = null;
            }
        }

        private void wcmbproductid_Click(object sender, EventArgs e)
        {
            if (lblwproductid.Text == "Product ID")
            {
                lblwproductid.Text = "";
            }
        }

        private void wtxtProductName_Leave(object sender, EventArgs e)
        {
            if (wtxtProductName.Text == "")
            {
                wtxtProductName.Text = "Product Name";
            }
        }

        private void wtxtProductName_Click(object sender, EventArgs e)
        {
            if (wtxtProductName.Text == "Product Name")
            {
                wtxtProductName.Text = "";
            }
        }

        private void wtxtunitprice_Leave(object sender, EventArgs e)
        {
            if (wtxtunitprice.Text == "")
            {
                wtxtunitprice.Text = "Unit Price";
            }
        }

        private void wtxtunitprice_Click(object sender, EventArgs e)
        {
            if (wtxtunitprice.Text == "Unit Price")
            {
                wtxtunitprice.Text = "";
            }
        }

        private void btnwalkin_Leave(object sender, EventArgs e)
        {

        }

        private void wtxtquantity_Click(object sender, EventArgs e)
        {
            if (wtxtquantity.Text == "Quantity")
            {
                wtxtquantity.Text = "";
            }
        }

        private void wtxtquantity_Leave(object sender, EventArgs e)
        {
            if (wtxtquantity.Text == "")
            {
                wtxtquantity.Text = "Quantity";
            }
        }

        private void wtxtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Cannot input characters!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void wtxtcashrendered_Leave(object sender, EventArgs e)
        {
            if (wtxtcashrendered.Text == "")
            {
                wtxtcashrendered.Text = "Cash Render";
            }
        }

        private void wtxtcashrendered_Click(object sender, EventArgs e)
        {
            if (wtxtcashrendered.Text == "Cash Render")
            {
                wtxtcashrendered.Text = "";
            }
        }

        private void wtxtcashrendered_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                MessageBox.Show("Cannot input characters!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Installation_Receipt ins = new frm_Installation_Receipt();
            ins.ShowDialog();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {

            db = new db_MiletecDataContext();
            DialogResult result = MessageBox.Show
        (" Are you sure you want to remove?", " Confirmation",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                if (txtcustid.Text != "Customer ID" && txtcustname.Text != "Customer Name" && cmbproductid.Text != "" && txtquantity.Text != "Quantity" && txtunitprice.Text != "Unit Price" && txtSubtotal.Text != "")
                {
                    //orderdetails.OrderID = dgvOrderDetails.CurrentRow.Cells[0].Value.ToString();
                    db.sp_removeTrans_details(txttransactionid.Text);
                   
                }

                var query_StockQty1 = db.sp_RetrieveStocksQuantity(cmbproductid.Text, txtProductName.Text);
                foreach (sp_RetrieveStocksQuantityResult entry in query_StockQty1.ToList())
                {
                    qtyLeft = int.Parse(entry.availqty.ToString());
                    qtyOrdered = qtyLeft + int.Parse(txtquantity.Text);
                    glassSize = double.Parse(entry.Size.ToString());


                    if (cmbproductid.Text == "ProductID-0001")
                    {
                        db.sp_Update_StocksQty(cmbproductid.Text, qtyOrdered);

                    }
                    else if (cmbproductid.Text == "ProductID-0002")
                    {
                        db.sp_Update_StocksQty(cmbproductid.Text, qtyOrdered);
                    }
                    else
                    {
                        db.sp_Update_StocksQty(cmbproductid.Text, qtyOrdered);
                    }
                }
                double remove = double.Parse(txtgrandtotal.Text) - double.Parse(txtSubtotal.Text);

                txtgrandtotal.Text = remove.ToString("n2");

                dgvcustomer.Rows.Remove(dgvcustomer.CurrentRow);
                lblproductid.Text = "Product ID";
                txtProductName.Text = "ProductName/Size";
                txtquantity.Text = "Quantity";
                txtunitprice.Text = "Unit Price";
                cmbproductid.SelectedItem = null;


            }
        }

        private void wbtnremove_Click(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            DialogResult result = MessageBox.Show
        (" Are you sure you want to remove?", " Confirmation",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                if (wcmbproductid.Text != "" && wtxtquantity.Text != "Quantity" && wtxtsubtotal.Text != "Sub Total" && wtxtunitprice.Text != "Unit Price")
                {
                    //orderdetails.OrderID = dgvOrderDetails.CurrentRow.Cells[0].Value.ToString();
                    db.sp_removeTrans_details(wtxttransactionid.Text);

                }

                var query_StockQty1 = db.sp_RetrieveStocksQuantity(wcmbproductid.Text, wtxtProductName.Text);
                foreach (sp_RetrieveStocksQuantityResult entry in query_StockQty1.ToList())
                {
                    qtyLeft = int.Parse(entry.availqty.ToString());
                    qtyOrdered = qtyLeft + int.Parse(wtxtquantity.Text);
                    glassSize = double.Parse(entry.Size.ToString());


                    if (wcmbproductid.Text == "ProductID-0001")
                    {
                        db.sp_Update_StocksQty(wcmbproductid.Text, qtyOrdered);

                    }
                    else if (wcmbproductid.Text == "ProductID-0002")
                    {
                        db.sp_Update_StocksQty(wcmbproductid.Text, qtyOrdered);
                    }
                    else
                    {
                        db.sp_Update_StocksQty(wcmbproductid.Text, qtyOrdered);
                    }
                }
                double remove = double.Parse(wtxtgrandtotal.Text) - double.Parse(wtxtsubtotal.Text);

                wtxtgrandtotal.Text = remove.ToString("n2");

                wdgvcustomerdetails.Rows.Remove(wdgvcustomerdetails.CurrentRow);
                wcmbproductid.SelectedItem = null;
                lblwproductid.Text = "Product ID";
                wtxtProductName.Text = "Product Name";
                wtxtunitprice.Text = "Unit Price";
                wtxtquantity.Text = "Quantity";
                wtxtsubtotal.Text = "Sub Total";
            }
        }

        private void wdgvcustomerdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            wcmbproductid.Text = wdgvcustomerdetails.CurrentRow.Cells[0].Value.ToString();
            wtxtquantity.Text = wdgvcustomerdetails.CurrentRow.Cells[3].Value.ToString();
            wtxtsubtotal.Text = wdgvcustomerdetails.CurrentRow.Cells[5].Value.ToString();
        }
        
    }
}
