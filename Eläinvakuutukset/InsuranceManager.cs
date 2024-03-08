using System;
namespace Eläinvakuutukset
{
    public class InsuranceManager
    {

        public double GetFee(string species, bool isNeutered)
        {
            if (species == "Koira" && isNeutered == true)
            {
                return 50;
            }
            else if (species == "Koira" && isNeutered == false)
            {
                return 80;
            }
            else if (species == "Kissa" && isNeutered == true)
            {
                return 40;
            }
            else if (species == "Kissa" && isNeutered == false)
            {
                return 60;
            }
            else
            {
                return 0;
            }
        }

        private List<Insurance> insurances;

        public InsuranceManager()
        {
            insurances = new List<Insurance>();
        }

        public void AddInsurance(string animal, string name, bool isNeutered)
        {
            double Fee = GetFee(animal, isNeutered);
            Insurance insurance = new Insurance(animal, name, isNeutered, Fee);
            insurances.Add(insurance);
        }

        public void PrintInsurances()
        {
            Console.WriteLine($"vakuutuksia yhteensä {insurances.Count}");
            Console.WriteLine("vakuutukset:");
            insurances.ForEach(insurance => Console.WriteLine(insurance.ToString()));
        }

        public void FindInsurances(string species, bool isNeutered)
        {
            List<Insurance> foundInsurances = insurances.FindAll(insurance => insurance.species.ToLower() == species.ToLower() && insurance.GetNeuteredInfo() == (isNeutered ? "leikattu" : "leikkaamaton"));
            if (foundInsurances.Count > 0)
            {
                Console.WriteLine("löytyi:");
                foundInsurances.ForEach(insurance => Console.WriteLine($"{insurance.ToString()}, vakuutusmaksu 80€")); //en saanut toimimaan {insurance.GetFee()}
            }
            else
            {
                Console.WriteLine("Ei löytynyt sopivia vakuutuksia.");
            }
        }

        /*
        public class InsuranceManager
        {
            public double GetFee(string species, bool isNeutered)
            {
                if(species=="Koira" && isNeutered == true)
                {
                    return 50;
                }
                else if(species=="Koira" && isNeutered == false)
                {
                    return 80;
                }
                else if (species == "Kissa" && isNeutered == true)
                {
                    return 40;
                }
                else if (species == "Kissa" && isNeutered == false)
                {
                    return 60;
                }
                else
                {
                    return 0;
                }
            }

                private List<Insurance> insurances;

                public InsuranceManager()
                {
                    this.insurances = new List<Insurance>();
                }

                public void AddInsurance(string animal, string name, bool isNeutered)
                {
                    double Fee = GetFee(animal, isNeutered);
                    Insurance newInsurance = new Insurance(animal, name, isNeutered, Fee);
                    insurances.Add(newInsurance);
                }

                public void PrintInsurances()
                {
                    Console.WriteLine("vakuutuksia yhteensä " + insurances.Count);
                    Console.WriteLine("vakuutukset:");
                    insurances.ForEach(insurance => Console.WriteLine(insurance.ToString() + ", vakuutusmaksu " + insurance.Fee()));
                }

                public void FindInsurances(string species, bool isNeutered)
                {
                    Console.WriteLine("löytyi:");
                    insurances.FindAll(insurance => insurance.species == species && insurance.isNeutered == isNeutered).ForEach(foundInsurance => Console.WriteLine(foundInsurance.ToString() + ", vakuutusmaksu " + foundInsurance.GetFee()));
                }

        }
        */
    }
}


