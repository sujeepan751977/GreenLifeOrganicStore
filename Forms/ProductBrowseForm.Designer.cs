namespace GreenLifeOrganicStore.Forms
{
    partial class ProductBrowseForm
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvProducts;

        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.ComboBox cmbCategory;

        private System.Windows.Forms.ComboBox cmbSort;

        private System.Windows.Forms.NumericUpDown nudMinPrice;

        private System.Windows.Forms.NumericUpDown nudMaxPrice;

        private System.Windows.Forms.NumericUpDown nudQuantity;

        private System.Windows.Forms.Button btnAddToCart;

        private System.Windows.Forms.Button btnAddReview;

        private System.Windows.Forms.Label lblQty;

        private System.Windows.Forms.Panel pnlHeader;

        private System.Windows.Forms.Label lblHeader;

        private System.Windows.Forms.Button btnBack;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.nudMinPrice = new System.Windows.Forms.NumericUpDown();
            this.nudMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnAddReview = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.pnlHeader.SuspendLayout();
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
            this.lblHeader.Text = "Organic Marketplace";
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
            // Search Area
            this.txtSearch.Location = new System.Drawing.Point(20, 75);
            this.txtSearch.Size = new System.Drawing.Size(180, 25);
            
            this.cmbCategory.Location = new System.Drawing.Point(210, 75);
            this.cmbCategory.Size = new System.Drawing.Size(120, 25);
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.Location = new System.Drawing.Point(340, 75);
            this.cmbSort.Size = new System.Drawing.Size(120, 25);
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nudMinPrice.Location = new System.Drawing.Point(470, 75);
            this.nudMinPrice.Size = new System.Drawing.Size(70, 25);
            this.nudMinPrice.Maximum = 10000;
            this.nudMinPrice.DecimalPlaces = 2;
            this.nudMaxPrice.Location = new System.Drawing.Point(550, 75);
            this.nudMaxPrice.Size = new System.Drawing.Size(70, 25);
            this.nudMaxPrice.Maximum = 10000;
            this.nudMaxPrice.DecimalPlaces = 2;
            this.nudMaxPrice.Maximum = 1000;
            this.btnSearch.Text = "Refine";
            this.btnSearch.Location = new System.Drawing.Point(630, 72);
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(20, 110);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(860, 280);
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.MultiSelect = false;
            this.lblQty.Text = "Desired Quantity:";
            this.lblQty.Location = new System.Drawing.Point(30, 415);
            
            this.nudQuantity.Location = new System.Drawing.Point(180, 412);
            this.nudQuantity.Minimum = 1;
            this.nudQuantity.Minimum = 1;
            this.nudQuantity.Size = new System.Drawing.Size(80, 25);
            this.btnAddToCart.Text = "Add to Basket";
            this.btnAddToCart.Location = new System.Drawing.Point(580, 405);
            this.btnAddToCart.Size = new System.Drawing.Size(140, 45);
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            this.btnAddReview.Text = "Ratings & Reviews";
            this.btnAddReview.Location = new System.Drawing.Point(730, 405);
            this.btnAddReview.Size = new System.Drawing.Size(140, 45);
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            this.ClientSize = new System.Drawing.Size(900, 480);
            this.Controls.Add(this.pnlHeader);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvProducts, this.txtSearch, this.btnSearch, this.cmbCategory, this.cmbSort, this.nudMinPrice, this.nudMaxPrice, 
                this.lblQty, this.nudQuantity, this.btnAddToCart, this.btnAddReview
            });
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
