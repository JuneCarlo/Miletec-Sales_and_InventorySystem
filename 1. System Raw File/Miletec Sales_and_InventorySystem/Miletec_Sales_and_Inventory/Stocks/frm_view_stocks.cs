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
    public partial class frm_view_stocks : Form
    {
        public frm_view_stocks()
        {
            InitializeComponent();
        }
        public static db_MiletecDataContext db = null;

        private void frm_view_stocks_Load(object sender, EventArgs e)
        {
            GenProductID(txtProductID);
        }
        public static string GenProductID(TextBox txtProductID)
        {

            int iicount = 0;
            string ID = "";
            db = new db_MiletecDataContext();
            var query = db.sp_generate_ProductID();

            foreach (sp_generate_ProductIDResult count in query)
            {
                iicount = count.count.Value;
                iicount = iicount++;
            }
            ++iicount;
            if (iicount.ToString().Length.Equals(1))
            {
                ID = "ProductID-" + iicount.ToString().PadLeft(4, '0').ToString();
            }
            else if (iicount.ToString().Length.Equals(2))
            {
                ID = "ProductID-" + iicount.ToString().PadLeft(3, '0').ToString();
            }
            else
            {
                ID = "ProductID-" + iicount.ToString().PadLeft(2, '0').ToString();
            }

            return  txtProductID.Text = ID;
        }

        private void dgvviewstocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            txtProductID.Text = dgvviewstocks.CurrentRow.Cells[0].Value.ToString();
            txtProductname.Text = dgvviewstocks.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dgvviewstocks.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvviewstocks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            txtProductID.Text = dgvviewstocks.CurrentRow.Cells[0].Value.ToString();
            txtProductname.Text = dgvviewstocks.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dgvviewstocks.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            db = new db_MiletecDataContext();
            db.sp_update_stock_price(double.Parse(txtPrice.Text), txtProductID.Text);
            db.SubmitChanges();
            dgvviewstocks.DataSource = clsrepository.dissock();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            db.sp_insert_productInStocks(txtProductID.Text,txtProductname.Text,0,double.Parse(txtPrice.Text),0,0,0);
            this.tblStocksTableAdapter2.Fill(this.miletecDataSet9.tblStocks);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProductname_LocationChanged(object sender, EventArgs e)
        {

        }

        private void txtProductname_Leave(object sender, EventArgs e)
        {
            if (txtProductname.Text == "")
            {
                txtProductname.Text = "Product Name";
            }
        }

        private void txtProductname_Click(object sender, EventArgs e)
        {
            if (txtProductname.Text == "Product Name")
            {
                txtProductname.Text = "";
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
            {
                txtPrice.Text = "Price";
            }
        }

        private void txtPrice_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text == "Price")
            {
                txtPrice.Text = "";
            }

        }
    }
}
