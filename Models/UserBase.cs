using System;

namespace GreenLifeOrganicStore.Models
{

    public abstract class UserBase
    {

        public string Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
