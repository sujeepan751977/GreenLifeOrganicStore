namespace GreenLifeOrganicStore.Forms
{
    partial class OrderManagementForm
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvOrders;

        private System.Windows.Forms.DataGridView dgvItems;

        private System.Windows.Forms.ComboBox cmbStatus;

        private System.Windows.Forms.Button btnUpdateStatus;

        private System.Windows.Forms.Label lblOrders;

        private System.Windows.Forms.Label lblItems;

        private System.Windows.Forms.Panel pnlHeader;

        private System.Windows.Forms.Label lblHeader;

        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.DateTimePicker dtpStart;

        private System.Windows.Forms.DateTimePicker dtpEnd;

        private System.Windows.Forms.Button btnExportCsv;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnExportCsv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
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
            this.lblHeader.Text = "Order Processing";
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
            this.lblOrders.Text = "All Orders";
            this.lblOrders.Location = new System.Drawing.Point(20, 80);
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.Location = new System.Drawing.Point(20, 105);
            this.dgvOrders.Size = new System.Drawing.Size(500, 350);
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            this.lblItems.Text = "Selected Order Items";
            this.lblItems.Location = new System.Drawing.Point(540, 80);
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.Location = new System.Drawing.Point(540, 105);
            this.dgvItems.Size = new System.Drawing.Size(340, 200);
            this.cmbStatus.Location = new System.Drawing.Point(540, 330);
            this.cmbStatus.Size = new System.Drawing.Size(180, 30);
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.Location = new System.Drawing.Point(730, 327);
            this.btnUpdateStatus.Size = new System.Drawing.Size(150, 35);
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // dtpStart
            this.dtpStart.Location = new System.Drawing.Point(20, 465);
            this.dtpStart.Size = new System.Drawing.Size(120, 25);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // dtpEnd
            this.dtpEnd.Location = new System.Drawing.Point(150, 465);
            this.dtpEnd.Size = new System.Drawing.Size(120, 25);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            // btnExportCsv
            this.btnExportCsv.Text = "Export Orders (CSV)";
            this.btnExportCsv.Location = new System.Drawing.Point(280, 460);
            this.btnExportCsv.Size = new System.Drawing.Size(180, 35);
            this.btnExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.btnExportCsv);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.lblItems);
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
