using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Services;
using System.Linq;
using GreenLifeOrganicStore.Repositories;

namespace GreenLifeOrganicStore.Forms
{

    public partial class ReviewForm : Form
    {

        private ReviewService _reviewService = new ReviewService();

        private IRepository<Customer> _customerRepo = new SqlRepository<Customer>("Customers");

        private Product _product;

        public ReviewForm(Product product)
        {
            _product = product;
            InitializeComponent();
            StyleForm();
            LoadReviews();
        }

        private void StyleForm()
        {
            lblProductName.Text = "Customer Feedback: " + _product.Name;
            Utils.UIHelper.StyleLabel(lblProductName, true);
            Utils.UIHelper.StyleLabel(lblRating);
            Utils.UIHelper.StyleLabel(lblComment);
            Utils.UIHelper.StyleButton(btnSubmit, true);
            Utils.UIHelper.StyleButton(btnBack, false);
            Utils.UIHelper.StyleNumeric(nudRating);
            Utils.UIHelper.StyleTextBox(txtComment);
            Utils.UIHelper.StyleDataGrid(dgvReviews);
            this.BackColor = Utils.UIHelper.BackgroundColor;
        }

        private void LoadReviews()
        {
            var reviews = _reviewService.GetReviewsByProduct(_product.ProductId);
            var customers = _customerRepo.GetAll();
            dgvReviews.DataSource = reviews.Select(r => new {
                Date = r.CreatedAt.ToShortDateString(),
                Customer = customers.FirstOrDefault(c => c.Id == r.CustomerId)?.FullName ?? "Anonymous",
                Rating = new string('+', r.Rating), // Use + for rating display (safety)
                Comment = r.Comment
            }).ToList();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Session.CurrentCustomer == null) {
                MessageBox.Show("Please login as customer to submit a review.");
                return;
            }
            var r = new Review {
                ReviewId = Guid.NewGuid().ToString(),
                ProductId = _product.ProductId,
                CustomerId = Session.CurrentCustomer.Id,
                Rating = (int)nudRating.Value,
                Comment = txtComment.Text.Trim(),
                CreatedAt = DateTime.Now
            };
            _reviewService.AddReview(r);
            MessageBox.Show("Thank you for your feedback!");
            txtComment.Clear();
            LoadReviews();
        }

        private void btnBack_Click(object sender, EventArgs e) => this.Close();
    }
}
