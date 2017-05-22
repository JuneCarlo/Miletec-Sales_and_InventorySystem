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
    public partial class frmViewUsers : Form
    {
        public frmViewUsers()
        {
            InitializeComponent();
        }

        public static db_MiletecDataContext db = null;
        public string UserID,Status;
        private void frmViewUsers_Load(object sender, EventArgs e)
        {

            db = new db_MiletecDataContext();
            var query = db.sp_view_User();
            foreach (sp_view_UserResult list in query)
            {
                dgvViewUsers.DataSource = db.sp_view_User().ToList<sp_view_UserResult>();
            }
        
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (Status == "Active")
            {
                db = new db_MiletecDataContext();
                db.sp_update_userActiveorNot(UserID, "Not Active");
                MessageBox.Show("User's Account Deactivated", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dgvViewUsers.DataSource = db.sp_view_User().ToList<sp_view_UserResult>();
            }
            else
            {
                MessageBox.Show("Account already deactivated", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void dgvViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserID = dgvViewUsers.CurrentRow.Cells[0].Value.ToString();
            Status = dgvViewUsers.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            UserID = dgvViewUsers.CurrentRow.Cells[0].Value.ToString();
            Status = dgvViewUsers.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (Status == "Not Active")
            {
                db = new db_MiletecDataContext();
                db.sp_update_userActiveorNot(UserID, "Active");
                MessageBox.Show("User's Account Activated", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dgvViewUsers.DataSource = db.sp_view_User().ToList<sp_view_UserResult>();
            }
            else
            {
                MessageBox.Show("User is active", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
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
            dgvViewUsers.DataSource = db.sp_Search_User(txtsearch.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
