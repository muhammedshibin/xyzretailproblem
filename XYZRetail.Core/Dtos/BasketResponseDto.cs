using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZRetail.Core.Dtos
{
    public class BasketResponseDto
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public List<ItemInBasketDto> Items { get; set; }

    }

    public class ItemInBasketDto
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal ItemBasePrice { get; set; }
        public decimal ItemNetPrice { get; set; }
    }
}
