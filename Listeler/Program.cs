// Listeler dinamik bir yapıdır veri ekleyip çıkarabiliyoruz.
// Jenerik argüman
List<int> sayilar  = new List<int>() { 1,2,3,4,5,6,7,8};
List<string> ulkeler = new List<string>() {"Almanya","Türkiye","İngiltere","Kanada","Fransa","Mısır"};

// ulkeler listesindeki tüm elemanları ekrana yazdıran kodu yazınız.
//foreach (string ulke in ulkeler)
//{
//    Console.WriteLine(ulke);
//}

// 2. yöntem
//ulkeler.ForEach(ulke=> Console.WriteLine(ulke));

// sayılar listesine eleman ekleyiniz(9,10,11,12,13)
sayilar.Add(9);
sayilar.Add(10);
sayilar.Add(11);
sayilar.Add(12);
sayilar.Add(13);
//sayilar.ForEach(say => Console.WriteLine(say));

// sayılar listesinde bütün elemanları tek tek dolaşıp
// çift sayıları bir tane ciftSayılar listesi oluşturup o listeye ekleyen
// tek sayıları  bir tane tekSayilar listesi oluşturup o listeye ekleyen 
// ve her iki listeyi listeleyen kodu yazınız.

List<int> tekSayilar = new List<int>();
List<int> ciftSayilar = new List<int>();
//1. Yöntem 
//foreach (int sayi in sayilar)
//{
//    if (sayi % 2 ==0)
//    {
//        ciftSayilar.Add(sayi);
//    }
//    else
//    {
//        tekSayilar.Add(sayi);
//    }
//}

//Console.WriteLine("Tek sayılar :");
//foreach (int tek in tekSayilar)
//{
//    Console.WriteLine(tek);
//}

//Console.WriteLine("Çift Sayılar : ");
//foreach (int cift in ciftSayilar)
//{
//    Console.WriteLine(cift);
//}
// **************** 2. Yöntem ****************

//tekSayilar = sayilar.FindAll(sayi=> sayi % 2 != 0);
//ciftSayilar = sayilar.FindAll(sayi => sayi % 2 == 0);

//Console.WriteLine("Tek sayılar :");
//tekSayilar.ForEach(sayi => Console.WriteLine(sayi));

//Console.WriteLine("Çift Sayılar :");
//ciftSayilar.ForEach(sayi => Console.WriteLine(sayi));

//List<int> numbers = new List<int>() {3,2,5,1,4,6,8,9,11,6 };

//ListeIslemleri(numbers);


//void ListeIslemleri(List<int> sayilar)
//{

//    Console.WriteLine($"Listedeki en büyük sayı : {sayilar.Max()}");
//    Console.WriteLine($"Listedeki en küçük sayı : {sayilar.Min()}");

//    sayilar.Sort();
//    Console.WriteLine("Artan şekilde sıralanmış liste :");
//    sayilar.ForEach(s => Console.WriteLine(s));

//    Console.WriteLine("Azalan Şekilde sıralanmış liste : ");
//    sayilar.Reverse();

//    sayilar.ForEach(s => Console.WriteLine(s));
//}

// Dictionary (sözlük)   key -> value
// Elma 25
Dictionary<string, double> manav = new Dictionary<string, double>();

//manav.Add("Elma", 25);
//manav.Add("Armut",20);
//manav.Add("Kiraz", 55);

//Console.WriteLine(manav["Elma"]);

//foreach (var item in manav)
//{
//    Console.WriteLine($"ürün adı : {item.Key}, Ürünün değeri : {item.Value}");
//}

// Konsoldan kullanıcıdan kaç tane ürün gireceğini alıp sonrasında
// manav sözlüğü içerisine o kadar ürün ekleyen 
// ürünü eklerken her ürünün %20 kdv si eklenerek hesaplayan 
// sonrasında tüm ürünleri ve kdv li fiyatı ekrana çıktı olarak veren kodu yazınız.
// Batuhan Yıldız doğru cevapladı

Console.WriteLine("Kaç adet ürün girmek istersiniz : ");
int adet = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i<adet; i++)
{
    Console.WriteLine($"{i+1}. ürün adını giriniz :");
    string name = Console.ReadLine();

    Console.WriteLine($"{name} ürünün değerini giriniz giriniz :");
    double price = Convert.ToDouble(Console.ReadLine());

    double kdvli = price * 1.20;

    manav.Add(name,kdvli);
}
foreach (var item in manav)
{
    Console.WriteLine($"ürünün adı : {item.Key}, ürünün değeri : {item.Value}");
}