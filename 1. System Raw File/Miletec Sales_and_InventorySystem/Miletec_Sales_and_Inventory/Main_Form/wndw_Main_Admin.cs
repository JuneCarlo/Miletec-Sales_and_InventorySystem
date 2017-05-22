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
    public partial class wndw_Main_Admin : Form
    {
        public wndw_Main_Admin()
        {
            InitializeComponent();
        }

        private void pbCreateNewStaff_Click(object sender, EventArgs e)
        {
            using (frm_Add_Employee staff = new frm_Add_Employee())
            {
                staff.ShowDialog();
            }
        }


        private void pboxCreateNewtaff_MouseHover(object sender, EventArgs e)
        {
            pbCreateNewStaff.Visible = true;
        }



        private void pbCreateNewStaff_MouseLeave(object sender, EventArgs e)
        {
            pbCreateNewStaff.Visible = false;
        }

        private void pboxUserProfile_MouseHover(object sender, EventArgs e)
        {
            pbUserProfile.Visible = true;
        }

        private void pbUserProfile_MouseLeave(object sender, EventArgs e)
        {
            pbUserProfile.Visible = false;
        }

    

        private void pboxSupplierDetails_MouseHover(object sender, EventArgs e)
        {
            pbSupplierDetails.Visible = true;
        }

        private void pbSupplierDetails_MouseLeave(object sender, EventArgs e)
        {
            pbSupplierDetails.Visible = false;
        }

        private void pbSupplierDetails_Click(object sender, EventArgs e)
        {
            using (Supplier_Details sup = new Supplier_Details())
            {
                sup.ShowDialog();
            }
        }

        private void pboxCustmerTransaction_Click(object sender, EventArgs e)
        {

        }

        private void pboxDeliverysup_MouseHover(object sender, EventArgs e)
        {
            pbDeliverysup.Visible = true;
        }

        private void pbDeliverysup_MouseLeave(object sender, EventArgs e)
        {
            pbDeliverysup.Visible = false;
        }

        private void pbDeliverysup_Click(object sender, EventArgs e)
        {
            using (frm_Delivery_Supplier form = new frm_Delivery_Supplier())
            {
                form.ShowDialog();
            }
        }

        private void pbUserProfile_Click(object sender, EventArgs e)
        {
            using (frm_ChangePassword changepass = new frm_ChangePassword())
            {
                changepass.ShowDialog();
            }
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void pboxSupplierTransaction_MouseHover_1(object sender, EventArgs e)
        {
            pbSupplierTransaction.Visible = true;
        }

        private void pbSupplierTransaction_MouseLeave(object sender, EventArgs e)
        {
            pbSupplierTransaction.Visible = false;
        }

        private void pboxCustmerTransaction_MouseHover(object sender, EventArgs e)
        {
            pbCustmerTransaction.Visible = true;
        }

        private void pbCustmerTransaction_MouseLeave(object sender, EventArgs e)
        {
            pbCustmerTransaction.Visible = false;
        }

        private void pbCustmerTransaction_Click(object sender, EventArgs e)
        {
            using (frm_CustomerTransaction trans = new frm_CustomerTransaction())
            {
                trans.ShowDialog();
            }
        }

        private void pbSupplierTransaction_Click(object sender, EventArgs e)
        {
            using (frm_SupplierTransaction SupplierTransaction = new frm_SupplierTransaction())
            {
                SupplierTransaction.ShowDialog();
            }
        }

        private void pboxViewDelivery_MouseHover(object sender, EventArgs e)
        {
            pbViewDelivery.Visible = true;
        }

        private void pbViewDelivery_MouseLeave(object sender, EventArgs e)
        {
            pbViewDelivery.Visible = false;
        }

        private void pbViewDelivery_Click(object sender, EventArgs e)
        {
            using (frm_View_Delivery delivery = new frm_View_Delivery())
            {
                delivery.ShowDialog();
            }
        }

        private void pbstocks_Click(object sender, EventArgs e)
        {
            using (frm_view_stocks stock = new frm_view_stocks())
            {
                stock.ShowDialog();
            }
        }

        private void pboxViewStocks_MouseHover(object sender, EventArgs e)
        {
            pbViewStocks.Visible = true;
        }

        private void pbstocks_MouseLeave(object sender, EventArgs e)
        {
            pbViewStocks.Visible = false;
        }

        private void pbCustomerDelivery_MouseLeave(object sender, EventArgs e)
        {
            pbCustomerDelivery.Visible = false;
        }

       
        private void pboxCustomerDelivery_MouseHover_1(object sender, EventArgs e)
        {
            pbCustomerDelivery.Visible = true;
        }

        private void pbCustomerDelivery_Click(object sender, EventArgs e)
        {
            using (frm_Customer_Delivery frmCustomerDelivery = new frm_Customer_Delivery())
            {
                frmCustomerDelivery.ShowDialog();
            }
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
            using (frm_View_Customer_Delivery frmViewCusDel = new frm_View_Customer_Delivery())
            {
                frmViewCusDel.ShowDialog();
            }
        }

        private void pboxDamagesAndReplacement_MouseHover(object sender, EventArgs e)
        {
            pbDamageAndReplacement.Visible = true;
        }

        private void pbDamageAndReplacement_MouseLeave(object sender, EventArgs e)
        {
            pbDamageAndReplacement.Visible = false;
        }

        private void pbDamageAndReplacement_Click(object sender, EventArgs e)
        {
            using (frm_DamagesAndReplacement frm = new frm_DamagesAndReplacement())
            {
                frm.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (frm_view_order_from_supplier ord = new frm_view_order_from_supplier())
            {
                ord.ShowDialog();
            }
        }

        private void pbviewordersupplier_Click(object sender, EventArgs e)
        {
            using (frm_view_order_from_supplier frm = new frm_view_order_from_supplier())
            {
                frm.ShowDialog();
            }

        }

        private void pboxViewOrderSupplier_MouseHover(object sender, EventArgs e)
        {
            pbviewordersupplier.Visible = true;
        }

        private void pbviewordersupplier_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pbviewordersupplier_MouseLeave(object sender, EventArgs e)
        {
            pbviewordersupplier.Visible = false;
        }

        private void pboxViewCustomerTransaction_MouseHover(object sender, EventArgs e)
        {
            pbViewCustomerTransaction.Visible = true;
        }

        private void pbViewCustomerTransaction_MouseLeave(object sender, EventArgs e)
        {
            pbViewCustomerTransaction.Visible = false;
        }

        private void pbViewCustomerTransaction_Click(object sender, EventArgs e)
        {
            using (frmViewCustomerTransaction custrans = new frmViewCustomerTransaction())
            {
                custrans.ShowDialog();
            }
        }

        private void pbinstallation_Click(object sender, EventArgs e)
        {
            using (frm_installation_customerService installation = new frm_installation_customerService())
            {
                installation.ShowDialog();
            }
        }

        private void wndw_Main_Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void pboxinstallation_MouseHover(object sender, EventArgs e)
        {
            pbinstallation.Visible = true;
        }

        private void pbinstallation_MouseLeave(object sender, EventArgs e)
        {
            pbinstallation.Visible = false;
        }

        private void pboxInventory_MouseHover(object sender, EventArgs e)
        {
            pbInventory.Visible = true;
        }

        private void pbInventory_MouseLeave(object sender, EventArgs e)
        {
            pbInventory.Visible = false;
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            frmViewUsers user = new frmViewUsers();
            user.Show();
        }

        private void pbInventory_Click(object sender, EventArgs e)
        {
            frm_Inventory_Report inventory = new frm_Inventory_Report();
            inventory.Show();
        }

        private void pboxcustomerdetails_MouseHover(object sender, EventArgs e)
        {
            pbcustomerdetails.Visible = true;
        }

        private void pbcustomerdetails_MouseLeave(object sender, EventArgs e)
        {
            pbcustomerdetails.Visible = false;
        }

        private void pbcustomerdetails_Click(object sender, EventArgs e)
        {
            using (frm_Customer_Details details = new frm_Customer_Details())
                details.ShowDialog();
        }

        private void pboxCustomerDelivery_Click(object sender, EventArgs e)
        {

        }

        private void pbuser_MouseLeave(object sender, EventArgs e)
        {
            pbuser.Visible = false;
        }

        private void pboxuser_MouseHover(object sender, EventArgs e)
        {
            pbuser.Visible = true;
        }

        private void pbuser_Click(object sender, EventArgs e)
        {
            gbUser.Visible = true;
            gbsupplier.Visible = false;
            gbcustomer.Visible = false;
            gbstocks.Visible = false;
            gbservices.Visible = false;
            gbreports.Visible = false;
        }

        private void pboxuser_Click(object sender, EventArgs e)
        {

        }

        private void pbsupplier_MouseLeave(object sender, EventArgs e)
        {
            pbsupplier.Visible = false;
        }

        private void pboxsupplier_MouseHover(object sender, EventArgs e)
        {
            pbsupplier.Visible = true;
        }

        private void pboxcustomer_MouseHover(object sender, EventArgs e)
        {
            pbcustomer.Visible = true;
        }

        private void pbcustomer_MouseLeave(object sender, EventArgs e)
        {
            pbcustomer.Visible = false;
        }

        private void pboxstocks_MouseHover(object sender, EventArgs e)
        {
            pbstocks.Visible = true;
        }

        private void pbstocks_MouseLeave_1(object sender, EventArgs e)
        {
            pbstocks.Visible = false;
        }

        private void pboxservices_MouseHover(object sender, EventArgs e)
        {
            pbservices.Visible = true;
        }

        private void pbservices_MouseLeave(object sender, EventArgs e)
        {
            pbservices.Visible = false;
        }

        private void pboxsales_MouseHover(object sender, EventArgs e)
        {
            pbsales.Visible = true;
        }

        private void pbsales_MouseLeave(object sender, EventArgs e)
        {
            pbsales.Visible = false;
        }

        private void pbsupplier_Click(object sender, EventArgs e)
        {
            gbUser.Visible = false;
            gbsupplier.Visible = true;
            gbcustomer.Visible = false;
            gbstocks.Visible = false;
            gbservices.Visible = false;
            gbreports.Visible = false;
        }

        private void pbsales_Click(object sender, EventArgs e)
        {
            gbUser.Visible = false;
            gbsupplier.Visible = false;
            gbcustomer.Visible = false;
            gbstocks.Visible = false;
            gbservices.Visible = false;
            gbreports.Visible = true;
        }

        private void pboxUserProfile_Click(object sender, EventArgs e)
        {

        }

        private void pboxviewuser_MouseHover(object sender, EventArgs e)
        {
            pbviewuser.Visible = true;
        }

        private void pbviewuser_MouseLeave(object sender, EventArgs e)
        {
            pbviewuser.Visible = false;
        }

        private void pboxViewDelivery_Click(object sender, EventArgs e)
        {

        }

        private void pboxDeliverysup_Click(object sender, EventArgs e)
        {

        }

        private void pboxSupplierTransaction_Click(object sender, EventArgs e)
        {

        }

        private void pboxcustomerdetails_Click(object sender, EventArgs e)
        {

        }

        private void pboxViewCustomerDelivery_Click(object sender, EventArgs e)
        {

        }

        private void pboxInventory_Click(object sender, EventArgs e)
        {

        }

        private void pboxSupplierDetails_Click(object sender, EventArgs e)
        {

        }

        private void gbsupplier_Enter(object sender, EventArgs e)
        {

        }

        private void pboxDamagesAndReplacement_Click(object sender, EventArgs e)
        {

        }


        private void pboxViewOrderSupplier_Click(object sender, EventArgs e)
        {

        }

        private void gbUser_Enter(object sender, EventArgs e)
        {

        }

        private void pbviewuser_Click(object sender, EventArgs e)
        {
            frmViewUsers user = new frmViewUsers();
            user.Show();
        }

        private void pboxCreateNewtaff_Click(object sender, EventArgs e)
        {

        }

        private void pboxviewuser_Click(object sender, EventArgs e)
        {

        }

        private void pboxViewCustomerTransaction_Click(object sender, EventArgs e)
        {

        }

        private void gbcustomer_Enter(object sender, EventArgs e)
        {

        }

        private void gbstocks_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pboxinstallation_Click(object sender, EventArgs e)
        {

        }

        private void gbservices_Enter(object sender, EventArgs e)
        {

        }

        private void gbreports_Enter(object sender, EventArgs e)
        {

        }

        private void pbcustomer_Click(object sender, EventArgs e)
        {
            gbUser.Visible = false;
            gbsupplier.Visible = false;
            gbcustomer.Visible = true;
            gbstocks.Visible = false;
            gbservices.Visible = false;
            gbreports.Visible = false;
        }

        private void pbstocks_Click_1(object sender, EventArgs e)
        {
            gbUser.Visible = false;
            gbsupplier.Visible = false;
            gbcustomer.Visible = false;
            gbstocks.Visible = true;
            gbservices.Visible = false;
            gbreports.Visible = false;
        }

        private void pbservices_Click(object sender, EventArgs e)
        {
            gbUser.Visible = false;
            gbsupplier.Visible = false;
            gbcustomer.Visible = false;
            gbstocks.Visible = false;
            gbservices.Visible = true;
            gbreports.Visible = false;
        }

        private void pboxViewStocks_Click(object sender, EventArgs e)
        {

        }

        private void pboxcustomer_Click(object sender, EventArgs e)
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

        private void pboxSalesReport_MouseHover(object sender, EventArgs e)
        {
            pbSalesReport.Visible = true;
        }

        private void pbSalesReport_MouseLeave(object sender, EventArgs e)
        {
            pbSalesReport.Visible = false;
        }

        private void pbSalesReport_Click(object sender, EventArgs e)
        {
            frmSales_Report sales = new frmSales_Report();
            sales.Show();
        }

        private void pboxVstock_MouseHover(object sender, EventArgs e)
        {
            pbVstock.Visible = true;
        }

        private void pbVstock_MouseLeave(object sender, EventArgs e)
        {
            pbVstock.Visible = false;
        }

        private void pbVstock_Click(object sender, EventArgs e)
        {
            using (frmViewStockforStaffForm stock = new frmViewStockforStaffForm())
            {
                stock.ShowDialog();
            }
        }

        private void pboxSalesReport_Click(object sender, EventArgs e)
        {

        }

   






 

        

       
      
        
    }
}
