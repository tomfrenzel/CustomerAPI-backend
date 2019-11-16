using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Models
{
    public class CustomerAndItem
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int Quantity { get; set; }
    }
}
