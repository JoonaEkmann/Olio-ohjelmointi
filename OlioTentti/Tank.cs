using System;
using System.Xml.Linq;

namespace OlioTentti
{
    public class Tank : BaseTank
    {
        protected int kapasiteetti;
        protected int nesteMäärä;

        public Tank(string name, int kapasiteetti, int nesteMäärä) : base(name)
        {
            this.kapasiteetti = kapasiteetti;
            this.nesteMäärä = 0;
        }

        public override string ToString()
        {
            return $"säiliö {this.name}: kapasiteetti: {this.kapasiteetti}, nestettä: {this.nesteMäärä}";
        }

        //säiliöihin lisääminen
        public String AddToTank(int nesteMuutos)
        {
            if (nesteMuutos < 0)
            {
                return "säiliön " + name + " tilaa ei muutettu";
            }
            else if (nesteMäärä + nesteMuutos <= kapasiteetti)
            {
                nesteMäärä += nesteMuutos;
                return "säiliöön " + name + " lisättiin " + nesteMuutos + " yksikköä";
            }
            else
            {
                int lisättyNeste = kapasiteetti - nesteMäärä;
                nesteMäärä = kapasiteetti;
                if (nesteMäärä == kapasiteetti)
                {
                    return "säiliöön " + name + " lisättiin " + lisättyNeste + " yksikköä, säiliö on täynnä";
                }
                return "säiliöön " + name + " lisättiin " + lisättyNeste + " yksikköä";
            }
        }


        //säiliöistä poistaminen
        public String RemoveFromTank(int nesteMuutos)
        {
            if (nesteMuutos < 0 || nesteMäärä == 0)
            {
                return "säiliön " + name + " tilaa ei muutettu";
            }
            else if (nesteMuutos <= nesteMäärä)
            {
                nesteMäärä -= nesteMuutos;
                return "säiliöstä " + name + " poistettiin " + nesteMuutos + " yksikköä";
            }
            else
            {
                int poistettuNeste = nesteMäärä;
                nesteMäärä = 0;
                return "säiliöstä " + name + " poistettiin " + poistettuNeste + " yksikköä, säiliö on tyhjä";
            }
        }

        //säiliöiden tyhjentäminen
        public void ClearTank()
        {
            nesteMäärä = 0;
        }
    }
}

