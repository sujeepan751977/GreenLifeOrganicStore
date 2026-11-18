using System;
using System.Windows.Forms;

namespace GreenLifeOrganicStore.Forms
{

    public partial class StartForm : Form
    {

        public StartForm()
        {
            InitializeComponent();
            // Auto-migrated UI styling from Designer
            this.pnlTop.BackColor = GreenLifeOrganicStore.Utils.UIHelper.PrimaryColor;
            this.lblSubTitle.ForeColor = GreenLifeOrganicStore.Utils.UIHelper.AccentColor; // Luxury Gold
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnAdminLogin, true);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnCustomerLogin, true);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnRegister, false);
            this.BackColor = GreenLifeOrganicStore.Utils.UIHelper.BackgroundColor;
            this.Text = "GreenLife Organic Store - Welcome";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            new AdminLoginForm().ShowDialog();
            if (Services.Session.CurrentAdmin != null)
            {
                this.Hide();
                new AdminDashboardForm().ShowDialog();
                this.Show();
            }
        }

        private void btnCustomerLogin_Click(object sender, EventArgs e)
        {
            new CustomerLoginForm().ShowDialog();
            if (Services.Session.CurrentCustomer != null)
            {
                this.Hide();
                new CustomerDashboardForm().ShowDialog();
                this.Show();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new CustomerRegisterForm().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
