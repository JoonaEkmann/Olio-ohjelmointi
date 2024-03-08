namespace Car.exercise;

class Program
{
    static void Main(string[] args)
    {
        //Ensimmäinen auto
        Car car1 = new Car("merkki",0);

        //Merkin sekä nopeuden kysely
        car1.AskData(); 
        car1.ShowCarInfo();
        car1.Accelerate(20);
        car1.ShowCarInfo();



        //Toinen auto
        Car car2 = new Car("merkki",0);

        //Merkin sekä nopeuden kysely
        car2.AskData();
        car2.ShowCarInfo();
        car2.Accelerate(-10); 
        car2.ShowCarInfo();
    }
}

