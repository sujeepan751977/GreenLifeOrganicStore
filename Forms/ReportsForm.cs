using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Repositories;
using GreenLifeOrganicStore.Services;

namespace GreenLifeOrganicStore.Forms
{

    public partial class ReportsForm : Form
    {

        private IReportService _reportService = new ReportService();

        private ExportService _exportService = new ExportService();

        private IRepository<Customer> _customerRepo = new SqlRepository<Customer>("Customers");

        public ReportsForm()
        {
            InitializeComponent();
            // Auto-migrated UI styling from Designer
            this.pnlHeader.BackColor = GreenLifeOrganicStore.Utils.UIHelper.PrimaryColor;
            this.lblTotalSales.ForeColor = GreenLifeOrganicStore.Utils.UIHelper.PrimaryColor;
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnExportHistory, true);
            Utils.UIHelper.StyleForm(this);
            Utils.UIHelper.StyleDataGrid(dgvSalesByDay);
            Utils.UIHelper.StyleDataGrid(dgvStockReport);
            Utils.UIHelper.StyleComboBox(cmbCustomers);
            Utils.UIHelper.StyleLabel(lblSelectCustomer);
            Utils.UIHelper.StyleLabel(lblTotalSales);
            Utils.UIHelper.StyleLabel(lblTotalOrders);
            
            LoadSalesReport();
            LoadStockReport();
            cmbCustomers.DataSource = _customerRepo.GetAll();
            cmbCustomers.DisplayMember = "FullName";
            cmbCustomers.ValueMember = "Id";
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void LoadSalesReport()
        {
            lblTotalSales.Text = $"Total Sales: {Utils.UIHelper.FormatCurrency(_reportService.GetTotalSales())}";
            lblTotalOrders.Text = $"Total Orders: {_reportService.GetTotalOrders()}";
            dgvSalesByDay.DataSource = _reportService.GetSalesByDay().Select(x => new { Date = x.Key, Amount = Utils.UIHelper.FormatCurrency(x.Value) }).ToList();
        }

        private void LoadStockReport()
        {
            dgvStockReport.DataSource = _reportService.GetStockReport().Select(p => new {
                p.Name,
                p.Category,
                p.Stock,
                p.Supplier,
                Status = p.Stock <= 10 ? "Low Stock" : "OK"
            }).ToList();
        }

        private void btnExportHistory_Click(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedItem is Customer customer)
            {
                this.Cursor = Cursors.WaitCursor;
                try
                {
                    var orders = _reportService.GetCustomerOrderHistory(customer.Id);
                    SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV File|.csv", FileName = $"{customer.FullName}_History.csv" };
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        _exportService.ExportCustomerOrderHistoryToCsv(customer.FullName, orders, sfd.FileName);
                        MessageBox.Show("Exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Report Generation Failed: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
