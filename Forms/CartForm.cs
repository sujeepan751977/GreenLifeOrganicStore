using System;
using System.Linq;
using System.Windows.Forms;
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Services;

namespace GreenLifeOrganicStore.Forms
{

    public partial class CartForm : Form
    {

        private OrderService _orderService = new OrderService();

        public CartForm()
        {
            InitializeComponent();
            // Auto-migrated UI styling from Designer
            this.pnlHeader.BackColor = GreenLifeOrganicStore.Utils.UIHelper.PrimaryColor;
            this.lblTotal.ForeColor = GreenLifeOrganicStore.Utils.UIHelper.PrimaryColor;
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnRemove, false);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnPlaceOrder, true);
            LoadCart();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void LoadCart()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = ProductBrowseForm.Cart.Select(i => new {
                i.ProductId,
                i.ProductNameSnapshot,
                i.UnitPriceSnapshot,
                i.Quantity,
                i.LineTotal
            }).ToList();
            decimal subtotal = ProductBrowseForm.Cart.Sum(i => i.LineTotal);
            lblTotal.Text = $"Total: {Utils.UIHelper.FormatCurrency(subtotal)}";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                string id = dgvCart.SelectedRows[0].Cells["ProductId"].Value.ToString();
                var item = ProductBrowseForm.Cart.First(i => i.ProductId == id);
                ProductBrowseForm.Cart.Remove(item);
                LoadCart();
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (!ProductBrowseForm.Cart.Any()) return;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string error = _orderService.PlaceOrder(Session.CurrentCustomer.Id, ProductBrowseForm.Cart.ToList());
                if (error == null)
                {
                    MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ProductBrowseForm.Cart.Clear();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(error, "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Checkout Process Error: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
