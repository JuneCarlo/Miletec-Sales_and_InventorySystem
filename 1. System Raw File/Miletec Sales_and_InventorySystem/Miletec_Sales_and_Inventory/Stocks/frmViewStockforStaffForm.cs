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
    public partial class frmViewStockforStaffForm : Form
    {
        public frmViewStockforStaffForm()
        {
            InitializeComponent();
        }

        db_MiletecDataContext db = null;

        private void frmViewStockforStaffForm_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             db = new db_MiletecDataContext();
             dgvviewstock.DataSource = db.sp_searchStock(txtsearch.Text);
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsearch_Leave(object sender, EventArgs e)
        {
        }

        private void txtsearch_Click(object sender, EventArgs e)
        {
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
