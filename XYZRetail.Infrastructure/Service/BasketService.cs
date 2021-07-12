using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZRetail.Core.Dtos;
using XYZRetail.Core.Entities;
using XYZRetail.Core.Interfaces;

namespace XYZRetail.Infrastructure.Service
{
    public class BasketService : IBasketService
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IProductRepository _productRepository;

        public BasketService(IBasketRepository basketRepository, IProductRepository productRepository)
        {
            _basketRepository = basketRepository;
            _productRepository = productRepository;
        }

        public async Task<Basket> CreateBasket(BasketRequestDto basketDto)
        {
            var basketExist = false;

            var basketItems = new List<BasketItem>();

            var basket = await _basketRepository.GetBasketByEmailAsync(basketDto.Email);

            if (basket == null)
            {
                basket = new Basket();

                var customer = await _basketRepository.GetCustomerAsync(basketDto.Email);

                customer ??= new Customer
                {
                    CustomerName = basketDto.CustomerName,
                    EmailAddress = basketDto.Email,
                    Address = basketDto.Address
                };

                basket.Customer = customer;
            }
            else
            {
                basketExist = true;
                basketItems = new List<BasketItem>();
                    //basket.Items; if email address is used as an identifier then use this to see previously added items
            }

            var productsIdsOfOrdered = basketDto.Items.Select(x => x.ProductId).ToList();

            var products = await _productRepository.GetProductAsync(productsIdsOfOrdered);

            foreach (var item in basketDto.Items)
            {
                var productToAdd = products.FirstOrDefault(x => x.Id == item.ProductId);

                var previousCount = basketItems.FirstOrDefault(x => x.ItemId == item.ProductId)?.Quantity;

                var updatedCount = item.Quantity + (previousCount?? 0);

                var price = productToAdd.BasePrice;

                basketItems.RemoveAll(x => x.ItemId == item.ProductId);

                var basketItem = new BasketItem
                {
                    ItemId = productToAdd.Id,
                    ItemName = productToAdd.ProductName,
                    ItemBasePrice = productToAdd.BasePrice,
                    Quantity = updatedCount,
                    ItemNetPrice = updatedCount * (price * (1 + productToAdd.Category.SalesTax + productToAdd.Category.ImportTax))
                };

                basketItems.Add(basketItem);
            }

            basket.TotalPrice = basketItems.Sum(x => x.ItemNetPrice);
            basket.Items = basketItems;

            if (!basketExist) _basketRepository.SaveBasket(basket);
                
            await _basketRepository.SaveChangesAsync();

            return basket;
        }
    }
}
