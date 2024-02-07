using System;
namespace OlioTehtäväNew;

public class Company
{
    public string title;
    public string address;
    public double phonenumber;
    public double income;
    public double expenses;



    public Company()
    {
        this.title = string.Empty;
        this.address = string.Empty;
        this.income = 0;
        this.phonenumber = 0;
        this.expenses = 0;
    }

    public Company(string title, string address, int phonenumber, double income, double expenses)
    {
        this.title = title;
        this.address = address;
        this.phonenumber = phonenumber;
        this.income = income;
        this.expenses = expenses;

    }
    public Company(Company previouscompany)
    {
        title = previouscompany.title;
        address = previouscompany.address;
        phonenumber = previouscompany.phonenumber;
        income = previouscompany.income;
        expenses = previouscompany.expenses;
    }
    public double profit2()
    {
        double profit = (this.income - this.expenses) / this.expenses * 100;
        if (profit < 100)
        {
            Console.Write(this.title + " menee huonosti");
        }
        else if (profit >= 100 && profit < 200)
        {
            Console.Write(this.title + " menee välttävästi");
        }
        else if (profit >= 200 && profit < 300)
        {
            Console.Write(this.title + " menee tyydyttävästi");
        }
        else if (profit > 300)
        {
            Console.Write(this.title + " menee hyvin");
        }

        return profit;
    }
}
