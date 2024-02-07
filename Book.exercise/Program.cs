namespace OlioTehtävätNew;

class Program
{
    static void Main(string[] args)
    {
        //Kirjojen tiedot ja tulostus
        Book book1 = new Book("Aapinen", "Pekka", "12345", 10);
        Book book2 = new Book("Virsikirja", "Jeesus", "54321", 20);

        Console.WriteLine(book1);

        //Verrataan kirjoja
        book1.CompareBook(book2);
    }
}

