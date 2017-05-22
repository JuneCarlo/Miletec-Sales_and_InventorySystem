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
    public partial class frm_view_order_from_supplier : Form
    {
        public frm_view_order_from_supplier()
        {
            InitializeComponent();
        }
        public static db_MiletecDataContext db = null;
        public string orderID;
        private void frm_view_order_from_supplier_Load(object sender, EventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            tblOrderDetail orders = new tblOrderDetail();
            orders.OrderID = orderID;
            if (orderID == orders.OrderID)
            {
                dvgviewdetails.DataSource = db.sp_view_OrderDetails(orderID);
            }
        }

        private void dgvorderfromsupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            orderID = dgvorderfromsupplier.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvorderfromsupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderID = dgvorderfromsupplier.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsearch_Leave(object sender, EventArgs e)
        {
            if (lblsearch.Text == "" && txtsearch.Text == "")
            {
                lblsearch.Text = "Search";
            }
        }

        private void txtsearch_Click(object sender, EventArgs e)
        {
            if (lblsearch.Text == "Search")
            {
                lblsearch.Text = "";
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            dgvorderfromsupplier.DataSource = db.sp_Search_Orders(txtsearch.Text);
        
        }
    }
}
