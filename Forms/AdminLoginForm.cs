using System;
using System.Windows.Forms;
using GreenLifeOrganicStore.Services;

namespace GreenLifeOrganicStore.Forms
{

    public partial class AdminLoginForm : Form
    {

        private AuthService _authService = new AuthService();

        public AdminLoginForm()
        {
            InitializeComponent();
            // Auto-migrated UI styling from Designer
            this.pnlHeader.BackColor = GreenLifeOrganicStore.Utils.UIHelper.PrimaryColor;
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblEmail);
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblPassword);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnLogin, true);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnBack, false);
            this.BackColor = GreenLifeOrganicStore.Utils.UIHelper.BackgroundColor;
            Utils.UIHelper.StyleForm(this);
            Utils.UIHelper.StyleTextBox(txtEmail);
            Utils.UIHelper.StyleTextBox(txtPassword);
            this.Text = "Admin Login";
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (_authService.LoginAdmin(email, password))
                {
                    AdminDashboardForm adminDashboard = new AdminDashboardForm();
                    this.Hide(); 
                    adminDashboard.ShowDialog();
                    this.Close(); // Close after dashboard closes
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Authentication Service Error: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the current login form
        }
    }
}
