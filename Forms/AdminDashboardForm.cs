using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using GreenLifeOrganicStore.Services;

namespace GreenLifeOrganicStore.Forms
{

    public partial class AdminDashboardForm : Form
    {

        private ProductService _productService = new ProductService();

        private ReportService _reportService = new ReportService();

        private OrderService _orderService = new OrderService();

        public AdminDashboardForm()
        {
            InitializeComponent();
            StyleDashboard();
            LoadData();
        }

        private void StyleDashboard()
        {
            this.pnlSidebar.BackColor = Utils.UIHelper.PrimaryColor;
            this.pnlSidebar.Paint += (s, e) => Utils.UIHelper.DrawGradientBackground(this.pnlSidebar, e.Graphics);
            
            this.lblLogo.ForeColor = Utils.UIHelper.AccentColor;
            
            Utils.UIHelper.StyleDashboardButton(this.btnDashboard, "Dashboard");
            Utils.UIHelper.StyleDashboardButton(this.btnProductMgmt, "Products");
            Utils.UIHelper.StyleDashboardButton(this.btnCustomerMgmt, "Customers");
            Utils.UIHelper.StyleDashboardButton(this.btnOrderMgmt, "Orders");
            Utils.UIHelper.StyleDashboardButton(this.btnReports, "Analytics");
            
            Utils.UIHelper.StyleLogoutButton(this.btnLogout);
            
            this.lblWelcome.ForeColor = Utils.UIHelper.PrimaryColor;
            
            Utils.UIHelper.CreateMetricCard(this.pnlCard1, this.lblStatTitle1, this.lblTotalSales, Utils.UIHelper.AccentColor);
            Utils.UIHelper.CreateMetricCard(this.pnlCard2, this.lblStatTitle2, this.lblTotalProducts, Utils.UIHelper.SecondaryColor);
            Utils.UIHelper.CreateMetricCard(this.pnlCard3, this.lblStatTitle3, this.lblActiveOrders, Color.IndianRed);
            
            lblStatTitle1.Parent = pnlCard1; lblTotalSales.Parent = pnlCard1;
            lblStatTitle2.Parent = pnlCard2; lblTotalProducts.Parent = pnlCard2;
            lblStatTitle3.Parent = pnlCard3; lblActiveOrders.Parent = pnlCard3;
            Utils.UIHelper.StyleGroupBox(this.grpLowStock);
            this.BackColor = Utils.UIHelper.BackgroundColor;
        }

        private void LoadData()
        {
            lblWelcome.Text = "Welcome, " + (Session.CurrentAdmin?.FullName ?? "System");
            LoadDashboardStats();
            LoadLowStockNotifications();
        }

        private void LoadDashboardStats()
        {
            try {
                lblTotalSales.Text = Utils.UIHelper.FormatCurrency(_reportService.GetTotalSales());
                lblTotalProducts.Text = _productService.GetAllProducts().Count.ToString();
                lblActiveOrders.Text = _orderService.GetAllOrders().Count(o => o.Status == Models.OrderStatus.Pending).ToString();
            } catch { }
        }

        private void LoadLowStockNotifications()
        {
            try {
                var lowStock = _productService.GetLowStock(10);
                lstLowStock.Items.Clear();
                foreach (var p in lowStock) {
                    lstLowStock.Items.Add(p.Name + " (Stock: " + p.Stock + ")");
                }
                lblLowStockCount.Text = "Low Stock Items: " + lowStock.Count;
                lblLowStockCount.ForeColor = lowStock.Count > 0 ? Color.Red : Color.Black;
            } catch { }
        }

        private void LoadChildForm(Form childForm)
        {
            pnlContent.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnProductMgmt_Click(object sender, EventArgs e)
        {
            var f = new ProductManagementForm();
            f.FormClosed += (s, args) => { LoadDashboardStats(); LoadLowStockNotifications(); };
            LoadChildForm(f);
        }

        private void btnCustomerMgmt_Click(object sender, EventArgs e) => LoadChildForm(new CustomerManagementForm());

        private void btnOrderMgmt_Click(object sender, EventArgs e) => LoadChildForm(new OrderManagementForm());

        private void btnReports_Click(object sender, EventArgs e) => LoadChildForm(new ReportsForm());
        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(grpLowStock);
            LoadDashboardStats();
            LoadLowStockNotifications();
        }
    }
}
