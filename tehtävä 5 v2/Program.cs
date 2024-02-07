using OlioTehtävätNew;

class Program
{
    static void Main(string[] args)
    {
        //työntekijöiden luominen
        Employee[] employees = new Employee[4];
        employees[0] = new Employee("Puuha Pete", 98765, "Talonmies", 2000);
        employees[1] = new Employee("Make Rake", 54321, "Insinööri", 2500);
        employees[2] = new Employee("Jukka Poika", 56789, "Siivooja", 2500);
        employees[3] = new Employee("Pekka Töpöhäntä", 12345, "Päällikkö", 6000);

        //Selittää työntekijät
        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee);
        }

        //Vertaillaan työntekijöiden palkkoja
        for (int i = 0; i < employees.Length; i++)
        {
            int nextIndex = (i + 1) % employees.Length;
            employees[i].CompareSalary(employees[nextIndex]);
        }
        Console.ReadKey();
    
    }
}






