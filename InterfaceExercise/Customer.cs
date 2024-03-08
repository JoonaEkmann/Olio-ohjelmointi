using System;
namespace InterfaceExercise
{
    public class Customer : iCustomer
	{
		public string CustomerName;
		public double Purchases;

        public Customer(string customerName, double purchases)
        {
            CustomerName = customerName;
            Purchases = purchases;
        }

        public override string? ToString()
        {
            return $"Asiakkaan {this.CustomerName}, ostoksien hinta {this.Purchases}€";
        }

        public Customer GetCustomer(string GetCustomerName)
        {
            if (this.CustomerName.ToLower() == GetCustomerName.ToLower())
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public double GetBonus()
        {
            if(Purchases <= 1000)
            {
                return Purchases * 0.98;
            }
            else if(Purchases <=2000)
            {
                return Purchases * 0.97;
            }
            else
            {
                return Purchases * 0.95;
            }

        }
    }
}

