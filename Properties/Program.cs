// Bir e ticaret uygulamasında ürün oluşturulurken ürünün bazı özellikleri var
// ürünün adı : Ürün adı minimum 2 karakterli olmalıdır
// ürünün değeri : ürünün değeri negatif değerler alamaz
//2-) ürünün değerini kullanıcı girdikten sonra kdv li fiyatını müşteriye gösteriniz.

// ürünün stok değeri : negatif değer alamaz 
// ürünün satıcısı :  ürün satıcısı alanı minimum 2 karakterli olmalıdır.
// ürünün kategorisi : ürün satıcısı alanı minimum 2 karakterli olmalıdır.

using Properties;

Product product = new Product()
{
    Name = "Msi Bravo",
    CategoryName = "Bilgisayar",
    Owner = "MSI",
    Price =18000,
    Stock =150,
};

Console.WriteLine(product);
