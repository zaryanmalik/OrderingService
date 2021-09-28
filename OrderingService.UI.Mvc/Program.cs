
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
            cart.AddItem(1001, "Milk Bottle", 5.99, 3);

            var cust2 = Customer.Create("Hanan", "Mumtaz", "Hanan@gmail.com");
            var cart1 = Cart.Create(cust2);
            cart1.AddItem(1001, "Sun Glasses", 5.00, 3);
          
            /*foreach (var item in cart.GetProducts)
            {
               
                Console.WriteLine($"{item.cart.customer}" +
                    $"Product Id:{item.ProductId}" +
                    $"Product Name:{item.ProductName} " +
                    $"Product Price:{item.ProductPrice}" +
                    $"Product Quantity:{item.ProductQuantity}");

                var totalcost = item.ProductQuantity * item.ProductPrice;   
                Console.WriteLine($"Total cost : {totalcost}");

            }*/

            Purchase purchase = cust1.Checkout(cart);
            Purchase purchase1 = cust1.Checkout(cart1);
            purchase.GetInvoice();
            purchase1.GetInvoice();

        }
    }
}
