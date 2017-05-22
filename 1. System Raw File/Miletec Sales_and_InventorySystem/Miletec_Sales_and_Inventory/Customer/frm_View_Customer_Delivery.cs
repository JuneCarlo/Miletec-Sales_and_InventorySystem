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
    public partial class frm_View_Customer_Delivery : Form
    {
        public frm_View_Customer_Delivery()
        {
            InitializeComponent();
        }
        public static db_MiletecDataContext db = null;
        public string deliveryNo,transID;
        private void frm_View_Customer_Delivery_Load(object sender, EventArgs e)
        {

        }

        private void dgvCustomerDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            deliveryNo = dgvCustomerDelivery.CurrentRow.Cells[0].Value.ToString();
            transID = dgvCustomerDelivery.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvCustomerDelivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deliveryNo = dgvCustomerDelivery.CurrentRow.Cells[0].Value.ToString();
            transID = dgvCustomerDelivery.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            tblCustomerDelivery delNo = new tblCustomerDelivery();
            delNo.DeliveryID = deliveryNo;
            if (deliveryNo == delNo.DeliveryID)
            {
                dgvDeliveryDetails.DataSource = db.sp_view_CustomerDeliveryDetails(deliveryNo);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            db.sp_update_CustomerDeilveryStatus(transID, "Delivered");
            MessageBox.Show("Successfully Updated!!");

        }
    }
}
