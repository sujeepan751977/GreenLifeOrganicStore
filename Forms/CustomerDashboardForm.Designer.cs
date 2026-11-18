namespace GreenLifeOrganicStore.Forms
{
    partial class CustomerDashboardForm
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblWelcome;

        private System.Windows.Forms.Button btnBrowse;

        private System.Windows.Forms.Button btnCart;

        private System.Windows.Forms.Button btnOrders;

        private System.Windows.Forms.Button btnProfile;

        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.Label lblLoyaltyPoints;

        private System.Windows.Forms.Label lblTier;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblLoyaltyPoints = new System.Windows.Forms.Label();
            this.lblTier = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.lblWelcome.Location = new System.Drawing.Point(20, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(300, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Customer";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(10, 100);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(200, 45);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse Store";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(10, 155);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(200, 45);
            this.btnCart.TabIndex = 2;
            this.btnCart.Text = "View My Cart";
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(10, 210);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(200, 45);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Track Orders";
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(10, 265);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(200, 45);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(10, 440);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(980, 520);
            this.pnlContent.TabIndex = 0;
            // 
            // lblLoyaltyPoints
            // 
            this.lblLoyaltyPoints.Location = new System.Drawing.Point(20, 45);
            this.lblLoyaltyPoints.Name = "lblLoyaltyPoints";
            this.lblLoyaltyPoints.Size = new System.Drawing.Size(150, 20);
            this.lblLoyaltyPoints.TabIndex = 1;
            this.lblLoyaltyPoints.Text = "Points: 0";
            // 
            // lblTier
            // 
            this.lblTier.Location = new System.Drawing.Point(180, 45);
            this.lblTier.Name = "lblTier";
            this.lblTier.Size = new System.Drawing.Size(200, 20);
            this.lblTier.TabIndex = 2;
            this.lblTier.Text = "Tier: Organic";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Controls.Add(this.btnBrowse);
            this.pnlSidebar.Controls.Add(this.btnCart);
            this.pnlSidebar.Controls.Add(this.btnOrders);
            this.pnlSidebar.Controls.Add(this.btnProfile);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 500);
            this.pnlSidebar.TabIndex = 2;
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblLogo.Location = new System.Drawing.Point(0, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(220, 60);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "GreenLife";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblWelcome);
            this.pnlTop.Controls.Add(this.lblLoyaltyPoints);
            this.pnlTop.Controls.Add(this.lblTier);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(220, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(780, 80);
            this.pnlTop.TabIndex = 1;
            // 
            // CustomerDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "CustomerDashboardForm";
            this.Text = "Customer Dashboard - GreenLife Organic Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlSidebar;

        private System.Windows.Forms.Panel pnlTop;

        private System.Windows.Forms.Label lblLogo;
    }
}
