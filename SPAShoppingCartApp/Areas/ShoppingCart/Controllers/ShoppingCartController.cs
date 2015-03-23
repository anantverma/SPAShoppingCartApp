using ShoppingCartEntities;
using SPAShoppingCartApp.Areas.ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPAShoppingCartApp.Areas.ShoppingCart.Controllers
{
    public class ShoppingCartController : Controller
    {
        List<CartItem> CartItems;
        private List<CartItem> GetCartItems()
        {
            CartItems = new List<CartItem>();
            CartItems.Add(new CartItem { CartId = 1, ProductId = 1, ProductCode = "10001", ProductQuantity = 1, ProductImageSrc = "~/Images/accent.png", ProductName = "Product1", ProductPrice = "1000" });
            CartItems.Add(new CartItem { CartId = 1, ProductId = 2, ProductCode = "10002", ProductQuantity = 1, ProductImageSrc = "~/Images/accent.png", ProductName = "Product2", ProductPrice = "2000" });
            CartItems.Add(new CartItem { CartId = 1, ProductId = 3, ProductCode = "10003", ProductQuantity = 1, ProductImageSrc = "~/Images/accent.png", ProductName = "Product3", ProductPrice = "3000" });
            CartItems.Add(new CartItem { CartId = 1, ProductId = 4, ProductCode = "10004", ProductQuantity = 1, ProductImageSrc = "~/Images/accent.png", ProductName = "Product4", ProductPrice = "4000" });
            CartItems.Add(new CartItem { CartId = 1, ProductId = 5, ProductCode = "10005", ProductQuantity = 1, ProductImageSrc = "~/Images/accent.png", ProductName = "Product5", ProductPrice = "5000" });
            return CartItems;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cart()
        {
            GetCartItems();
            return View("Cart", CartItems);
        }

        //public ActionResult Delete (int Id)
        //{
        //    return View("Cart", CartItems);
        //}

    }
}
