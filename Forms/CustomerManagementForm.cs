using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Repositories;
using GreenLifeOrganicStore.Services;

namespace GreenLifeOrganicStore.Forms
{

    public partial class CustomerManagementForm : Form
    {

        private IRepository<Customer> _customerRepo = new SqlRepository<Customer>("Customers");

        private OrderService _orderService = new OrderService();

        private Customer _selectedCustomer = null;

        public CustomerManagementForm()
        {
            InitializeComponent();
            // Auto-migrated UI styling from Designer
            this.pnlHeader.BackColor = GreenLifeOrganicStore.Utils.UIHelper.PrimaryColor;
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblFullName);
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblPhone);
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblAddress);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnSave, true);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnViewHistory, false);
            Utils.UIHelper.StyleForm(this);
            Utils.UIHelper.StyleDataGrid(dgvCustomers);
            Utils.UIHelper.StyleTextBox(txtFullName);
            Utils.UIHelper.StyleTextBox(txtPhone);
            Utils.UIHelper.StyleTextBox(txtAddress);
            LoadCustomers();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void LoadCustomers()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = _customerRepo.GetAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer == null) return;
            _selectedCustomer.FullName = txtFullName.Text.Trim();
            _selectedCustomer.Phone = txtPhone.Text.Trim();
            _selectedCustomer.Address = txtAddress.Text.Trim();
            _customerRepo.Update(_selectedCustomer);
            MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCustomers();
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer != null)
            {
                var orders = _orderService.GetCustomerOrders(_selectedCustomer.Id);
                string history = string.Join("\n", orders.Select(o => $"Order: {o.OrderId.Substring(0, 8)} | Date: {o.OrderDate.ToShortDateString()} | Total: {Utils.UIHelper.FormatCurrency(o.GrandTotal)} | Status: {o.Status}"));
                MessageBox.Show(history == "" ? "No order history found." : history, $"Order History - {_selectedCustomer.FullName}");
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvCustomers.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                _selectedCustomer = _customerRepo.GetById(id);
                if (_selectedCustomer != null)
                {
                    txtFullName.Text = _selectedCustomer.FullName;
                    txtPhone.Text = _selectedCustomer.Phone;
                    txtAddress.Text = _selectedCustomer.Address;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
