using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shop.Data.Models;

namespace shop.Data.Interfaces
{
    public interface IProductCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
