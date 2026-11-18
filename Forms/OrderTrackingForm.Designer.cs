namespace GreenLifeOrganicStore.Forms
{
    partial class OrderTrackingForm
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvOrders;

        private System.Windows.Forms.Button btnExport;

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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // pnlHeader
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(600, 60);
            // lblHeader
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(80, 15);
            this.lblHeader.Size = new System.Drawing.Size(400, 30);
            this.lblHeader.Text = "My Order History";
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
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(20, 80);
            this.dgvOrders.Size = new System.Drawing.Size(560, 250);
            this.btnExport.Text = "Export My History";
            this.btnExport.Location = new System.Drawing.Point(20, 345);
            this.btnExport.Size = new System.Drawing.Size(180, 40);
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.btnExport);
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
