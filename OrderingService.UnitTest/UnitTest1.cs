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
            var cust1 = Customer.Create("Zaryan", "Malik", "bscs.f14.13gmail.com");
            var cart = Cart.Create(cust1);
            foreach (var item in cart.Products)
            {

                var totalcost = item.ProductQuantity * item.ProductPrice;
                NUnit.Framework.Assert.AreEqual(17.97, totalcost);
                
            }
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