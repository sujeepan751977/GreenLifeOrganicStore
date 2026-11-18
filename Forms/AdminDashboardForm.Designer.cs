namespace GreenLifeOrganicStore.Forms
{
    partial class AdminDashboardForm
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblWelcome;

        private System.Windows.Forms.Button btnProductMgmt;

        private System.Windows.Forms.Button btnCustomerMgmt;

        private System.Windows.Forms.Button btnOrderMgmt;

        private System.Windows.Forms.Button btnReports;

        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.GroupBox grpLowStock;

        private System.Windows.Forms.ListBox lstLowStock;

        private System.Windows.Forms.Label lblLowStockCount;

        private System.Windows.Forms.Button btnDashboard;

        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.Panel pnlCard1;

        private System.Windows.Forms.Panel pnlCard2;

        private System.Windows.Forms.Panel pnlCard3;

        private System.Windows.Forms.Label lblStatTitle1;

        private System.Windows.Forms.Label lblStatTitle2;

        private System.Windows.Forms.Label lblStatTitle3;

        private System.Windows.Forms.Label lblTotalSales;

        private System.Windows.Forms.Label lblTotalProducts;

        private System.Windows.Forms.Label lblActiveOrders;

        private System.Windows.Forms.Panel pnlSidebar;

        private System.Windows.Forms.Panel pnlTop;

        private System.Windows.Forms.Label lblLogo;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnProductMgmt = new System.Windows.Forms.Button();
            this.btnCustomerMgmt = new System.Windows.Forms.Button();
            this.btnOrderMgmt = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpLowStock = new System.Windows.Forms.GroupBox();
            this.lstLowStock = new System.Windows.Forms.ListBox();
            this.lblLowStockCount = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.lblActiveOrders = new System.Windows.Forms.Label();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblStatTitle1 = new System.Windows.Forms.Label();
            this.lblStatTitle2 = new System.Windows.Forms.Label();
            this.lblStatTitle3 = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.grpLowStock.SuspendLayout();
            this.SuspendLayout();
            // pnlSidebar
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.btnProductMgmt);
            this.pnlSidebar.Controls.Add(this.btnCustomerMgmt);
            this.pnlSidebar.Controls.Add(this.btnOrderMgmt);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Size = new System.Drawing.Size(260, 800);
            // lblLogo
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblLogo.Location = new System.Drawing.Point(0, 20);
            this.lblLogo.Size = new System.Drawing.Size(260, 80);
            this.lblLogo.Text = "GreenLife";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // Buttons in Sidebar
            this.btnDashboard.Location = new System.Drawing.Point(10, 100);
            this.btnDashboard.Size = new System.Drawing.Size(240, 45);
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnProductMgmt.Location = new System.Drawing.Point(10, 100 + (45 + 10));
            this.btnProductMgmt.Size = new System.Drawing.Size(240, 45);
            this.btnProductMgmt.Text = "Products";
            this.btnProductMgmt.Click += new System.EventHandler(this.btnProductMgmt_Click);
            this.btnCustomerMgmt.Location = new System.Drawing.Point(10, 210);
            this.btnCustomerMgmt.Size = new System.Drawing.Size(240, 45);
            this.btnCustomerMgmt.Text = "Customers";
            this.btnCustomerMgmt.Click += new System.EventHandler(this.btnCustomerMgmt_Click);
            this.btnOrderMgmt.Location = new System.Drawing.Point(10, 265);
            this.btnOrderMgmt.Size = new System.Drawing.Size(240, 45);
            this.btnOrderMgmt.Text = "Orders";
            this.btnOrderMgmt.Click += new System.EventHandler(this.btnOrderMgmt_Click);
            this.btnReports.Location = new System.Drawing.Point(10, 320);
            this.btnReports.Size = new System.Drawing.Size(240, 45);
            this.btnReports.Text = "Analytics";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Size = new System.Drawing.Size(260, 50);
            this.btnLogout.Text = "Logout";
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 80, 65);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // pnlTop/Cards
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(245, 247, 245);
            this.pnlTop.Controls.Add(this.lblWelcome);
            this.pnlTop.Controls.Add(this.pnlCard1);
            this.pnlTop.Controls.Add(this.pnlCard2);
            this.pnlTop.Controls.Add(this.pnlCard3);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(260, 0);
            this.pnlTop.Size = new System.Drawing.Size(940, 180);
            // lblWelcome
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(25, 15);
            this.lblWelcome.Size = new System.Drawing.Size(400, 35);
            this.lblWelcome.Text = "Operations Management";
            
            // Card 1: Revenue
            this.pnlCard1.Location = new System.Drawing.Point(30, 65);
            this.pnlCard1.Size = new System.Drawing.Size(280, 110);
            this.lblStatTitle1.Text = "TOTAL REVENUE";
            this.pnlCard1.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblStatTitle1, this.lblTotalSales });
            // Card 2: Inventory
            this.pnlCard2.Location = new System.Drawing.Point(330, 65);
            this.pnlCard2.Size = new System.Drawing.Size(280, 110);
            this.lblStatTitle2.Text = "ACTIVE PRODUCTS";
            this.pnlCard2.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblStatTitle2, this.lblTotalProducts });
            // Card 3: Orders
            this.pnlCard3.Location = new System.Drawing.Point(630, 65);
            this.pnlCard3.Size = new System.Drawing.Size(280, 110);
            this.lblStatTitle3.Text = "PENDING ORDERS";
            this.pnlCard3.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblStatTitle3, this.lblActiveOrders });
            // grpLowStock
            this.grpLowStock.Text = "Inventory Alerts";
            this.grpLowStock.Location = new System.Drawing.Point(30, 20); // Relative to pnlContent
            this.grpLowStock.Size = new System.Drawing.Size(600, 580);
            this.grpLowStock.Controls.Add(this.lstLowStock);
            this.grpLowStock.Controls.Add(this.lblLowStockCount);
            this.lstLowStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLowStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstLowStock.Location = new System.Drawing.Point(20, 40);
            this.lstLowStock.Size = new System.Drawing.Size(540, 480);
            this.lblLowStockCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLowStockCount.Location = new System.Drawing.Point(20, 540);
            this.lblLowStockCount.Size = new System.Drawing.Size(300, 25);
            // pnlContent
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(260, 180);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(940, 620);
            this.pnlContent.Controls.Add(this.grpLowStock);
            // AdminDashboardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.grpLowStock.ResumeLayout(false);
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard3.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
