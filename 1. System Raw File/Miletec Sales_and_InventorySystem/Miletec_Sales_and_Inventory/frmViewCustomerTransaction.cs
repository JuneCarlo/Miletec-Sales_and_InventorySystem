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
    public partial class frmViewCustomerTransaction : Form
    {
        public frmViewCustomerTransaction()
        {
            InitializeComponent();
        }
        public static db_MiletecDataContext db = null;
        public string transDetails;

        private void frm_ViewOrdersFromCustomer_Load(object sender, EventArgs e)
        {

        }

        private void dgvTransactionDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            tblcustomertrans_detail details = new tblcustomertrans_detail();
            details.transactionid = transDetails;
            if (transDetails == details.transactionid)
            {
                dgvTransactionDetails.DataSource = db.sp_view_TransactionDetails(transDetails);
            }

        }

        private void dgvCustomerTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            transDetails = dgvCustomerTransaction.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvCustomerTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            transDetails = dgvCustomerTransaction.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
