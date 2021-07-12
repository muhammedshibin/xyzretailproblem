using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZRetail.Core.Entities;
using XYZRetail.Core.Interfaces;

namespace XYZRetail.Infrastructure.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProductAsync(List<int> productIds = null)
        {
            return await _context.Products
                .Where(p => productIds == null ||!productIds.Any() || productIds.Contains(p.Id))
                .Include(x => x.Category).ToListAsync();
        }

        
    }
}
