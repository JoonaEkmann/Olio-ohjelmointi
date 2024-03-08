using System;
namespace InterfaceExercise
{
	public class Product : iProduct
	{
		public string name;
		public double price;
		public int count;

        public Product(string name, double price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
        }

        public double CalculateTotal()
        {
            return this.price * this.count;
        }

        public Product GetProduct(string name)
        {
            if (this.name.ToLower() == name.ToLower())
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public override string? ToString()
        {
            return $"{this.name}, {this.price}€, {this.count}kpl, varaston arvo {this.CalculateTotal()}€";
        }
    }
}

