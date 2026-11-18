using System;
using System.Windows.Forms;
using GreenLifeOrganicStore.Services;

namespace GreenLifeOrganicStore.Forms
{

    public partial class CustomerDashboardForm : Form
    {

        public CustomerDashboardForm()
        {
            InitializeComponent();
            // Auto-migrated UI styling from Designer
            this.pnlSidebar.BackColor = GreenLifeOrganicStore.Utils.UIHelper.PrimaryColor;
            this.lblLogo.ForeColor = GreenLifeOrganicStore.Utils.UIHelper.AccentColor; // Luxury Gold
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnBrowse, true);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnCart, true);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnOrders, true);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnProfile, true);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnLogout, false);
            this.lblWelcome.ForeColor = GreenLifeOrganicStore.Utils.UIHelper.PrimaryColor;
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblLoyaltyPoints);
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblTier);
            this.BackColor = GreenLifeOrganicStore.Utils.UIHelper.BackgroundColor;
            this.Text = "Customer Dashboard - GreenLife Organic Store";
            this.StartPosition = FormStartPosition.CenterScreen;
            lblWelcome.Text = $"Welcome, {Session.CurrentCustomer?.FullName}";
            RefreshLoyaltyStats();
            LoadChildForm(new ProductBrowseForm());
        }

        private void RefreshLoyaltyStats()
        {
            if (Session.CurrentCustomer == null) return;
            lblLoyaltyPoints.Text = $" Points: {Session.CurrentCustomer.LoyaltyPoints}";
            string tier = "Organic Member";
            if (Session.CurrentCustomer.LoyaltyPoints > 500) tier = "Emerald Gold Tier";
            else if (Session.CurrentCustomer.LoyaltyPoints > 100) tier = "Lush Silver Tier";
            lblTier.Text = $" {tier}";
        }

        private void LoadChildForm(Form childForm)
        {
            try
            {
                pnlContent.Controls.Clear();
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlContent.Controls.Add(childForm);
                pnlContent.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading view: {ex.Message}");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            LoadChildForm(new ProductBrowseForm());
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            var f = new CartForm();
            f.FormClosed += (s, args) => RefreshLoyaltyStats();
            LoadChildForm(f);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            LoadChildForm(new OrderTrackingForm());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var f = new ProfileForm();
            f.FormClosed += (s, args) => {
                lblWelcome.Text = $"Welcome, {Session.CurrentCustomer?.FullName}";
                RefreshLoyaltyStats();
            };
            LoadChildForm(f);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Logout();
            this.Close();
        }
    }
}
