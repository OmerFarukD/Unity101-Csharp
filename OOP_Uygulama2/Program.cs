// Kütüphane otomasyonu sisteminde 
// Kitap , Yazar ve Category tablolarıyla ilişki kuran ve gerekli crud(Oluşturma, Okuma, Güncelleme, silme)

// Kitap -> Id, Title , AuthorId, CategoryId, Price, Stock , Rengi
// Author -> Id, Name , Surname
// Category -> Id, Name

using OOP_Uygulama2.Models;
using OOP_Uygulama2.Repository;

IBookRepository bookRepository = new BookRepository();
IAuthorRepository authorRepository = new AuthorRepository();
ICategoryRepository categoryRepository = new CategoryRepository();  


List<Book> books = bookRepository.GetAll();
List<Author> authors = authorRepository.GetAll();
List<Category> categories= categoryRepository.GetAll();



// Kitapları listeleyen kodu ekran çıktısı olarak veriniz.

//Console.WriteLine("Kitapları listeleyiniz.");
//foreach (Book book in books)
//{
//    Console.WriteLine(book);
//}

// 2. Yöntem
//books.ForEach(book=> Console.WriteLine(book));


// todo: Kitapların  CategoryId si 2 olan kitapları listeleyiniz.
//Console.WriteLine("CategoryId si 2 olan kitapları listeleyiniz.");

//foreach (Book book in books)
//{
//    if (book.CategoryId == 2)
//    {
//        Console.WriteLine(book);
//    }
//}

//2. Yöntem
//List<Book> filteredBooks = books.Where(x=> x.CategoryId==2).ToList();
//filteredBooks.ForEach(x=> Console.WriteLine(x));

// AuthorId si 2 olan bütün kitapları listeleyen kodu yazınız.
//books
//   .Where(x => x.AuthorId == 2)
//   .ToList()
//   .ForEach(a=> Console.WriteLine(a));


// todo: Kitaplar listesinde Kitap başlığı(Title) içerisinde "Suç" kelimesi geçen kitapları listeleyiniz.

//foreach (Book book in books)
//{
//    if (book.Title.Contains("Suç"))
//    {
//        Console.WriteLine(book);
//    }
//}

//books.Where(x => x.Title.Contains("Suç"))
//    .ToList()
//    .ForEach(c => Console.WriteLine(c));


// todo : Kitapların ürün fiyatlarının toplamını ve ortalamasını ekrana bastıran kodu yazınız.

//double total = 0;
//foreach (Book book in books)
//{
//    total += book.Price;
//}

//double average = total / books.Count;
//Console.WriteLine($"Kitapların fiyatları toplamı : {total}");
//Console.WriteLine($"Kitapların fiyat ortalamasını hesaplayınız : {average}");

//2. Yöntem

//double total = books.Sum(x=> x.Price);
//double average = books.Average(x=> x.Price);
//Console.WriteLine($"Kitapların fiyatları toplamı : {total}");
//Console.WriteLine($"Kitapların fiyat ortalamasını hesaplayınız : {average}");

// todo : AuthorId si 2 olan bütün kitapların toplamını ve ortalamasını ekrana bastıran kodu yazınız.
//double total = books.Where(x => x.AuthorId == 2).Sum(b=>b.Price);
//double average = books.Where(x => x.AuthorId == 2).Average(X=>X.Price);
//Console.WriteLine($"YazarId si 2 olan Kitapların fiyatları toplamı : {total}");
//Console.WriteLine($"YazarId si 2 olan Kitapların fiyat ortalamasını hesaplayınız : {average}");

// todo : CategoryId si 4 olan kitap var mı ?
// todo : CategoryId si 3 olan kitap var mı ?

//Console.WriteLine($"CategoryId si 4 olan kitap var mı :{books.Any(x=>x.CategoryId==4)} ");
//Console.WriteLine($"CategoryId si 3 olan kitap var mı :{books.Any(x => x.CategoryId == 3)}");


// todo : Kitaplar listesinde sadece Title kısmını ekrana bastıran kodu yazınız.
//foreach (Book book in books)
//{
//    Console.WriteLine(book.Title);
//}

//2. Yöntem
//books.Select(b => b.Title)
//    .ToList()
//    .ForEach(x => Console.WriteLine(x));


// todo : CategoryId lerine göre Kitaplar gruplandıran ve listeleyen kodu yazınız.

//var groupedBooks = books.GroupBy(x => x.CategoryId).ToDictionary(b=>b.Key, g=>g.ToList());

//foreach (var group in groupedBooks)
//{
//    Console.WriteLine($"{group.Key} CategoryId sine ait kitaplar");

//    foreach (var book in group.Value)
//    {
//        Console.WriteLine(book);
//    }
//}

// todo : Kitaplar listesini Kitap fiyatına göre artan şekilde sıralayan kodu yazınız.

//Console.WriteLine("Fiyat durumuna göre artan bir şekilde sıralayınız.");
//books.OrderBy(x => x.Price)
//    .ToList()
//    .ForEach(b => Console.WriteLine(b));


// todo : Kitaplar listesini Kitap fiyatına göre azalan şekilde sıralayan kodu yazınız.
//Console.WriteLine("Fiyat durumuna göre azalan bir şekilde sıralayınız.");
//books.OrderByDescending(x => x.Price)
//    .ToList()
//    .ForEach(b => Console.WriteLine(b));


// todo : Kitaplar listesini Kitap stoğuna göre artan şekilde sıralayan kodu yazınız.
//books.OrderBy(x => x.Stock)
//    .ToList()
//    .ForEach(b => Console.WriteLine(b));


// todo : Kitaplar listesini Kitap stoğuna göre azalan şekilde sıralayan kodu yazınız.
//books.OrderByDescending(x => x.Stock)
//    .ToList()
//    .ForEach(b => Console.WriteLine(b));


//foreach (Book book in books)
//{
//    Console.WriteLine(book);
//}
// kullanıcıyua sadece şu bilgileri göstermek istiyorum
// Id, Title, CategoryName, AuthorName, AuthorSurname, Price, Stock

//var responseDto = from b in books
//                  join c in categories on b.CategoryId equals c.Id
//                  join a in authors on b.AuthorId equals a.Id
//                  select new BookResponseDto(
//                      Id: b.Id,
//                      Title : b.Title,
//                      CategoryName: c.name,
//                      AuthorName: a.Name,
//                      AuthorSurName: a.Surname,
//                      Price: b.Price,
//                      stock: b.Stock
//                      );

//responseDto.ToList().ForEach(x=> Console.WriteLine(x));

// Kullanıcıya Id, Title, CategoryName, Price, stock değerlerini tutan kitap ve kategori bilgilerini ekranda gösteriniz.

//var response = from b in books
//               join c in categories on b.CategoryId equals c.Id
//               select new BookCategoryResponseDto(
//                   Id:b.Id,
//                   Title: b.Title,
//                   CategoryName: c.name,
//                   Price: b.Price,
//                   stock: b.Stock
//                   );
//response.ToList().ForEach( book => Console.WriteLine(book));

//2. Yöntem 
 books.Join(categories,
    book=> book.CategoryId,
    ct => ct.Id,
    (b,c)=> new BookCategoryResponseDto(
          Id: b.Id,
          Title: b.Title,
          CategoryName: c.name,
          Price: b.Price,
          stock: b.Stock
        )
    ).ToList()
    .ForEach(x=> Console.WriteLine(x));
