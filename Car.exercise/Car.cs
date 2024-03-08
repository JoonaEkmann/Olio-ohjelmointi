using System;
namespace Car.exercise
{
	public class Car
	{
        string merkki;
        int nopeus;

        public Car(string merkki, int nopeus)
        {
            this.merkki = merkki;
            this.nopeus = nopeus;
        }

        public void AskData()
        {
            Console.Write("Anna auton merkki: ");
            merkki = Console.ReadLine();

            Console.Write("Anna auton nopeus: ");
            nopeus = int.Parse(Console.ReadLine());
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Merkki: {this.merkki}. Nopeus: {this.nopeus}km/h");
        }

        public void Accelerate(int change)
        {
            if (change < 0)
            {
                Console.WriteLine("Nopeuden pitää olla positiivinen luku.");
            }
            else
            {
                nopeus += change;
                Console.WriteLine($"Nopeus kasvaa {change} km/h.");
            }
        }
    }
}

