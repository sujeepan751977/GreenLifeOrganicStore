using System;
using System.Collections.Generic;
using System.Linq;
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Repositories;

namespace GreenLifeOrganicStore.Services
{

    public class ProductService
    {

        private readonly IRepository<Product> _productRepo = new SqlRepository<Product>("Products", "ProductId");

        public List<Product> GetAllProducts() => _productRepo.GetAll();

        public List<Product> SearchProducts(string query, string category = null, decimal? minPrice = null, decimal? maxPrice = null)
        {
            var products = _productRepo.GetAll();
            if (!string.IsNullOrEmpty(query))
                products = products.Where(p => p.Name.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            
            if (!string.IsNullOrEmpty(category) && category != "All")
                products = products.Where(p => p.Category == category).ToList();
            if (minPrice.HasValue)
                products = products.Where(p => p.Price >= minPrice.Value).ToList();
            if (maxPrice.HasValue && maxPrice.Value > 0)
                products = products.Where(p => p.Price <= maxPrice.Value).ToList();
            return products;
        }

        public List<Product> GetLowStock(int threshold = 10)
        {
            return _productRepo.GetAll().Where(p => p.Stock <= threshold).ToList();
        }

        public void SaveProduct(Product product)
        {
            if (string.IsNullOrEmpty(product.ProductId))
            {
                product.ProductId = Guid.NewGuid().ToString();
                _productRepo.Add(product);
            }
            else
            {
                _productRepo.Update(product);
            }
        }

        public void DeleteProduct(string id) => _productRepo.Delete(id);
    }
}
