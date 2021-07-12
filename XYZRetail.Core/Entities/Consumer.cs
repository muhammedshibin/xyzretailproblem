using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZRetail.Core.Entities
{
    public class Customer : BaseEntity
    {
        public string CustomerName { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
    }
}
