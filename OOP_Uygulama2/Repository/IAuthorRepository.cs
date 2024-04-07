using OOP_Uygulama2.Models;

namespace OOP_Uygulama2.Repository;

internal interface IAuthorRepository
{
    void Add(Author author);
    List<Author> GetAll();
    Author GetById(int id);
    void Delete(int id);
}
