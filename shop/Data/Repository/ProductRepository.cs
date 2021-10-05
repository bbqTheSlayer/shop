using System;
using System.Collections.Generic;
using shop.Data.Interfaces;
using shop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace shop.Data.Repository
{
    public class ProductRepository : IAllProduct
    {
        private readonly AppDbContent appDbContent;

        public ProductRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Product> Products => appDbContent.Product.Include(c => c.Category);

        public IEnumerable<Product> getFavProduct => appDbContent.Product.Where(p => p.isFavorite).Include(c => c.Category);

        public Product getObjectProduct(int productId) => appDbContent.Product.FirstOrDefault(p => p.id == productId);
    }
}
