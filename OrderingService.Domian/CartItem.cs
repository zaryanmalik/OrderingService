using System;

namespace OrderingService.Domian
{
    public class CartItem
    {
        public Cart cart { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public CartItem(Cart cart, int productId, string productName, double productPrice, int productQuantity)
        {
            this.cart = cart;
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            ProductQuantity = productQuantity;
        }

        public static CartItem Create(Cart cart, int productId, string productName, double productPrice, int productQuantity)
        {
            if(string.IsNullOrWhiteSpace(productName))
                throw new ArgumentException("Value cannot be Null , Empty or Whitespace", nameof(productName));

            var cartItem = new CartItem(cart, productId, productName, productPrice, productQuantity);

            return cartItem;

        }

    }
}
