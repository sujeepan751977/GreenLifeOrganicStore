namespace GreenLifeOrganicStore.Forms
{
    partial class CustomerRegisterForm
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblFullName;

        private System.Windows.Forms.Label lblEmail;

        private System.Windows.Forms.Label lblPassword;

        private System.Windows.Forms.Label lblPhone;

        private System.Windows.Forms.Label lblAddress;

        private System.Windows.Forms.TextBox txtFullName;

        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.TextBox txtPhone;

        private System.Windows.Forms.TextBox txtAddress;

        private System.Windows.Forms.Button btnRegister;

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
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
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
            this.lblHeader.Text = "Join GreenLife";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFullName.Text = "Full Name"; this.lblFullName.Location = new System.Drawing.Point(50, 100);
            this.lblFullName.Size = new System.Drawing.Size(300, 20);
            this.txtFullName.Location = new System.Drawing.Point(50, 122); this.txtFullName.Size = new System.Drawing.Size(300, 30);
            this.lblEmail.Text = "Email Address"; this.lblEmail.Location = new System.Drawing.Point(50, 160);
            this.lblEmail.Size = new System.Drawing.Size(300, 20);
            this.txtEmail.Location = new System.Drawing.Point(50, 182); this.txtEmail.Size = new System.Drawing.Size(300, 30);
            this.lblPassword.Text = "Create Password"; this.lblPassword.Location = new System.Drawing.Point(50, 220);
            this.lblPassword.Size = new System.Drawing.Size(300, 20);
            this.txtPassword.Location = new System.Drawing.Point(50, 242); this.txtPassword.Size = new System.Drawing.Size(300, 30);
            this.txtPassword.UseSystemPasswordChar = true;
            this.lblPhone.Text = "Phone Number"; this.lblPhone.Location = new System.Drawing.Point(50, 280);
            this.lblPhone.Size = new System.Drawing.Size(300, 20);
            this.txtPhone.Location = new System.Drawing.Point(50, 302); this.txtPhone.Size = new System.Drawing.Size(300, 30);
            this.lblAddress.Text = "Delivery Address"; this.lblAddress.Location = new System.Drawing.Point(50, 340);
            this.lblAddress.Size = new System.Drawing.Size(300, 20);
            this.txtAddress.Location = new System.Drawing.Point(50, 362); this.txtAddress.Size = new System.Drawing.Size(300, 60);
            this.txtAddress.Multiline = true;
            // btnRegister
            this.btnRegister.Text = "Create Account";
            this.btnRegister.Location = new System.Drawing.Point(50, 435);
            this.btnRegister.Size = new System.Drawing.Size(300, 45);
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // btnBack
            this.btnBack.Text = "Maybe Later";
            this.btnBack.Location = new System.Drawing.Point(50, 490);
            this.btnBack.Size = new System.Drawing.Size(300, 40);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlHeader, this.lblFullName, this.txtFullName,
                this.lblEmail, this.txtEmail,
                this.lblPassword, this.txtPassword,
                this.lblPhone, this.txtPhone,
                this.lblAddress, this.txtAddress,
                this.btnRegister, this.btnBack
            });
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor = System.Drawing.Color.White;
            this.Name = "CustomerRegisterForm";
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
