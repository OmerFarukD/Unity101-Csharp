using OOP_Uygulama2.Models;

namespace OOP_Uygulama2.Repository;

public interface IBookRepository
{
    void Add(Book book);

    List<Book> GetAll();

    Book GetById(int id);

    void Delete(int id);
}
