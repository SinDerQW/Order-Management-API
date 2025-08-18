using Microsoft.AspNetCore.Identity;
using OrderManagement.Domain.Entities;

namespace  OrderManager.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool isAdmin { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

        public User(string username, string email, string password)
        {
            this.Id = Guid.NewGuid();
            this.Username = username;
            this.Email = email;

            var hasher = new PasswordHasher<string>();
            this.PasswordHash = hasher.HashPassword(username, password);
        }
    }
}
