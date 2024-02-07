using System;
namespace Periytyminen
{
	public abstract class Vehicle
	{
		protected string merkki;
		protected string malli;
		protected int vuosiMalli;
		protected double hinta;

		protected Vehicle(string merkki, string malli, int vuosiMalli, double hinta)
		{
			this.merkki = merkki;
			this.malli = malli;
			this.vuosiMalli = vuosiMalli;
			this.hinta = hinta;
		}

		//tulostaa vehiclen tiedot
        public override string ToString()
        {
            return $"{this.merkki} {this.malli} {this.vuosiMalli} {this.hinta}";
        }




    }
}

