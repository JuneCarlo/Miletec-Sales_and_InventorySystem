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
    public partial class frm_View_Delivery : Form
    {
        public frm_View_Delivery()
        {
            InitializeComponent();
        }
        public static db_MiletecDataContext db = null;
        public string deliveryNo, orderId, date, preparedAndreceivedBy, deliveredBy;
        
        private void frm_View_Delivery_Load(object sender, EventArgs e)
        {

        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            tblDeliveryDetail del = new tblDeliveryDetail();
            del.DeliveryNo = deliveryNo;
            if (deliveryNo == del.DeliveryNo)
            {
                dgvDeliveryDetails.DataSource = db.sp_view_DeliveryDetails(deliveryNo);
            }
        }

        private void dgvDeliveryFromSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            deliveryNo = dgvDeliveryFromSupplier.CurrentRow.Cells[0].Value.ToString();
            orderId = dgvDeliveryFromSupplier.CurrentRow.Cells[1].Value.ToString();
            date = dgvDeliveryFromSupplier.CurrentRow.Cells[2].Value.ToString();
            preparedAndreceivedBy = dgvDeliveryFromSupplier.CurrentRow.Cells[3].Value.ToString();
            deliveredBy = dgvDeliveryFromSupplier.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvDeliveryFromSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deliveryNo = dgvDeliveryFromSupplier.CurrentRow.Cells[0].Value.ToString();
            orderId = dgvDeliveryFromSupplier.CurrentRow.Cells[1].Value.ToString();
            date = dgvDeliveryFromSupplier.CurrentRow.Cells[2].Value.ToString();
            preparedAndreceivedBy = dgvDeliveryFromSupplier.CurrentRow.Cells[3].Value.ToString();
            deliveredBy = dgvDeliveryFromSupplier.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvDeliveryDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (lblsearch.Text == "" && txtSearch.Text == "")
            {
                lblsearch.Text = "Search";
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (lblsearch.Text == "Search")
            {
                lblsearch.Text = "";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            dgvDeliveryFromSupplier.DataSource = db.sp_Search_Delivery_Supplier(txtSearch.Text);
        }
    }
}
