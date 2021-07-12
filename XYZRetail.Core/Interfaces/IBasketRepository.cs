using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZRetail.Core.Entities;

namespace XYZRetail.Core.Interfaces
{
    public interface IBasketRepository
    {
        Task<Basket> GetBasketByEmailAsync(string emailAddress);
        Basket SaveBasket(Basket basket);
        Task<Customer> GetCustomerAsync(string customerEmail);
        Task SaveChangesAsync();
    }
}
