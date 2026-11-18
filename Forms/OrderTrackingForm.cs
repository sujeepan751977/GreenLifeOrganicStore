using System;
using System.Linq;
using System.Windows.Forms;
using GreenLifeOrganicStore.Services;

namespace GreenLifeOrganicStore.Forms
{

    public partial class OrderTrackingForm : Form
    {

        private OrderService _orderService = new OrderService();

        private ExportService _exportService = new ExportService();

        public OrderTrackingForm()
        {
            InitializeComponent();
            // Auto-migrated UI styling from Designer
            this.pnlHeader.BackColor = GreenLifeOrganicStore.Utils.UIHelper.PrimaryColor;
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnExport, true);
            Utils.UIHelper.StyleForm(this);
            Utils.UIHelper.StyleDataGrid(dgvOrders);
            LoadOrders();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void LoadOrders()
        {
            var orders = _orderService.GetCustomerOrders(Session.CurrentCustomer.Id);
            dgvOrders.DataSource = orders.Select(o => new {
                o.OrderId,
                o.OrderDate,
                o.GrandTotal,
                o.Status
            }).ToList();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var orders = _orderService.GetCustomerOrders(Session.CurrentCustomer.Id);
            SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV File|.csv", FileName = "MyOrderHistory.csv" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _exportService.ExportCustomerOrderHistoryToCsv(Session.CurrentCustomer.FullName, orders, sfd.FileName);
                MessageBox.Show("History exported!", "Success");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
