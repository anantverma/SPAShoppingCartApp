using SPAShoppingCartApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPAShoppingCartApp.Controllers
{
    public class CartController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddToCart(int productId, int quantity)
        {
            if (Session["ShoppingCart"] == null)
            {
                List<CartItem> ItemsInCart = new List<CartItem>();
                Product productToBeAdded = new Product();
                ItemsInCart.Add(new CartItem(productToBeAdded,quantity));
                Session["ShoppingCart"] = ItemsInCart;
            }
            else
            {
                List<CartItem> ItemsInCart = (List<CartItem>)Session["ShoppingCart"];
                Product productToBeAdded = new Product();
                ItemsInCart.Add(new CartItem(productToBeAdded, quantity));
                Session["ShoppingCart"] = ItemsInCart;
            }

            return View("Cart");
        }

        private bool IsItemAlreadyInCart(int productId)
        {
            List<CartItem> ItemsInCart = (List<CartItem>)Session["ShoppingCart"];
        }
    }
}
