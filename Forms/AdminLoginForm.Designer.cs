namespace GreenLifeOrganicStore.Forms
{
    partial class AdminLoginForm
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblEmail;

        private System.Windows.Forms.Label lblPassword;

        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Button btnLogin;

        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.Panel pnlHeader;

        private System.Windows.Forms.Label lblHeader;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // pnlHeader
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(400, 80);
            // lblHeader
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 20);
            this.lblHeader.Size = new System.Drawing.Size(400, 40);
            this.lblHeader.Text = "Admin Access";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblEmail
            this.lblEmail.Text = "Username or Email";
            this.lblEmail.Location = new System.Drawing.Point(50, 110);
            this.lblEmail.Size = new System.Drawing.Size(300, 25);
            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(50, 135);
            this.txtEmail.Size = new System.Drawing.Size(300, 30);
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            // lblPassword
            this.lblPassword.Text = "Security Password";
            this.lblPassword.Location = new System.Drawing.Point(50, 185);
            this.lblPassword.Size = new System.Drawing.Size(300, 25);
            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(50, 210);
            this.txtPassword.Size = new System.Drawing.Size(300, 30);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.UseSystemPasswordChar = true;
            // btnLogin
            this.btnLogin.Text = "Authorize Login";
            this.btnLogin.Location = new System.Drawing.Point(50, 270);
            this.btnLogin.Size = new System.Drawing.Size(300, 45);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // btnBack
            this.btnBack.Text = "Return to Home";
            this.btnBack.Location = new System.Drawing.Point(50, 325);
            this.btnBack.Size = new System.Drawing.Size(300, 40);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name = "AdminLoginForm";
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
