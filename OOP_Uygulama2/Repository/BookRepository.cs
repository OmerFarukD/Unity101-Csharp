using OOP_Uygulama2.Models;

namespace OOP_Uygulama2.Repository;

public class BookRepository : IBookRepository
{
    private List<Book> books;

    public BookRepository()
    {
        books = new List<Book>()
        {
            new Book(1,"Kaşağı",1,1,250,300,"Siyah"),
            new Book(2,"Kumarbaz",2,2,50,1000,"Kırmızı"),
            new Book(3,"Suç ve Ceza-1",2,2,150,500,"Yeşil"),
            new Book(4,"Suç ve Ceza-2",2,2,600,800,"Siyah"),
            new Book(5,"Suç ve Ceza-3",2,2,200,600,"Sarı"),
            new Book(6,"Yeraltından Notlar",2,2,650,300,"Beyaz"),
            new Book(7,"Harry Potter",3,3,550,450,"Gri")
        };
    }

    public void Add(Book book)
    {
        books.Add(book);
    }

    public void Delete(int id)
    {
        // LINQ -> Language Integrated Query
        Book? book = books.SingleOrDefault(x=> x.Id == id);
        books.Remove(book);
    }

    public List<Book> GetAll()
    {
        return books.ToList();
    }

    public Book GetById(int id)
    {
        Book? book = books.SingleOrDefault(x => x.Id == id);
        return book;
    }
}
