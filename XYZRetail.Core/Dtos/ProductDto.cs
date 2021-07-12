using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZRetail.Core.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal BasePrice { get; set; }
        public string PictureUrl { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
