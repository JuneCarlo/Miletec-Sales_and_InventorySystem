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
    public partial class frm_installation_customerService : Form
    {
        public frm_installation_customerService()
        {
            InitializeComponent();
        }

        static db_MiletecDataContext db = null;
        public double price = 0, gtotal = 0, cashRendered = 0, amount, cashrendered = 0, ggtotal = 0;

        private void frm_installation_customerService_Load(object sender, EventArgs e)
        {
            db = new db_MiletecDataContext();
            dgvinstallation.DataSource = db.sp_viewInstallion();    
        }
        private void lblclose_Click(object sender, EventArgs e)
        {
          
                this.Close();
        }

        private void dgvinstallation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

       
    

     
    }
}
