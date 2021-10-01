using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shop.Data.Models;

namespace shop.Data.Interfaces
{
    public interface IAllProduct
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Product> getFavProduct { get; set; }
        Product getObjectProduct(int productId);
    }
}
