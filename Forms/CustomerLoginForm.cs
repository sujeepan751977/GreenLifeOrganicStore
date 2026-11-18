using System;
using System.Windows.Forms;
using GreenLifeOrganicStore.Services;

namespace GreenLifeOrganicStore.Forms
{

    public partial class CustomerLoginForm : Form
    {

        private AuthService _authService = new AuthService();

        public CustomerLoginForm()
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
            this.Text = "Customer Login";
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
                if (_authService.LoginCustomer(email, password))
                {
                    this.Hide(); 
                    new CustomerDashboardForm().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid customer credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection or Data Error: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
