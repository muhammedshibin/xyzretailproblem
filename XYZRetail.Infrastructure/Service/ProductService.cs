using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZRetail.Core.Entities;
using XYZRetail.Core.Interfaces;

namespace XYZRetail.Infrastructure.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetProductsAsync(string webRootPath)
        {
            var products =  await _productRepository.GetProductAsync();

            foreach (var product in products)
            {
                product.PictureUrl = webRootPath + "/" + product.PictureUrl;
            }

            return products;
        }
    }
}
