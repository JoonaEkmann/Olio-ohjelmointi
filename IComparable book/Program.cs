namespace OlioTehtävätNew;

class Program
{
    static void Main(string[] args)
    {
        List<Book> bookList = new List<Book>();

        bookList.Add(new Book("Aapinen", "Pekka", "12345", 40));
        bookList.Add(new Book("Virsikirja", "Jeesus", "54321", 10));
        bookList.Add(new Book("Aakkoset", "Tero", "98765", 15));
        bookList.Add(new Book("Musiikkikirja", "Kaija Koo", "56789", 30));

        //Tulostaa kirjojen järjestyksen hinnan mukaan pienimmästä suurimpaan
        bookList.Sort();
        foreach (Book currentBook in bookList)
        {
            Console.WriteLine(currentBook);
        }

        Console.ReadKey();


    }
}

