namespace InterfaceExercise;

class Program
{
    static void Main(string[] args)
    {
        List<Product> List = new List<Product>()
        {
            new Product("Älypuhelin", 500.99, 7),
            new Product("Älytabletti", 200.95, 10),
            new Product("Älykello", 100.99, 3)
        };

        Product p = new Product("Laturi", 9.95, 35);
        List.Add(p);

        foreach(Product product in List)
        {
            if (product.GetProduct("Laturi") != null)
            {
                Console.WriteLine("Laturi löytyi");
                Console.WriteLine("Varaston arvo: " + product.CalculateTotal() + " €");
                Console.WriteLine("--------");
            }
            Console.WriteLine(product);
        }
        Console.WriteLine();

        List<Customer> List2 = new List<Customer>()
        {
            new Customer("Jukka Pekka", 800),
            new Customer("Sauli Mauri", 1300),
            new Customer("Gilbert Albert", 2400)
        };

        foreach (Customer customer in List2)
        {
            if (customer.GetCustomer("Gilbert Albert") != null)
            {
                Console.WriteLine("Gilbert Albert");
                Console.WriteLine("Asiakkaan ostokset ovat bonuksien jälkeen " + customer.GetBonus() + " €");
                Console.WriteLine("--------");
            }
            Console.WriteLine(customer);
        }



    }
}

