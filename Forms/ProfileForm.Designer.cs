namespace GreenLifeOrganicStore.Forms
{
    partial class ProfileForm
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblFullName;

        private System.Windows.Forms.Label lblEmail;

        private System.Windows.Forms.Label lblPhone;

        private System.Windows.Forms.Label lblAddress;

        private System.Windows.Forms.TextBox txtFullName;

        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.TextBox txtPhone;

        private System.Windows.Forms.TextBox txtAddress;

        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.Panel pnlHeader;

        private System.Windows.Forms.Label lblHeader;

        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.Panel pnlLoyalty;

        private System.Windows.Forms.Label lblLoyaltyTitle;

        private System.Windows.Forms.Label lblLoyaltyPoints;

        private System.Windows.Forms.Label lblLoyaltyStatus;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlLoyalty = new System.Windows.Forms.Panel();
            this.lblLoyaltyTitle = new System.Windows.Forms.Label();
            this.lblLoyaltyPoints = new System.Windows.Forms.Label();
            this.lblLoyaltyStatus = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlLoyalty.SuspendLayout();
            this.SuspendLayout();
            // pnlHeader
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(400, 80);
            // lblHeader
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 20);
            this.lblHeader.Size = new System.Drawing.Size(400, 40);
            this.lblHeader.Text = "My Profile";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblFullName.Text = "Full Name"; this.lblFullName.Location = new System.Drawing.Point(50, 100);
            this.txtFullName.Location = new System.Drawing.Point(50, 125); this.txtFullName.Width = 300;
            this.lblEmail.Text = "Email Address (Identity)"; this.lblEmail.Location = new System.Drawing.Point(50, 165);
            this.txtEmail.Location = new System.Drawing.Point(50, 190); this.txtEmail.Width = 300; this.txtEmail.ReadOnly = true;
            this.lblPhone.Text = "Phone Number"; this.lblPhone.Location = new System.Drawing.Point(50, 230);
            this.txtPhone.Location = new System.Drawing.Point(50, 255); this.txtPhone.Width = 300;
            this.lblAddress.Text = "Default Shipping Address"; this.lblAddress.Location = new System.Drawing.Point(50, 295);
            this.txtAddress.Location = new System.Drawing.Point(50, 320); this.txtAddress.Width = 300; this.txtAddress.Multiline = true; this.txtAddress.Height = 60;
            this.btnSave.Text = "Sync Profile";
            this.btnSave.Location = new System.Drawing.Point(50, 390);
            this.btnSave.Size = new System.Drawing.Size(300, 45);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // Loyalty Card
            this.pnlLoyalty.Location = new System.Drawing.Point(50, 455);
            this.pnlLoyalty.Size = new System.Drawing.Size(300, 120);
            this.lblLoyaltyTitle.Text = " GreenLife Rewards";
            this.lblLoyaltyTitle.Location = new System.Drawing.Point(20, 20);
            this.lblLoyaltyTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblLoyaltyPoints.Text = "Points: 0";
            this.lblLoyaltyPoints.Location = new System.Drawing.Point(20, 55);
            this.lblLoyaltyStatus.Text = "Status: Organic Tier";
            this.lblLoyaltyStatus.Location = new System.Drawing.Point(20, 80);
            this.pnlLoyalty.Controls.Add(this.lblLoyaltyTitle);
            this.pnlLoyalty.Controls.Add(this.lblLoyaltyPoints);
            this.pnlLoyalty.Controls.Add(this.lblLoyaltyStatus);
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlLoyalty);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblFullName, this.txtFullName, this.lblEmail, this.txtEmail,
                this.lblPhone, this.txtPhone, this.lblAddress, this.txtAddress, this.btnSave
            });
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.White;
            this.Name = "ProfileForm";
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
