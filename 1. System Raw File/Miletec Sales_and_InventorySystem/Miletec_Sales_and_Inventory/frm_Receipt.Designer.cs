namespace Miletec_Sales_and_Inventory
{
    partial class frm_Receipt
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
            this.crReceipt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crReceipt
            // 
            this.crReceipt.ActiveViewIndex = -1;
            this.crReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crReceipt.Cursor = System.Windows.Forms.Cursors.Default;
            this.crReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crReceipt.Location = new System.Drawing.Point(0, 0);
            this.crReceipt.Name = "crReceipt";
            this.crReceipt.Size = new System.Drawing.Size(745, 477);
            this.crReceipt.TabIndex = 0;
            this.crReceipt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 477);
            this.Controls.Add(this.crReceipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Receipt";
            this.Load += new System.EventHandler(this.frm_Receipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crReceipt;
    }
}