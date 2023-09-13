namespace HomaTask_41.N36_HT2;

public class Book
{
    public static (string Title, string Author, DateTime publishedYear)
                    CrateBook(string Title, string Author, DateTime publishedYear)
    {
        return (Title: Title, Author: Author, PublishedYear: publishedYear);
    }
    
}