using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZRetail.Core.Dtos;
using XYZRetail.Core.Entities;

namespace XYZRetail.Core.Interfaces
{
    public interface IBasketService
    {
        Task<Basket> CreateBasket(BasketRequestDto basketDto);
    }
}
