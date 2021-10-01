using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shop.Data.Interfaces;

namespace shop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IAllProduct _allProduct;
        private readonly IProductCategory _allCategory;

        public ProductController(IAllProduct product, IProductCategory iProductCategory)
        {
            _allCategory = iProductCategory;
            _allProduct = product;
        }

        public ViewResult List()
        {
            return View(_allProduct.Products);
        }
    }
}
