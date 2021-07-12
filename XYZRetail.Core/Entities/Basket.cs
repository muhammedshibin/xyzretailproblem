using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZRetail.Core.Entities
{
    public class Basket : BaseEntity
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
        public decimal TotalPrice { get; set; }
    }
}
