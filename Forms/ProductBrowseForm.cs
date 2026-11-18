using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Services;

namespace GreenLifeOrganicStore.Forms
{

    public partial class ProductBrowseForm : Form
    {

        private ProductService _productService = new ProductService();

        private ReviewService _reviewService = new ReviewService();

        private static List<OrderItem> _cart = new List<OrderItem>(); // In-memory cart for session

        public static List<OrderItem> Cart => _cart;

        public ProductBrowseForm()
        {
            InitializeComponent();
            // Auto-migrated UI styling from Designer
            this.pnlHeader.BackColor = GreenLifeOrganicStore.Utils.UIHelper.PrimaryColor;
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnSearch, true);
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblQty);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnAddToCart, true);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnAddReview, false);
            this.BackColor = GreenLifeOrganicStore.Utils.UIHelper.BackgroundColor;
            Utils.UIHelper.StyleForm(this);
            Utils.UIHelper.StyleDataGrid(dgvProducts);
            Utils.UIHelper.StyleTextBox(txtSearch);
            Utils.UIHelper.StyleNumeric(nudQuantity);
            Utils.UIHelper.StyleNumeric(nudMinPrice);
            Utils.UIHelper.StyleNumeric(nudMaxPrice);
            Utils.UIHelper.StyleComboBox(cmbCategory);
            Utils.UIHelper.StyleComboBox(cmbSort);
            
            var categories = _productService.GetAllProducts().Select(p => p.Category).Distinct().ToList();
            categories.Insert(0, "All");
            cmbCategory.DataSource = categories;
            cmbSort.Items.AddRange(new string[] { " Newest First", " Price: Low to High", " Price: High to Low", " Top Rated" });
            cmbSort.SelectedIndex = 0;
            LoadProducts();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void LoadProducts()
        {
            var products = _productService.SearchProducts(
                txtSearch.Text, 
                cmbCategory.SelectedItem?.ToString(), 
                nudMinPrice.Value, 
                nudMaxPrice.Value
            );
            // Apply Sorting
            switch (cmbSort.SelectedItem?.ToString())
            {
                case " Price: Low to High":
                    products = products.OrderBy(p => p.Price).ToList();
                    break;
                case " Price: High to Low":
                    products = products.OrderByDescending(p => p.Price).ToList();
                    break;
                case " Top Rated":
                    products = products.OrderByDescending(p => _reviewService.GetAverageRating(p.ProductId)).ToList();
                    break;
                default: // Newest
                    // Assuming GUIDs aren't chronological, but in a real app we'd have CreatedAt. 
                    // For now, we'll just use the default list order.
                    break;
            }
            if (products == null || !products.Any())
            {
                dgvProducts.DataSource = null;
                return;
            }

            dgvProducts.DataSource = products.Where(p => p.IsActive).Select(p => new {
                p.ProductId,
                p.Name,
                p.Category,
                Price = Utils.UIHelper.FormatCurrency(p.Price),
                Discount = p.DiscountPercent > 0 ? $"{p.DiscountPercent}%" : "None",
                Stock = p.Stock > 0 ? p.Stock.ToString() : "Out of Stock",
                Rating = _reviewService.GetAverageRating(p.ProductId)
            }).ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e) => LoadProducts();

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                string id = dgvProducts.SelectedRows[0].Cells["ProductId"].Value.ToString();
                var product = _productService.GetAllProducts().First(p => p.ProductId == id);
                int qty = (int)nudQuantity.Value;
                if (qty <= 0) return;
                if (product.Stock < qty)
                {
                    MessageBox.Show("Insufficient stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var existing = _cart.FirstOrDefault(i => i.ProductId == id);
                if (existing != null)
                {
                    existing.Quantity += qty;
                }
                else
                {
                    _cart.Add(new OrderItem {
                        ProductId = product.ProductId,
                        ProductNameSnapshot = product.Name,
                        UnitPriceSnapshot = product.Price * (1 - (product.DiscountPercent / 100m)),
                        Quantity = qty
                    });
                }
                MessageBox.Show($"{product.Name} added to cart!", "Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                string id = dgvProducts.SelectedRows[0].Cells["ProductId"].Value.ToString();
                string name = dgvProducts.SelectedRows[0].Cells["Name"].Value.ToString();
                
                var product = _productService.GetAllProducts().First(p => p.ProductId == id);
                var reviewForm = new ReviewForm(product);
                reviewForm.ShowDialog();
                LoadProducts(); // Refresh ratings
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
