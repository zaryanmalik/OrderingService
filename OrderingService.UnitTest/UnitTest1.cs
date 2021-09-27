using System;
using Xunit;
using OrderingService.Domian;
using System.Linq;

namespace OrderingService.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void CalculateTotal()
        {
            
            /*var cart = new Cart();
            foreach (var item in cart.Products)
            {
                Console.WriteLine($"{item.customer}->{item.ProductId}->{item.ProductName}->" +
                $"{item.ProductPrice}->{item.ProductQuantity}");

                var totalcost = cart.Products.Sum(x => x.ProductQuantity * x.ProductPrice);
                NUnit.Framework.Assert.AreEqual(117.97, totalcost);
                Console.WriteLine($"Total cost : {totalcost}");
            }*/
        }

        [Fact]
        public void GetCustomerTest()
        {
            var firstName = "Zaryan";
            var cust1 = Customer.Create("Zaryan", "Malik", "bscs.f14.13gmail.com");
            NUnit.Framework.Assert.AreEqual(firstName, cust1.FirstName);
        }
    }
}