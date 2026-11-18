using System;
using System.Linq;
using System.Windows.Forms;
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Services;

namespace GreenLifeOrganicStore.Forms
{

    public partial class OrderManagementForm : Form
    {

        private OrderService _orderService = new OrderService();

        private ExportService _exportService = new ExportService();

        private Order _selectedOrder = null;

        public OrderManagementForm()
        {
            InitializeComponent();
            // Auto-migrated UI styling from Designer
            this.pnlHeader.BackColor = GreenLifeOrganicStore.Utils.UIHelper.PrimaryColor;
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblOrders);
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblItems);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnUpdateStatus, true);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnExportCsv, true);
            Utils.UIHelper.StyleForm(this);
            Utils.UIHelper.StyleDataGrid(dgvOrders);
            Utils.UIHelper.StyleDataGrid(dgvItems);
            Utils.UIHelper.StyleComboBox(cmbStatus);
            Utils.UIHelper.StyleLabel(lblOrders);
            Utils.UIHelper.StyleLabel(lblItems);
            
            LoadOrders();
            cmbStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void LoadOrders()
        {
            var orders = _orderService.GetAllOrders();
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = orders.Select(o => new {
                o.OrderId,
                o.OrderDate,
                Total = Utils.UIHelper.FormatCurrency(o.GrandTotal),
                o.Status
            }).ToList();
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvOrders.Rows[e.RowIndex].Cells["OrderId"].Value.ToString();
                _selectedOrder = _orderService.GetAllOrders().FirstOrDefault(o => o.OrderId == id);
                if (_selectedOrder != null)
                {
                    cmbStatus.SelectedItem = _selectedOrder.Status;
                    dgvItems.DataSource = _selectedOrder.Items.Select(i => new {
                        i.ProductNameSnapshot,
                        Price = Utils.UIHelper.FormatCurrency(i.UnitPriceSnapshot),
                        i.Quantity,
                        Total = Utils.UIHelper.FormatCurrency(i.LineTotal)
                    }).ToList();
                }
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (_selectedOrder != null)
            {
                var status = (OrderStatus)cmbStatus.SelectedItem;
                _orderService.UpdateOrderStatus(_selectedOrder.OrderId, status);
                MessageBox.Show("Order status updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadOrders();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            var orders = _orderService.GetOrdersByDateRange(dtpStart.Value, dtpEnd.Value);
            
            if (orders == null || orders.Count == 0)
            {
                MessageBox.Show("No orders found in the selected date range.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (.csv)|.csv";
                sfd.FileName = $"OrderHistory_{dtpStart.Value:yyyyMMdd}_to_{dtpEnd.Value:yyyyMMdd}.csv";
                
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _exportService.ExportOrdersToCsv(orders, sfd.FileName);
                        MessageBox.Show("Order History exported successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Export failed: {ex.Message}");
                    }
                }
            }
        }
    }
}
