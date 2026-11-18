namespace GreenLifeOrganicStore.Forms
{
    partial class StartForm
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnAdminLogin;

        private System.Windows.Forms.Button btnCustomerLogin;

        private System.Windows.Forms.Button btnRegister;

        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Label lblTitle;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnCustomerLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            
            // pnlTop
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.lblSubTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Size = new System.Drawing.Size(500, 140);
            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.Size = new System.Drawing.Size(500, 50);
            this.lblTitle.Text = "GreenLife Organic";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblSubTitle
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lblSubTitle.Location = new System.Drawing.Point(0, 85);
            this.lblSubTitle.Size = new System.Drawing.Size(500, 30);
            this.lblSubTitle.Text = "Premium Organic Experience";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // btnAdminLogin
            this.btnAdminLogin.Location = new System.Drawing.Point(125, 170);
            this.btnAdminLogin.Size = new System.Drawing.Size(250, 50);
            this.btnAdminLogin.Text = "Admin Portal";
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // btnCustomerLogin
            this.btnCustomerLogin.Location = new System.Drawing.Point(125, 230);
            this.btnCustomerLogin.Size = new System.Drawing.Size(250, 50);
            this.btnCustomerLogin.Text = "Customer Login";
            this.btnCustomerLogin.Click += new System.EventHandler(this.btnCustomerLogin_Click);
            // btnRegister
            this.btnRegister.Location = new System.Drawing.Point(125, 290);
            this.btnRegister.Size = new System.Drawing.Size(250, 50);
            this.btnRegister.Text = "Join Our Community";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // btnExit
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.Location = new System.Drawing.Point(200, 360);
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.Text = "Exit System";
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.ForeColor = System.Drawing.Color.Gray;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // StartForm
            this.ClientSize = new System.Drawing.Size(500, 420);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.btnCustomerLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "StartForm";
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTop;

        private System.Windows.Forms.Label lblSubTitle;
    }
}
