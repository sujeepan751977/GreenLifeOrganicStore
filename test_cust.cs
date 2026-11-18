using System;
using GreenLifeOrganicStore.Models;
using GreenLifeOrganicStore.Repositories;
class Program {
    static void Main() {
        try {
            var repo = new SqlRepository<Customer>("Customers");
            var customers = repo.GetAll();
            Console.WriteLine("CUSTOMER COUNT: " + customers.Count);
        } catch(Exception ex) {
            Console.WriteLine("ERROR: " + ex.Message + "\n" + ex.StackTrace);
        }
    }
}
