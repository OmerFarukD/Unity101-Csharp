namespace OOP_Uygulama2.Models;

public record BookResponseDto
    (
    int Id,
    string Title,
    string CategoryName,
    string AuthorName,
    string AuthorSurName,
    double Price,
    int stock
    );