namespace InterfaceExercise;

class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>()
        {
            new Product("Älypuhelin", 500.99, 7),
            new Product("Älytabletti", 200.95, 10),
            new Product("Älykello", 100.99, 3)
        };

        Product p = new Product("Laturi", 9.95, 35);
        list.Add(p);

        foreach(Product product in list)
        {
            if (product.GetProduct("Laturi") != null)
            {
                Console.WriteLine("Laturi löytyi");
                Console.WriteLine("Varaston arvo: " + product.CalculateTotal() + " €");
                Console.WriteLine("--------");
            }
            Console.WriteLine(product);
        }
        

    }
}

