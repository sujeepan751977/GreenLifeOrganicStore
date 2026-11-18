using System;
using System.Windows.Forms;
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Repositories;
using GreenLifeOrganicStore.Services;

namespace GreenLifeOrganicStore.Forms
{

    public partial class ProfileForm : Form
    {

        private IRepository<Customer> _customerRepo = new SqlRepository<Customer>("Customers");

        public ProfileForm()
        {
            InitializeComponent();
            // Auto-migrated UI styling from Designer
            this.pnlHeader.BackColor = GreenLifeOrganicStore.Utils.UIHelper.PrimaryColor;
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblFullName);
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblEmail);
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblPhone);
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblAddress);
            GreenLifeOrganicStore.Utils.UIHelper.StyleButton(this.btnSave, true);
            this.pnlLoyalty.BackColor = GreenLifeOrganicStore.Utils.UIHelper.SurfaceColor;
            this.lblLoyaltyTitle.ForeColor = GreenLifeOrganicStore.Utils.UIHelper.AccentColor;
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblLoyaltyPoints);
            GreenLifeOrganicStore.Utils.UIHelper.StyleLabel(this.lblLoyaltyStatus);
            Utils.UIHelper.StyleForm(this);
            Utils.UIHelper.StyleTextBox(txtFullName);
            Utils.UIHelper.StyleTextBox(txtEmail);
            Utils.UIHelper.StyleTextBox(txtPhone);
            Utils.UIHelper.StyleTextBox(txtAddress);
            
            txtFullName.Text = Session.CurrentCustomer.FullName;
            txtEmail.Text = Session.CurrentCustomer.Email;
            txtPhone.Text = Session.CurrentCustomer.Phone;
            txtAddress.Text = Session.CurrentCustomer.Address;
            
            lblLoyaltyPoints.Text = $"Loyalty Points: {Session.CurrentCustomer.LoyaltyPoints}";
            string tier = "Organic Member";
            if (Session.CurrentCustomer.LoyaltyPoints > 500) tier = "Emerald Gold Tier";
            else if (Session.CurrentCustomer.LoyaltyPoints > 100) tier = "Lush Silver Tier";
            lblLoyaltyStatus.Text = $"Status: {tier}";
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Session.CurrentCustomer.FullName = txtFullName.Text.Trim();
            Session.CurrentCustomer.Phone = txtPhone.Text.Trim();
            Session.CurrentCustomer.Address = txtAddress.Text.Trim();
            _customerRepo.Update(Session.CurrentCustomer);
            MessageBox.Show("Profile updated!", "Success");
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
