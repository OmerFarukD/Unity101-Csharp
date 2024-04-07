
namespace OOP_Uygulama2.Models;

// record : Sadece data taşıyan immutable( değiştirilemez) classlardır.
public record Book(int Id,
    string Title,
    int AuthorId, 
    int CategoryId, 
    double Price,
    int Stock,
    string Color
    );
