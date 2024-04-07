namespace OOP_Uygulama2.Models;

public record BookCategoryResponseDto(
    int Id,
    string Title,
    string CategoryName,
    double Price,
    int stock
    );
