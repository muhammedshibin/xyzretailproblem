using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZRetail.Core.Entities;

namespace XYZRetail.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductAsync(List<int> productIds = null);
    }
}
