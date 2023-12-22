var book = new Book("Aba","bab",2);
book.Tittle = Console.ReadLine();
book.Author = Console.ReadLine();
book.Year = Convert.ToInt32(Console.ReadLine());

class Book
{
    public string Tittle;
    public string Author;
    public int Year;

    public Book(string tittle,string author,int year)
    {
        Tittle=tittle;
        Author=author;
        Year=year;
    }
    public string Getinfo()
    {
        return $"{Tittle}\nWriter:{Author}\nRelease date:{Year}";
    }
    public string IsPublishedRecently()
    {
        if(Year > 2010) {return $"true";}
        else {return $"false";}
    }
}