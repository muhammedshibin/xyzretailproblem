using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZRetail.Core.Entities
{
    public class BasketItem : BaseEntity
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }        
        public decimal ItemBasePrice { get; set; }
        public decimal ItemNetPrice { get; set; }
        public int BasketId { get; set; }
        public Basket Basket { get; set; }
    }
}
