namespace Miletec_Sales_and_Inventory
{
    partial class frm_Installation_Receipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crtInstallationreceipt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crtInstallationreceipt
            // 
            this.crtInstallationreceipt.ActiveViewIndex = -1;
            this.crtInstallationreceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtInstallationreceipt.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtInstallationreceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtInstallationreceipt.Location = new System.Drawing.Point(0, 0);
            this.crtInstallationreceipt.Name = "crtInstallationreceipt";
            this.crtInstallationreceipt.Size = new System.Drawing.Size(588, 448);
            this.crtInstallationreceipt.TabIndex = 0;
            this.crtInstallationreceipt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Installation_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 448);
            this.Controls.Add(this.crtInstallationreceipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Installation_Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Installation_Receipt";
            this.Load += new System.EventHandler(this.frm_Installation_Receipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crtInstallationreceipt;
    }
}