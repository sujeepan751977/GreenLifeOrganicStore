using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Services;

namespace GreenLifeOrganicStore.Forms
{

    public partial class ProductManagementForm : Form
    {

        private ProductService _productService = new ProductService();

        private ReviewService _reviewService = new ReviewService();

        private Product _selectedProduct = null;

        public ProductManagementForm()
        {
            InitializeComponent();
            // Auto-migrated UI styling from Designer
            this.pnlHeader.BackColor = GreenLifeOrganicStore.Utils.UIHelper.PrimaryColor;
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnSearch, true);
            this.chkIsActive.ForeColor = GreenLifeOrganicStore.Utils.UIHelper.TextSecondary;
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnSave, true);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnDelete, false);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnClear, false);
            Utils.UIHelper.StyleForm(this);
            Utils.UIHelper.StyleDataGrid(dgvProducts);
            Utils.UIHelper.StyleTextBox(txtName);
            Utils.UIHelper.StyleTextBox(txtCategory);
            Utils.UIHelper.StyleTextBox(txtSupplier);
            Utils.UIHelper.StyleTextBox(txtSearch);
            Utils.UIHelper.StyleNumeric(nudPrice);
            Utils.UIHelper.StyleNumeric(nudStock);
            Utils.UIHelper.StyleNumeric(nudDiscount);
            
            Utils.UIHelper.StyleLabel(lblName);
            Utils.UIHelper.StyleLabel(lblCategory);
            Utils.UIHelper.StyleLabel(lblSupplier);
            Utils.UIHelper.StyleLabel(lblPrice);
            Utils.UIHelper.StyleLabel(lblStock);
            Utils.UIHelper.StyleLabel(lblDiscount);
            LoadProducts();
            btnSave.Text = "Add Product"; // Default state
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void LoadProducts()
        {
            var products = _productService.GetAllProducts();
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products.Select(p => new {
                p.ProductId,
                p.Name,
                p.Category,
                p.Price,
                p.Stock,
                p.Supplier,
                AvgRating = _reviewService.GetAverageRating(p.ProductId),
                p.IsActive
            }).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || nudPrice.Value < 0 || nudStock.Value < 0)
            {
                MessageBox.Show("Please provide valid product details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var product = _selectedProduct ?? new Product();
                product.Name = txtName.Text.Trim();
                product.Category = txtCategory.Text.Trim();
                product.Price = nudPrice.Value;
                product.Stock = (int)nudStock.Value;
                product.Supplier = txtSupplier.Text.Trim();
                product.DiscountPercent = (int)nudDiscount.Value;
                product.IsActive = chkIsActive.Checked;
                _productService.SaveProduct(product);
                MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Product Save Failed: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedProduct != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        _productService.DeleteProduct(_selectedProduct.ProductId);
                        ClearInputs();
                        LoadProducts();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Product Deletion Failed: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvProducts.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
                _selectedProduct = _productService.GetAllProducts().FirstOrDefault(p => p.ProductId == id);
                if (_selectedProduct != null)
                {
                    txtName.Text = _selectedProduct.Name;
                    txtCategory.Text = _selectedProduct.Category;
                    nudPrice.Value = _selectedProduct.Price;
                    nudStock.Value = _selectedProduct.Stock;
                    txtSupplier.Text = _selectedProduct.Supplier;
                    nudDiscount.Value = _selectedProduct.DiscountPercent;
                    chkIsActive.Checked = _selectedProduct.IsActive;
                    
                    btnSave.Text = "Update Product"; // Change mode to update
                    btnSave.BackColor = System.Drawing.Color.FromArgb(139, 101, 0); // Metallic mode for update
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var results = _productService.SearchProducts(txtSearch.Text);
            dgvProducts.DataSource = null; // Reset to force refresh
            dgvProducts.DataSource = results.Select(p => new {
                p.ProductId,
                p.Name,
                p.Category,
                p.Price,
                p.Stock,
                p.Supplier,
                AvgRating = _reviewService.GetAverageRating(p.ProductId),
                p.IsActive
            }).ToList();
        }

        private void ClearInputs()
        {
            _selectedProduct = null;
            txtName.Clear();
            txtCategory.Clear();
            nudPrice.Value = 0;
            nudStock.Value = 0;
            txtSupplier.Clear();
            nudDiscount.Value = 0;
            chkIsActive.Checked = true;
            btnSave.Text = "Add Product"; // Reset mode to add
            btnSave.BackColor = GreenLifeOrganicStore.Utils.UIHelper.PrimaryColor;
            txtName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearInputs();

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
