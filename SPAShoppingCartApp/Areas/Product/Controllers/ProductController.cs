using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPAShoppingCartApp.Areas.Product.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public SPAShoppingCartApp.Areas.Product.Models.Product Product(int productId)
        {
            return new Models.Product { CategoryId = 1, ProductId = 1, ProductName = "Bata Shoes", ProductDescription = "Comfortable shoes.", ProductImage = null };
        }

    }
}
