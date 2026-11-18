using System;
using System.Reflection;
using System.Collections.Generic;
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Repositories;
using GreenLifeOrganicStore.Services;

class Program
{
    static void Main()
    {
        try 
        {
            var pService = new ProductService();
            var products = pService.GetAllProducts();
            Console.WriteLine("PRODUCT COUNT: " + products.Count);

            var oService = new OrderService();
            var orders = oService.GetAllOrders();
            Console.WriteLine("ORDER COUNT: " + orders.Count);

            var rService = new ReviewService();
            var review = rService.GetAverageRating("test");
            Console.WriteLine("REVIEWS WORK");

        }
        catch(Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message + " | " + ex.StackTrace);
        }
    }
}
