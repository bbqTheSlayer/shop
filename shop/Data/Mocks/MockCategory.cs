using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shop.Data.Interfaces;
using shop.Data.Models;

namespace shop.Data.Mocks
{
    public class MockCategory : IProductCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Чехлы", desc = "Современные чехлы"},
                    new Category { categoryName = "Защитные стекла", desc = "Современные стекла"}
                };
            }
        }
    }
}
