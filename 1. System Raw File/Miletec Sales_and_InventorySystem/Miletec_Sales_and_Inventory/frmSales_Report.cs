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
    public partial class frmSales_Report : Form
    {
        public frmSales_Report()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string Name;
            Name = Form1.name.ToString();
            btnLoad.Text = "Loading...";
            var da = new Miletec_Sales_and_Inventory.DS_SalesTableAdapters.tblcustomertrans_details1TableAdapter();
            var dt = new Miletec_Sales_and_Inventory.DS_Sales.tblcustomertrans_details1DataTable();
            da.FillSTSales(dt, dtpFromDate.Value, dtpToDate.Value, Name);

            var ds = new DataSet();
            ds.Tables.Add(dt);

            var crystal = new CrystalReportST_Sales();
            crystal.SetDataSource(ds);

            cptSalesReport.ReportSource = crystal;
            cptSalesReport.RefreshReport();
            btnLoad.Text = "Load"; 
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
