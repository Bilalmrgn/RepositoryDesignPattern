using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }

        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public DateTime OrderDate { get; set; }

        // Navigation Properties
        public Customer Customer { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}
