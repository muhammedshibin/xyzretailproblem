using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZRetail.Core.Entities;
using XYZRetail.Core.Interfaces;

namespace XYZRetail.Infrastructure.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        public async Task AddCustomer(Customer customer)
        {
            _context.Add(customer);
            await _context.SaveChangesAsync();
        }
    }
}
