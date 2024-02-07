using OlioTehtäväNew;
public class Program
{
    public static void Main(string[] args)
    {
        Company comp1 = new Company("FinnairOyj", "vantaa", 04940285, 3834205, 2340582);
        Console.WriteLine($" voitto% on {+comp1.profit2():F2}");

        Company comp2 = new Company("Olvioyj", "helsinki", 0409570285, 823401, 83240);
        Console.WriteLine($" voitto% on {+comp2.profit2():F2}");

        Company comp3 = new Company(comp2);

        Console.ReadLine();
    }
}