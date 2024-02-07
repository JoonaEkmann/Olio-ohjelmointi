using System;
using System.Runtime.ConstrainedExecution;
namespace Periytyminen
{
    internal class truck : Car
    {
        private double kuorma;
        private double kulutus;

        public truck(string merkki, string malli, int vuosiMalli, double hinta, double moottorinKoko, string moottoriMalli, string ovienLukumäärä, double kuorma, double kulutus)
            :base(merkki, malli, vuosiMalli, hinta, moottorinKoko, moottoriMalli, ovienLukumäärä)
        {
            this.kuorma = kuorma;
            this.kulutus = kulutus;
        }

        public override string ToString()
        {
            return $"{this.merkki} {this.malli}, {this.vuosiMalli}, {this.hinta}€, {this.moottorinKoko}litraa, {this.moottorinMalli}, {this.ovienLukumäärä} ovea, {this.kuorma}kg, {this.kulutus}l/100km";
        }

        public double calculateconsumption()
        {
            return kuorma * kulutus;

        }
        public double tostring()
        {
            base.ToString();
            Console.WriteLine($"kuormaauton paino{kuorma}");
            Console.WriteLine($"kuormaauton kulutus{kulutus}");
            return calculateconsumption();
        }

    }
}
