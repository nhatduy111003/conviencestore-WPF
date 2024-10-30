using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public decimal? TotalPrice { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual userContext? User { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
