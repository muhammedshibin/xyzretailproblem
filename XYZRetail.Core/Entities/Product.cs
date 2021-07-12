using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZRetail.Core.Entities
{
    public class Product : BaseEntity
    {        
        public string ProductName { get; set; }
        public decimal BasePrice { get; set; }
        public string PictureUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
