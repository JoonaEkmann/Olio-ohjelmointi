using System;
using System.Collections;
using System.Collections.Generic;

namespace OlioTentti;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--Säiliöiden luominen");
        Console.WriteLine();

        Console.WriteLine("Tulostetaan säiliöiden lähtötilanne");
        List<Tank> tanks = new List<Tank>()
        {
            new Tank("VESI", 100, 0),
            new Tank("RYPSIÖLJY", 100, 0),
            new Tank("OLIIVIÖLJY", 150, 0)
        };

        foreach (Tank tank in tanks)
        {
            Console.WriteLine(tank);
        }

        Console.WriteLine();
        Console.WriteLine("--Säiliöihin lisääminen");
        Console.WriteLine(tanks[0].AddToTank(110));
        Console.WriteLine(tanks[1].AddToTank(70));
        Console.WriteLine(tanks[2].AddToTank(-50)); 



        Console.WriteLine();
        Console.WriteLine("--Säiliöistä poistaminen");
        Console.WriteLine(tanks[0].RemoveFromTank(80));
        Console.WriteLine(tanks[1].RemoveFromTank(80));
        Console.WriteLine(tanks[2].RemoveFromTank(80));
    



        Console.WriteLine();
        Console.WriteLine("--Säiliöiden tyhjennys");
        foreach (Tank tank in tanks)
        {
            tank.ClearTank();
        }


        Console.WriteLine();
        Console.WriteLine("--Tulostetaan säiliöiden lopputilanne");
        foreach (Tank tank in tanks)
        {
            Console.WriteLine(tank);
        }
    }
}

