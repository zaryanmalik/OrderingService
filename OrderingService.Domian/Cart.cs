using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OrderingService.Domian
{
    public class Cart
    {
        
        public Customer customer { get; private set; }

        private List<CartItem> products = new List<CartItem>();
        public ReadOnlyCollection<CartItem> GetProducts
        {
            get { return products.AsReadOnly(); }
        }
        private Cart(Customer customer)
        {
            this.customer = customer;
        }
        public void AddItem(int productId, string productName, double amount, int qunatity)
        {
            var cartitem = new CartItem(this, productId, productName, amount, qunatity);
            products.Add(cartitem);
        }

        public static Cart Create(Customer cust)
        {
            var customer = new Cart(cust);
            return customer;
        }
    }
}
