using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order : BaseEntity
    {
        public Guid ProductId { get; set; }
        public DateTime OrderDate { get; set; }

        // Navigation Properties
        public Product Product { get; set; } = null!;
    }
}
