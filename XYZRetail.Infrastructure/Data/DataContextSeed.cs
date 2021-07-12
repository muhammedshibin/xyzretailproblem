using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZRetail.Core.Entities;

namespace XYZRetail.Infrastructure.Data
{
    public static class DataContextSeed
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    ProductName = "Book - 1",
                    CategoryId = 1,
                    BasePrice = (decimal) 100.0,
                    PictureUrl = "images/Book-1.jpg"
                },
                 new Product
                {
                     Id = 2,
                    ProductName = "Book - 2",
                    CategoryId = 1,
                    BasePrice = (decimal) 150.0,
                    PictureUrl = "images/Book-2.jpg"
                }, new Product
                {
                    Id =3,
                    ProductName = "Book - 3",
                    CategoryId = 1,
                    BasePrice = (decimal) 120.0,
                    PictureUrl = "images/Book-3.jpg"
                },
                new Product
                {
                    Id = 4,
                    ProductName = "CD - 1",
                    CategoryId = 2,
                    BasePrice = (decimal) 40.0,
                    PictureUrl = "images/cd-1.jpg"
                },
                new Product
                {
                    Id = 5,
                    ProductName = "CD - 2",
                    CategoryId = 2,
                    BasePrice = (decimal) 50.00,
                    PictureUrl = "images/cd-2.jpg"
                }, new Product
                {
                    Id = 6,
                    ProductName = "CD - 3",
                    CategoryId = 2,
                    BasePrice = (decimal) 60.00,
                    PictureUrl = "images/cd-3.jpg"
                },
                new Product
                {
                    Id = 7,
                    ProductName = "Cosmetics - 1",
                    CategoryId = 3,
                    BasePrice = (decimal) 250.00,
                    PictureUrl = "images/cosmetics-1.jpg"
                }, new Product
                {
                    Id = 8,
                    ProductName = "Cosmetics - 2",
                    CategoryId = 3,
                    BasePrice = (decimal) 300.00,
                    PictureUrl = "images/cosmetics-2.jpg"
                }
            };
        }

        public static List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category
                {
                    Id = 1,
                    CategoryName = "Book",
                    SalesTax = 0,
                    ImportTax = 0
                },

                new Category
                {
                    Id = 2,
                    CategoryName = "CD",
                    SalesTax = (decimal)0.10,
                    ImportTax = (decimal)0.05
                },

                new Category
                {
                    Id = 3,
                    CategoryName = "Cosmetics",
                    SalesTax = (decimal)0.10,
                    ImportTax = 0
                }
            };
        }
    }
}
