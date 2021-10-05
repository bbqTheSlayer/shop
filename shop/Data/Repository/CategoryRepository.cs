using System;
using System.Collections.Generic;
using shop.Data.Interfaces;
using shop.Data.Models;

namespace shop.Data.Repository
{
    public class CategoryRepository : IProductCategory
    {
        private readonly AppDbContent appDbContent;

        public CategoryRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Category> AllCategories => appDbContent.Category;
    }
}
