using System;
using System.Collections.Generic;
using System.Linq;
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Repositories;

namespace GreenLifeOrganicStore.Services
{

    public class ReviewService
    {

        private readonly IRepository<Review> _reviewRepo = new SqlRepository<Review>("Reviews", "ReviewId");

        public void AddReview(Review review) => _reviewRepo.Add(review);

        public List<Review> GetReviewsByProduct(string productId)
        {
            return _reviewRepo.GetAll().Where(r => r.ProductId == productId).ToList();
        }

        public double GetAverageRating(string productId)
        {
            var reviews = GetReviewsByProduct(productId);
            if (!reviews.Any()) return 0;
            return Math.Round(reviews.Average(r => r.Rating), 1);
        }
    }
}
