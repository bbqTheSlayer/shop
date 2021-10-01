using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shop.Data.Interfaces;
using shop.Data.Models;

namespace shop.Data.Mocks
{
    public class MockProduct : IAllProduct
    {
        private readonly IProductCategory _categoryProduct = new MockCategory();

        public IEnumerable<Product> Products {
                get
            {
                return new List<Product> {
                    new Product {
                        name = "iPhone 11",
                        shortDesc = "",
                        longDesc = "",
                        img = "",
                        price = 325,
                        isFavorite = true,
                        avalible =  true,
                        Category = _categoryProduct.AllCategories.First()
                    }
                };
            }
        }

        public IEnumerable<Product> getFavProduct { get; set; }

        public Product getObjectProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
