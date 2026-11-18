namespace GreenLifeOrganicStore.Forms
{
    partial class ReportsForm
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabControl;

        private System.Windows.Forms.TabPage tabSales;

        private System.Windows.Forms.TabPage tabStock;

        private System.Windows.Forms.TabPage tabCustomer;

        private System.Windows.Forms.Label lblTotalSales;

        private System.Windows.Forms.Label lblTotalOrders;

        private System.Windows.Forms.DataGridView dgvSalesByDay;

        private System.Windows.Forms.DataGridView dgvStockReport;

        private System.Windows.Forms.ComboBox cmbCustomers;

        private System.Windows.Forms.Button btnExportHistory;

        private System.Windows.Forms.Label lblSelectCustomer;

        private System.Windows.Forms.Panel pnlHeader;

        private System.Windows.Forms.Label lblHeader;

        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.Panel pnlContent;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.dgvSalesByDay = new System.Windows.Forms.DataGridView();
            this.dgvStockReport = new System.Windows.Forms.DataGridView();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.btnExportHistory = new System.Windows.Forms.Button();
            this.lblSelectCustomer = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tabControl.SuspendLayout();
            this.tabSales.SuspendLayout();
            this.tabStock.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesByDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockReport)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // pnlHeader
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(900, 60);
            // lblHeader
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(80, 15);
            this.lblHeader.Size = new System.Drawing.Size(400, 30);
            this.lblHeader.Text = "Business Insights";
            // btnBack
            this.btnBack.Text = " Back";
            this.btnBack.Location = new System.Drawing.Point(10, 12);
            this.btnBack.Size = new System.Drawing.Size(60, 35);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // Content Panel
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Controls.Add(this.tabControl);
            this.pnlContent.Location = new System.Drawing.Point(0, 60);
            this.pnlContent.Padding = new System.Windows.Forms.Padding(10);
            this.pnlContent.Size = new System.Drawing.Size(900, 440);
            this.tabControl.Controls.Add(this.tabSales);
            this.tabControl.Controls.Add(this.tabStock);
            this.tabControl.Controls.Add(this.tabCustomer);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            // Sales Tab
            this.lblTotalSales.Location = new System.Drawing.Point(20, 25);
            this.lblTotalSales.Size = new System.Drawing.Size(400, 30);
            this.lblTotalSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalOrders.Location = new System.Drawing.Point(20, 60);
            this.lblTotalOrders.Size = new System.Drawing.Size(400, 25);
            this.lblTotalOrders.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvSalesByDay.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalesByDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalesByDay.Location = new System.Drawing.Point(20, 100);
            this.dgvSalesByDay.Size = new System.Drawing.Size(820, 250);
            this.tabSales.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTotalSales, this.lblTotalOrders, this.dgvSalesByDay });
            this.tabSales.Text = "Sales Performance";
            // Stock Tab
            this.dgvStockReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStockReport.Location = new System.Drawing.Point(20, 20);
            this.dgvStockReport.Size = new System.Drawing.Size(820, 330);
            this.tabStock.Controls.Add(this.dgvStockReport);
            this.tabStock.Text = "Inventory Status";
            // Customer Tab
            this.lblSelectCustomer.Text = "View Activity for:";
            this.lblSelectCustomer.Location = new System.Drawing.Point(30, 40);
            this.lblSelectCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            
            this.cmbCustomers.Location = new System.Drawing.Point(180, 38);
            this.cmbCustomers.Size = new System.Drawing.Size(250, 28);
            this.cmbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExportHistory.Text = "Download History (CSV)";
            this.btnExportHistory.Location = new System.Drawing.Point(180, 85);
            this.btnExportHistory.Size = new System.Drawing.Size(250, 45);
            this.btnExportHistory.Click += new System.EventHandler(this.btnExportHistory_Click);
            this.tabCustomer.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblSelectCustomer, this.cmbCustomers, this.btnExportHistory });
            this.tabCustomer.Text = "Customer Intelligence";
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tabControl.ResumeLayout(false);
            this.tabSales.ResumeLayout(false);
            this.tabStock.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesByDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockReport)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
