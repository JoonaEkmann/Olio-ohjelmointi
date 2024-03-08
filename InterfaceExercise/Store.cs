using System;
namespace InterfaceExercise
{
	
	public class Store : iProducts, iCustomers
	{
		public string name;
		public double sales;
		public List<Product> products = new List<Product>();
		public List<Customer> customers = new List<Customer>();

        public Store(string name, double sales, List<Product> products, List<Customer> customers)
        {
            this.name = name;
            this.sales = sales;
            this.products = new List<Product>();
			this.customers = new List<Customer>();
        }

        public override string? ToString()
        {
            return $"{this.name}, {this.sales}, {this.products}, {this.customers}";
        }

        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }


        public void PrintCustomers()
        {
            throw new NotImplementedException();
        }

        public void PrintProducts()
        {
            throw new NotImplementedException();
        }
    }
	
}

