namespace GreenLifeOrganicStore.Forms
{
    partial class ProductManagementForm
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvProducts;

        private System.Windows.Forms.TextBox txtName;

        private System.Windows.Forms.TextBox txtCategory;

        private System.Windows.Forms.NumericUpDown nudPrice;

        private System.Windows.Forms.NumericUpDown nudStock;

        private System.Windows.Forms.TextBox txtSupplier;

        private System.Windows.Forms.NumericUpDown nudDiscount;

        private System.Windows.Forms.CheckBox chkIsActive;

        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.Label lblName;

        private System.Windows.Forms.Label lblCategory;

        private System.Windows.Forms.Label lblPrice;

        private System.Windows.Forms.Label lblStock;

        private System.Windows.Forms.Label lblSupplier;

        private System.Windows.Forms.Label lblDiscount;

        private System.Windows.Forms.Button btnBack;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // pnlHeader
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(900, 60);
            // lblHeaderTitle
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(80, 15);
            this.lblHeaderTitle.Size = new System.Drawing.Size(400, 30);
            this.lblHeaderTitle.Text = "Inventory Management";
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
            this.pnlHeader.Controls.Add(this.btnBack);
            // Search
            this.txtSearch.Location = new System.Drawing.Point(550, 75);
            this.txtSearch.Size = new System.Drawing.Size(220, 25);
            this.btnSearch.Text = "Search";
            this.btnSearch.Location = new System.Drawing.Point(780, 72);
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // DataGridView
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(20, 110);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(860, 250);
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // Inputs Grouping
            this.lblName.Text = "Product Name:"; this.lblName.Location = new System.Drawing.Point(30, 380 + 4);
            this.txtName.Location = new System.Drawing.Point(135, 380); this.txtName.Width = 160;
            this.lblCategory.Text = "Category:"; this.lblCategory.Location = new System.Drawing.Point(320, 380 + 4);
            this.txtCategory.Location = new System.Drawing.Point(410, 380); this.txtCategory.Width = 160;
            this.lblSupplier.Text = "Supplier:"; this.lblSupplier.Location = new System.Drawing.Point(590, 380 + 4);
            this.txtSupplier.Location = new System.Drawing.Point(680, 380); this.txtSupplier.Width = 160;
            this.lblPrice.Text = "Price (LKR):"; this.lblPrice.Location = new System.Drawing.Point(30, 380 + 50 + 4);
            this.nudPrice.Location = new System.Drawing.Point(135, 380 + 50); this.nudPrice.Width = 160; this.nudPrice.DecimalPlaces = 2; this.nudPrice.Maximum = 10000;
            this.lblStock.Text = "Stock Qty:"; this.lblStock.Location = new System.Drawing.Point(320, 380 + 50 + 4);
            this.nudStock.Location = new System.Drawing.Point(410, 380 + 50); this.nudStock.Width = 160; this.nudStock.Maximum = 10000;
            this.lblDiscount.Text = "Discount %:"; this.lblDiscount.Location = new System.Drawing.Point(590, 380 + 50 + 4);
            this.nudDiscount.Location = new System.Drawing.Point(680, 380 + 50); this.nudDiscount.Width = 160;
            this.chkIsActive.Text = "Publish to Store"; this.chkIsActive.Location = new System.Drawing.Point(135, 380 + 95);
            this.chkIsActive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            // Buttons
            this.btnSave.Text = "Save Changes"; this.btnSave.Location = new System.Drawing.Point(500, 380 + 100); this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnDelete.Text = "Delete Product"; this.btnDelete.Location = new System.Drawing.Point(630, 380 + 100); this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnClear.Text = "Clear Form"; this.btnClear.Location = new System.Drawing.Point(760, 380 + 100); this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // Form
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.txtSearch); this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblName); this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCategory); this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblPrice); this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.lblStock); this.Controls.Add(this.nudStock);
            this.Controls.Add(this.lblSupplier); this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.lblDiscount); this.Controls.Add(this.nudDiscount);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.btnSave); this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;

        private System.Windows.Forms.Label lblHeaderTitle;
    }
}
