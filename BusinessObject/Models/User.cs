using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public class userContext
    {
        public userContext()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
