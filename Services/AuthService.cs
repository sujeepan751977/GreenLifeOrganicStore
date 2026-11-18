using System;
using System.Linq;
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Repositories;
using GreenLifeOrganicStore.Utils;

namespace GreenLifeOrganicStore.Services
{

    public class AuthService
    {

        private readonly IRepository<Admin> _adminRepo = new SqlRepository<Admin>("Admins");

        private readonly IRepository<Customer> _customerRepo = new SqlRepository<Customer>("Customers");

        public bool LoginAdmin(string email, string password)
        {
            var admin = _adminRepo.GetAll().FirstOrDefault(a => a.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
            if (admin != null && CryptoHelper.VerifyPassword(password, admin.PasswordHash))
            {
                Session.CurrentAdmin = admin;
                Logger.LogInfo($"Admin Login Success: {email}");
                return true;
            }
            return false;
        }

        public bool LoginCustomer(string email, string password)
        {
            var customer = _customerRepo.GetAll().FirstOrDefault(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
            if (customer != null && CryptoHelper.VerifyPassword(password, customer.PasswordHash))
            {
                Session.CurrentCustomer = customer;
                Logger.LogInfo($"Customer Login Success: {email}");
                return true;
            }
            return false;
        }

        public string RegisterCustomer(string fullName, string email, string password, string phone, string address)
        {
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                return "All fields are required.";
            if (!email.Contains("@") || !email.Contains("."))
                return "Invalid email format.";
            if (password.Length < 6)
                return "Password must be at least 6 characters.";
            if (_customerRepo.GetAll().Any(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase)) ||
                _adminRepo.GetAll().Any(a => a.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
                return "Email already exists.";
            var customer = new Customer
            {
                Id = Guid.NewGuid().ToString(),
                FullName = fullName,
                Email = email,
                PasswordHash = CryptoHelper.HashPassword(password),
                Phone = phone,
                Address = address,
                CreatedAt = DateTime.Now
            };
            _customerRepo.Add(customer);
            Logger.LogInfo($"New Customer Registered: {email}");
            return null; // Success
        }
    }
}
