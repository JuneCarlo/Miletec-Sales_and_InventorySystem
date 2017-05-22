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
    public partial class frm_Receipt : Form
    {
        public frm_Receipt()
        {
            InitializeComponent();
        }
        public string TransactionID,PrintedBy;
        private void frm_Receipt_Load(object sender, EventArgs e)
        {
                TransactionID = frm_CustomerTransaction.TransactionID.ToString();
                PrintedBy = Form1.name.ToString();
                var da = new Miletec_Sales_and_Inventory.DS_ReceiptTableAdapters.DataTable4TableAdapter();
                var dt = new Miletec_Sales_and_Inventory.DS_Receipt.DataTable4DataTable();
                da.FillTestReceipt(dt,PrintedBy,TransactionID);

                var ds = new DataSet();
                ds.Tables.Add(dt);

                var receipt = new CrystalReportST_Receipt();
                receipt.SetDataSource(ds);

                crReceipt.ReportSource = receipt;
                crReceipt.RefreshReport();
        }
    }
}
