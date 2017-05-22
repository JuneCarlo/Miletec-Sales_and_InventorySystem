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
    public partial class frm_Installation_Receipt : Form
    {
        public frm_Installation_Receipt()
        {
            InitializeComponent();
        }
        public static string TransactionID;
        private void frm_Installation_Receipt_Load(object sender, EventArgs e)
        {
            TransactionID = frm_CustomerTransaction.TransactionID.ToString();
            var da = new Miletec_Sales_and_Inventory.DS_ReceiptTableAdapters.tblinstallationTableAdapter();
            var dt = new Miletec_Sales_and_Inventory.DS_Receipt.tblinstallationDataTable();
            da.FillInstallationReceipt(dt, TransactionID);

            var ds = new DataSet();
            ds.Tables.Add(dt);

            var receipt = new CR_InstallationReceipt();
            receipt.SetDataSource(ds);

            crtInstallationreceipt.ReportSource = receipt;
            crtInstallationreceipt.RefreshReport();

        }
    }
}
