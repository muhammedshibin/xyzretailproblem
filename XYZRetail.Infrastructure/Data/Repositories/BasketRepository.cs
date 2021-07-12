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
   

    public class BasketRepository : IBasketRepository
    {
        private readonly DataContext _context;

        public BasketRepository(DataContext context)
        {
            _context = context;
        }

        public Basket SaveBasket(Basket basket)
        {
            _context.Baskets.Add(basket);           
            return basket;
        }

        public async Task<Basket> GetBasketByEmailAsync(string emailAddress)
        {
            return await _context.Baskets
                .Include(x => x.Customer)
                .Include(x => x.Items)
                .FirstOrDefaultAsync(x => x.Customer.EmailAddress.ToLower() == emailAddress.ToLower());
        }

        public async Task<Customer> GetCustomerAsync(string customerEmail)
        {
            return await _context.Customers.FirstOrDefaultAsync(x => x.EmailAddress.ToLower() == customerEmail.ToLower());
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
