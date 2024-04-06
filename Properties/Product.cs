// ürünün adı : Ürün adı minimum 2 karakterli olmalıdır
// ürünün değeri : ürünün değeri negatif değerler alamaz
//2-) ürünün değerini kullanıcı girdikten sonra kdv li fiyatını müşteriye gösteriniz.
// ürünün stok değeri : negatif değer alamaz.
// ürünün satıcısı :  ürün satıcısı alanı minimum 2 karakterli olmalıdır.
// ürünün kategorisi : ürün satıcısı alanı minimum 2 karakterli olmalıdır.
namespace Properties;

// SOLID 
public class Product
{
    private string name;
    private double price;
    private int stock;
    private string owner;
    private string category;


    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value.Length<2)
            {
                Console.WriteLine("Ürün adı alanı minimum 2 karakterli olmalıdır.");
            }

            name = value;

        }
    }
    public double Price { 
        get
        {
            return price;
        }
        set 
        {
            if(value < 0)
            {
                Console.WriteLine("Ürün değeri negatif değer alamaz");
            }

            price = value * 1.20;
        } 
    }
    public int Stock {
        get
        { 
            return stock;
        } 
        set
        { 
            if(value < 0)
            {
                Console.WriteLine("Ürünün stok değeri negatif olamaz");
            }

            stock = value;
        } 
    }
    public string Owner 
    {
        get 
        {
            return owner;   
        } 
        set 
        {
            if (value.Length < 2)
            {
                Console.WriteLine("Ürünün sağlayıcı alanı minimum 2 karakterli olmalıdır.");
            }
            owner = value;
        }
    }
    public string CategoryName { 
        get 
        {
            return category;
        }
        set 
        {
            if (value.Length < 2)
            {
                Console.WriteLine("Ürünün kategori alanı minimum 2 karakterli olmalıdır.");
            }
            category = value;
        } 
    }

    // Ürünün Kategorisi -> Name
    // 13.00 da dersteyiz.

    public override string ToString()
    {
        return $"Adı : {Name}, Değeri : {Price}, Stok : {Stock}, Sağlayıcı : {Owner}, Kategori : {CategoryName}";
    }
}
