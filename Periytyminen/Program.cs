namespace Periytyminen;

class Program
{
    static void Main(string[] args)
    {
        //2 autoa
        Car bmw = new Car("Bmw", "320ci", 2005, 7000, 2.2, "m54", "3");
        Car audi = new Car("Volkswagen", "Bora", 2001, 2500, 1.6, "16v", "5");
        //1 rekka
        truck volvo = new truck("Volvo", "FH", 2020, 90000, 6.2, "2jz", "2", 32000, 9.2);


        Console.WriteLine("Ensimmäinen auto");
        Console.WriteLine(bmw.ToString());

        Console.WriteLine("Toinen auto");
        Console.WriteLine(audi.ToString());

        Console.WriteLine("Ensimmäinen rekka");
        Console.WriteLine(volvo.ToString());

        Console.WriteLine();

        Console.WriteLine("Vertailu");
        Console.WriteLine("Bmw sama kuin Audi?: " +bmw.Equals(audi));

        Console.WriteLine("Vertailu");
        Console.WriteLine("Audi on sama kuin Volvo?: " + bmw.Equals(volvo));

        Console.WriteLine();

        Console.WriteLine("Volvon kulutus 32000kg kuorman kanssa");
        Console.WriteLine($"Volvon kulutus: {volvo.calculateconsumption()}/kg");


    }
}

