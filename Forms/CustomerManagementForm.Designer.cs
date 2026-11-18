namespace GreenLifeOrganicStore.Forms
{
    partial class CustomerManagementForm
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvCustomers;

        private System.Windows.Forms.TextBox txtFullName;

        private System.Windows.Forms.TextBox txtPhone;

        private System.Windows.Forms.TextBox txtAddress;

        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.Button btnViewHistory;

        private System.Windows.Forms.Label lblFullName;

        private System.Windows.Forms.Label lblPhone;

        private System.Windows.Forms.Label lblAddress;

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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // pnlHeader
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(800, 60);
            // lblHeader
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(80, 15);
            this.lblHeader.Size = new System.Drawing.Size(400, 30);
            this.lblHeader.Text = "Customer Relations";
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
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(20, 80);
            this.dgvCustomers.Size = new System.Drawing.Size(760, 200);
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            this.lblFullName.Text = "Full Name"; this.lblFullName.Location = new System.Drawing.Point(30, 300);
            this.txtFullName.Location = new System.Drawing.Point(30, 325); this.txtFullName.Width = 200;
            this.lblPhone.Text = "Phone Number"; this.lblPhone.Location = new System.Drawing.Point(250, 300);
            this.txtPhone.Location = new System.Drawing.Point(250, 325); this.txtPhone.Width = 200;
            this.lblAddress.Text = "Residential Address"; this.lblAddress.Location = new System.Drawing.Point(30, 365);
            this.txtAddress.Location = new System.Drawing.Point(30, 390); this.txtAddress.Width = 420; this.txtAddress.Multiline = true; this.txtAddress.Height = 60;
            this.btnSave.Text = "Update Profile"; this.btnSave.Location = new System.Drawing.Point(500, 300 + 25); this.btnSave.Size = new System.Drawing.Size(180, 40);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnViewHistory.Text = "View Purchase History"; this.btnViewHistory.Location = new System.Drawing.Point(500, 300 + 80); this.btnViewHistory.Size = new System.Drawing.Size(180, 40);
            this.btnViewHistory.Click += new System.EventHandler(this.btnViewHistory_Click);
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnViewHistory);
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
