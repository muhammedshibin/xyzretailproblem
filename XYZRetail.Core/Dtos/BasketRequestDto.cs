using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZRetail.Core.Dtos
{
    public class BasketRequestDto
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public List<BuyingItem> Items { get; set; }

    }
}
