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
    public partial class wndw_Main_Staff : Form
    {
        public wndw_Main_Staff()
        {
            InitializeComponent();
        }



        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void pbcustomerdetails_MouseLeave(object sender, EventArgs e)
        {
            pbcustomerdetails.Visible = false;
        }

        private void pboxCustmerDetails_MouseHover(object sender, EventArgs e)
        {
            pbcustomerdetails.Visible = true;
        }

        private void pboxcustomerdelivery_MouseHover(object sender, EventArgs e)
        {
            pbcustomerdelivery.Visible = true;
        }

        private void pbcustomerdelivery_MouseLeave(object sender, EventArgs e)
        {
            pbcustomerdelivery.Visible = false;
        }

        private void pboxcustomertransaction_MouseHover(object sender, EventArgs e)
        {
            pbcustomertransaction.Visible = true;
        }

        private void pbcustomertransaction_MouseLeave(object sender, EventArgs e)
        {
            pbcustomertransaction.Visible = false;
        }

        private void pbcustomerdetails_Click(object sender, EventArgs e)
        {
            using (frm_Customer_Details custtran = new frm_Customer_Details())
            {
                custtran.ShowDialog();
            }
        
        }

        private void pbcustomerdelivery_Click(object sender, EventArgs e)
        {
            using(frm_Customer_Delivery del = new frm_Customer_Delivery())
            del.ShowDialog();
        }

        private void pbcustomertransaction_Click(object sender, EventArgs e)
        {
            using(frm_CustomerTransaction dsdas = new frm_CustomerTransaction())
            dsdas.ShowDialog();
        }

        private void pboxViewCustomerDelivery_MouseHover(object sender, EventArgs e)
        {
            pbViewCustomerDelivery.Visible = true;
        }

        private void pbViewCustomerDelivery_MouseLeave(object sender, EventArgs e)
        {
            pbViewCustomerDelivery.Visible = false;
        }

        private void pbViewCustomerDelivery_Click(object sender, EventArgs e)
        {
            frm_View_Customer_Delivery delivery = new frm_View_Customer_Delivery();
            delivery.Show();
        }

        private void wndw_Main_Staff_Load(object sender, EventArgs e)
        {
            gbstock.Hide();
            gbcustomer.Hide();
            gbdamage.Hide();
        }

        private void pboxviewcustomertransactio_MouseHover(object sender, EventArgs e)
        {
            pbviewcustomertransactio.Visible = true;
        }

        private void pbviewcustomertransactio_MouseLeave(object sender, EventArgs e)
        {
            pbviewcustomertransactio.Visible = false;
        }


        private void pbviewcustomertransactio_Click_1(object sender, EventArgs e)
        {

        }

        private void pboxviewstocks_MouseHover(object sender, EventArgs e)
        {
            pbviewstocks.Visible = true;
        }

        private void pbviewstocks_MouseLeave(object sender, EventArgs e)
        {
            pbviewstocks.Visible = false;
        }

        private void pbviewstocks_Click(object sender, EventArgs e)
        {
            using (frmViewStockforStaffForm view = new frmViewStockforStaffForm())
                view.ShowDialog();
        }

        private void pboxdamageAndReplacement_MouseHover(object sender, EventArgs e)
        {
            pbdamageAndreplacement.Visible = true;
        }

        private void pbdamageAndreplacement_MouseLeave(object sender, EventArgs e)
        {
            pbdamageAndreplacement.Visible = false;
        }

        private void pbdamageAndreplacement_Click(object sender, EventArgs e)
        {
            using (frm_DamagesAndReplacement damage = new frm_DamagesAndReplacement())
                damage.ShowDialog();
        }

        private void pboxUser_MouseHover(object sender, EventArgs e)
        {
            pbuser.Visible = true;
        }

        private void pbuser_MouseLeave(object sender, EventArgs e)
        {
            pbuser.Visible = false;
        }

        private void pboxcustomer_MouseHover(object sender, EventArgs e)
        {
            pbcustomer.Visible = true;
        }

        private void pbcustomer_MouseLeave(object sender, EventArgs e)
        {
            pbcustomer.Visible = false;
        }

        private void pboxstaff_MouseHover(object sender, EventArgs e)
        {
            pbstock.Visible = true;
        }  

        private void pbstock_MouseLeave(object sender, EventArgs e)
        {
            pbstock.Visible = false;
        }

        private void pboxservices_MouseHover(object sender, EventArgs e)
        {
            pbservices.Visible = true;
        }

        private void pbservices_MouseLeave(object sender, EventArgs e)
        {
            pbservices.Visible = false;
        }

        private void pbcustomer_Click(object sender, EventArgs e)
        {
            gbcustomer.Show();
            gbstock.Hide();
            gbdamage.Hide();
            gbuser.Hide();
        }

        private void pbstock_Click(object sender, EventArgs e)
        {
            gbstock.Show();
            gbcustomer.Hide();
            gbdamage.Hide();
            gbuser.Hide();
        }

        private void pboxdamageAndReplacement_Click(object sender, EventArgs e)
        {

        }

        private void pbservices_Click(object sender, EventArgs e)
        {
            gbdamage.Show();
            gbstock.Hide();
            gbcustomer.Hide();
            gbuser.Hide();
        }

        private void pboxviewstocks_Click(object sender, EventArgs e)
        {

        }

        private void gbdamage_Enter(object sender, EventArgs e)
        {

        }

        private void gbstock_Enter(object sender, EventArgs e)
        {

        }

        private void pbshutdown_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log-out?", "NOTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form1 Logout = new Form1();
                this.Hide();
                Logout.Show();
            }
        }

        private void pbupdateuser_MouseLeave(object sender, EventArgs e)
        {
            pbupdateuser.Visible = false;
        }

        private void pboxupdateuser_MouseHover(object sender, EventArgs e)
        {
            pbupdateuser.Visible = true;
        }

        private void pbupdateuser_Click(object sender, EventArgs e)
        {
            using (frm_ChangePassword change = new frm_ChangePassword())
                change.ShowDialog();
        }

        private void gbuser_Enter(object sender, EventArgs e)
        {

        }

        private void pbuser_Click(object sender, EventArgs e)
        {
            gbdamage.Hide();
            gbstock.Hide();
            gbcustomer.Hide();
            gbuser.Show();
        }

        private void pbviewcustomertransactio_Click(object sender, EventArgs e)
        {
            using (frmViewCustomerTransaction cus = new frmViewCustomerTransaction())
                cus.ShowDialog();
              
        }

    }
}
