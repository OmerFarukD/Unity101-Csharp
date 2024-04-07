// Kütüphane otomasyonu sisteminde 
// Kitap , Yazar ve Category tablolarıyla ilişki kuran ve gerekli crud(Oluşturma, Okuma, Güncelleme, silme)

// Kitap -> Id, Title , AuthorId, CategoryId, Price, Stock , Rengi
// Author -> Id, Name , Surname
// Category -> Id, Name

using OOP_Uygulama2.Models;

Author author = new Author(1,"Ömer","Seyfettin");
Category category = new Category(1,"Türk klasikleri");
Book book = new Book(1,"Kaşağı",1,1,250,300,"Siyah");
