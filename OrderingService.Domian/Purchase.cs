using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace OrderingService.Domian
{
    public class Purchase
    {
        private List<CartItem> products = new List<CartItem>();
        public ReadOnlyCollection<CartItem> Products
        {
            get { return products.AsReadOnly(); }
        }
        public int Id;
        public DateTime DateCreated;
        public Customer Customer { get; protected set; }

        public static Purchase Create(Customer customer, ReadOnlyCollection<CartItem> products)
        {
            Purchase purchase = new Purchase()
            {
                products = products.ToList(),
                DateCreated = DateTime.Now,
                Customer = customer
            };
            return purchase;
        }
        public override string ToString()
        {
            return $"{nameof(Customer)}:{Customer},{nameof(DateCreated)}:{DateCreated}";
        }

        public void GetInvoice()
        {
            foreach(var item in Products)
            {
                Console.WriteLine($"{item.cart.customer}" +
                $"Product Id:{item.ProductId}" +
                $"Product Name:{item.ProductName} " +
                $"Product Price:{item.ProductPrice}" +
                $"Product Quantity:{item.ProductQuantity}" +
                $"Total Bill:{item.TotalCost}");
            }
        }
    }
}