using System;
namespace OlioTehtävätNew
{
    public class Employee
    {
        string name;
        int id;
        string position;
        double salary;

        public Employee(string name, int id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }

        internal void CompareSalary(Employee OtherEmployee)
        {
            if (this.salary > OtherEmployee.salary)
            {
                Console.WriteLine($"{this.name} palkka on suurempi kuin {OtherEmployee.name}");
            }

            else if (this.salary < OtherEmployee.salary)
            {
                Console.WriteLine($"{this.name} palkka on pienempi kuin {OtherEmployee.name}");
            }

            else if (this.salary == OtherEmployee.salary)
            {
                Console.WriteLine($"{this.name} palkka on yhtä suuri kuin {OtherEmployee.name}");
            }
        }

        public override string ToString()
        {
            return $"{this.name}, {this.id}, {this.position}, {this.salary}";
        }
    }
}

