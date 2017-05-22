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
    public partial class frm_Inventory_Report : Form
    {
        public frm_Inventory_Report()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.Text == "Stocks Available")
            {
                lblFromDate.Visible = false;
                dtpFromDate.Visible = false;
                lblToDate.Visible = false;
                dtpToDate.Visible = false;
            }
            else
            {
                lblFromDate.Visible = true;
                dtpFromDate.Visible = true;
                lblToDate.Visible = true;
                dtpToDate.Visible = true;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string Name;
            Name = Form1.name.ToString();
            if (cmbCategory.Text == "Stocks Available")
            {
                btnLoad.Text = "Loading...";
                var da = new Miletec_Sales_and_Inventory.DS_InventoryTableAdapters.tblStocksTableAdapter();
                var dt = new Miletec_Sales_and_Inventory.DS_Inventory.tblStocksDataTable();
                da.FillStocksAvailable(dt, Name);

                var ds = new DataSet();
                ds.Tables.Add(dt);

                var crystal = new CRStocksAvailable();
                crystal.SetDataSource(ds);

                cptStocksAvailable.ReportSource = crystal;
                cptStocksAvailable.RefreshReport();
                btnLoad.Text = "Load";
            }
            else if (cmbCategory.Text == "Damages")
            {
                btnLoad.Text = "Loading...";
                var da = new Miletec_Sales_and_Inventory.DS_InventoryTableAdapters.tblDamagesAndReplacementsTableAdapter();
                var dt = new Miletec_Sales_and_Inventory.DS_Inventory.tblDamagesAndReplacementsDataTable();
                da.FillDamages(dt, dtpFromDate.Value, dtpToDate.Value, Name);

                var ds = new DataSet();
                ds.Tables.Add(dt);

                var damage = new CRDamages();
                damage.SetDataSource(ds);

                cptStocksAvailable.ReportSource = damage;
                cptStocksAvailable.RefreshReport();
                btnLoad.Text = "Load";
            }
            else if(cmbCategory.Text == "New Stocks Arrived")
            {
                btnLoad.Text = "Loading...";
                var da = new Miletec_Sales_and_Inventory.DS_InventoryTableAdapters.tblDeliveryDetailsTableAdapter();
                var dt = new Miletec_Sales_and_Inventory.DS_Inventory.tblDeliveryDetailsDataTable();
                da.FillDeliveredItems(dt, dtpFromDate.Value, dtpToDate.Value, Name);

                var ds = new DataSet();
                ds.Tables.Add(dt);

                var rpt = new CSDeliveredItems();
                rpt.SetDataSource(ds);

                cptStocksAvailable.ReportSource = rpt;
                cptStocksAvailable.RefreshReport();
                btnLoad.Text = "Load";
            }
        }

       
    }
}
