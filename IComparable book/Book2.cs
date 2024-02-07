using System;
namespace OlioTehtävätNew
{
    public class Book : IComparable<Book>
    {
        string title;
        string author;
        string id;
        double price;

        public Book(string title, string author, string id, double price)
        {
            this.title = title;
            this.author = author;
            this.id = id;
            this.price = price;
        }

        public override string ToString()
        {
            return $"{this.title}, {this.author}, {this.id}, {this.price}€/kpl";
        }

        public int CompareTo(Book other)
        {
            //pienimmästä suurimpaan hinnan mukaan
            return this.price.CompareTo(other.price);
        }
        
        public void CompareBook(Book otherBook)
        {
            if (this.price > otherBook.price)
            {
                Console.WriteLine($"{this.title} on kalliimpi kuin {otherBook.title}");
            }

            else if (this.price < otherBook.price)
            {
                Console.WriteLine($"{this.title} on halvempi kuin {otherBook.title}");
            }

            else if (this.price == otherBook.price)
            {
                Console.WriteLine($"{this.title} on saman hintainen kuin {otherBook.title}");
            }
        }
        
    }
}

