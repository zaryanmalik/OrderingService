using System;

namespace OrderingService.Domian
{
    public class CartItem
    {
        public Cart cart { get; private set; }
        public int ProductId { get; private set; }
        public string ProductName { get; private set; }
        public double ProductPrice { get; private set; }
        public int ProductQuantity { get; private set; }
        public double TotalCost { get; private set; }
        public CartItem(Cart cart, int productId, string productName, double productPrice, int productQuantity)
        {
            this.cart = cart;
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            ProductQuantity = productQuantity;
            TotalCost = productQuantity * productPrice;
        }

        public static CartItem Create(Cart cart, int productId, string productName, double productPrice, int productQuantity)
        {
            if(string.IsNullOrWhiteSpace(productName))
                throw new ArgumentException("Value cannot be Null , Empty or Whitespace", nameof(productName));

            var cartItem = new CartItem(cart, productId, productName, productPrice, productQuantity);

            return cartItem;

        }
        public override string ToString()
        {
            return $"{nameof(ProductId)}:{ProductId},{nameof(ProductName)}:{ProductName},{nameof(ProductPrice)}:{ProductPrice}";
        }

    }
}
