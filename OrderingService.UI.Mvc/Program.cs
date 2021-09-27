
using OrderingService.Domian;
using System;
using System.Linq;

namespace OrderingService.UI.Mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cust1 = Customer.Create("Zaryan", "Malik", "bscs.f14.13gmail.com");
            var cart = Cart.Create(cust1);//Do it using Ceate Method
            var cartItem1 = CartItem.Create(cart ,1001, "Milk Bottle", 5.99, 3);
            cart.AddItem(cartItem1);

            var cust2 = Customer.Create("Hanan", "Mumtaz", "Hanan@gmail.com");
            var cart1 = Cart.Create(cust2);
            var cartItem2 = CartItem.Create(cart1, 1001, "Sun Glasses", 5.99, 3);
            cart1.AddItem(cartItem2);

            foreach (var item in cart.Products)
            {
               
                Console.WriteLine($"{item.cart.customer}->{item.ProductId}->{item.ProductName}->" +
                $"{item.ProductPrice}->{item.ProductQuantity}");

                var totalcost = cart.Products.Sum(x => x.ProductQuantity * x.ProductPrice);
                Console.WriteLine($"Total cost : {totalcost}");

            }
        }
    }
}
