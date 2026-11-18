using System;
using System.Windows.Forms;
using GreenLifeOrganicStore.Services;

namespace GreenLifeOrganicStore.Forms
{

    public partial class CustomerRegisterForm : Form
    {

        private AuthService _authService = new AuthService();

        public CustomerRegisterForm()
        {
            InitializeComponent();
            // Auto-migrated UI styling from Designer
            this.pnlHeader.BackColor = GreenLifeOrganicStore.Utils.UIHelper.PrimaryColor;
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblFullName);
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblEmail);
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblPassword);
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblPhone);
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblAddress);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnRegister, true);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnBack, false);
            Utils.UIHelper.StyleForm(this);
            Utils.UIHelper.StyleTextBox(txtFullName);
            Utils.UIHelper.StyleTextBox(txtEmail);
            Utils.UIHelper.StyleTextBox(txtPassword);
            Utils.UIHelper.StyleTextBox(txtPhone);
            Utils.UIHelper.StyleTextBox(txtAddress);
            this.Text = "Customer Registration";
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string error = _authService.RegisterCustomer(
                    txtFullName.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtPassword.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtAddress.Text.Trim()
                );
                if (error == null)
                {
                    MessageBox.Show("Registration successful! You can now login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(error, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration Process Failed: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
