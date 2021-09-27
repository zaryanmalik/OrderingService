using System;
using System.Collections.Generic;

namespace OrderingService.Domian
{
    public class Cart
    {
        public Customer customer;

        public List<CartItem> Products = new List<CartItem>();

        private Cart(Customer customer)
        {
            this.customer = customer;
        }
        public void AddItem(CartItem cartItem1)
        {
            this.Products.Add(cartItem1);
        }

        public static Cart Create(Customer cust)
        {
            var customer = new Cart(cust);
            return customer;
        }
    }
}
