using GreenLifeOrganicStore.Models;

namespace GreenLifeOrganicStore.Services
{

    public static class Session
    {

        public static Admin CurrentAdmin { get; set; }

        public static Customer CurrentCustomer { get; set; }

        public static void Logout()
        {
            CurrentAdmin = null;
            CurrentCustomer = null;
        }
    }
}
