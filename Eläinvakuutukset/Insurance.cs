using System;
namespace Eläinvakuutukset
{
    public class Insurance
    {
        internal bool isNeutered;
        public string species;
        public string name;
        public bool neutered;
        public double Fee;
        public Insurance(string animal, string name, bool isNeutered, double payment)
        {
            this.species = animal;
            this.name = name;
            this.neutered = isNeutered;
            this.Fee = payment;
        }
        public string GetNeuteredInfo()
        {
            if (neutered)
            {
                return "leikattu";
            }
            else
            {
                return "leikkaamaton";
            }
        }
        public override string? ToString()
        {
            return this.species + ": " + this.name + ", " + this.GetNeuteredInfo();
        }
    }
}

