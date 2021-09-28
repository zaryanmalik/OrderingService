using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace OrderingService.Domian
{
    public class Customer
    {
        private List<Purchase> purchases = new List<Purchase>();
        public ReadOnlyCollection<Purchase> Purchases 
        { 
            get 
            { 
                return this.purchases.AsReadOnly(); 
            }
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        protected Customer(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public static Customer Create(string firstName, string lastName, string email)
        {

            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("Value cannot be Null , Empty or Whitespace", nameof(firstName));
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Value cannot be Null , Empty or Whitespace", nameof(lastName));
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Value cannot be Null , Empty or Whitespace", nameof(email));
            var customer = new Customer(firstName, lastName, email);

            return customer;
        }
        public Purchase Checkout(Cart cart)
        {
            Purchase purchase = Purchase.Create(this, cart.GetProducts);
            this.purchases.Add(purchase);
            return purchase;
        }

        public override string ToString()
        {
            return $"{nameof(FirstName)}:{FirstName},{nameof(LastName)}:{LastName},{nameof(Email)}:{Email}";
        }

    }
}
