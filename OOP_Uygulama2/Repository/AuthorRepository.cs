using OOP_Uygulama2.Models;

namespace OOP_Uygulama2.Repository;

public class AuthorRepository : IAuthorRepository
{

    private List<Author> _authors;

    public AuthorRepository()
    {
        _authors = new List<Author>()
        {
            new Author(1,"Ömer","Seyfettin"),
            new Author(2,"Fyodor","Dostoyevski"),
            new Author(3,"J.K","Rowling")
    };
    }

    public void Add(Author author)
    {
        _authors.Add(author);
    }

    public void Delete(int id)
    {
        Author? author = _authors.SingleOrDefault(a=> a.Id == id);

        if (author == null)
        {
            // Exception Fırlat
        }

        _authors.Remove(author);
    }

    public List<Author> GetAll()
    {
        return _authors;
    }

    public Author GetById(int id)
    {
        Author? author = _authors.SingleOrDefault(a => a.Id == id);

        if (author == null)
        {
            // Exception Fırlat
        }
        return author;

    }
}
