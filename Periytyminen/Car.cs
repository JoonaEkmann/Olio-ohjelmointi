using System;
using System.Runtime.ConstrainedExecution;

namespace Periytyminen
{
	public class Car: Vehicle
	{
		protected double moottorinKoko;
        protected string moottorinMalli;
        protected string ovienLukumäärä;

        public Car(string merkki, string malli, int vuosiMalli, double hinta, double moottorinKoko, string moottoriMalli, string ovienLukumäärä) :base(merkki, malli, vuosiMalli, hinta)
        { 
            this.moottorinKoko = moottorinKoko;
            this.moottorinMalli = moottoriMalli;
            this.ovienLukumäärä = ovienLukumäärä;
        }

        public override string ToString()
        {
            return $"{this.merkki} {this.malli}, {this.vuosiMalli}, {this.hinta}€, {this.moottorinKoko}litraa, {this.moottorinMalli}, {this.ovienLukumäärä} ovea";
        }

        public override bool Equals(object? obj)
        {
            Car? other = obj as Car;
            if (other == null)
                return false;
            if (this.ovienLukumäärä != other.ovienLukumäärä || this.moottorinKoko != other.moottorinKoko)
                return false;
            return true;
        }



    }
}

