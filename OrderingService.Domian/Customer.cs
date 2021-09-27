using System;

namespace OrderingService.Domian
{
    public class Customer
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Email { get; protected set; }
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
        public override string ToString()
        {
            return $"{nameof(FirstName)}:{FirstName},{nameof(LastName)}:{LastName},{nameof(Email)}:{Email}";
        }

    }
}
