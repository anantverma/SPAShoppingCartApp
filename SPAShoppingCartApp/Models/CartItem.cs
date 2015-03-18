using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPAShoppingCartApp.Models
{
    public class CartItem
    {
        private int _itemQuantity;
        private Product _productToOrder;

        public Product ProductToOrder
        {
            get { return _productToOrder; }
            set { _productToOrder = value; }
        }

        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set { _itemQuantity = value; }
        }

        public CartItem( Product product, int quantityOfProduct)
        {
            _itemQuantity = quantityOfProduct;
            _productToOrder = product;
        }
    }
}