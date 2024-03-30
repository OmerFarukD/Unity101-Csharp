Console.WriteLine(256.0/365.0);
// 0,7013698630136986  ondalıklı sayı sonucu

// Değişken oluşturma  veri tipi değişken_adı = değer

// string : Metinsel değerleri tutan veri tipidir.
string ad = "Mehmet Fırat ";
string soyad = "Doğan";

Console.WriteLine(ad);
Console.WriteLine(soyad);

//Mehmet Fırat
string tum_ad = ad + soyad;
Console.WriteLine(tum_ad);

// int : Tam sayılara karşılık gelen veri tipidir.
int sayi1 = 15;
int sayi2 = 25;
Console.WriteLine(sayi1);
Console.WriteLine(sayi2);

int sonuc = sayi1 + sayi2;
Console.WriteLine(sonuc);


// iki tane değişken oluşturup bu 2 değişkenin toplamını açıklayıcı bir şekilde yazınız.

int number1 = 10;
int number2 = 20;
int total = number1 + number2;
// 10 + 20 = 30 
//1. Yöntem
Console.WriteLine(number1+" + "+number2+" = "+total);

//2. Yöntem String Interpolation
Console.WriteLine($"{number1} + {number2} = {total}");

// iki tane değişken oluşturup bu 2 değişkenle 3 işlem yapan kodları yazınız.
int diff = number1 - number2;
int multiply = number1 * number2;

Console.WriteLine($"{number1} ve {number2} nin çarpımı {multiply}");
Console.WriteLine($"{number1} ve {number2} nin farkı {diff}");

// Konsoldan girdi alma 

// Kullanıcıdan isim ve soyisim alarak ekrana çıktı verelim.

//Console.WriteLine("Lütfen adınızı yazınız : ");
//string name = Console.ReadLine();

//Console.WriteLine("Lütfen soyadınızı yazınız : ");
//string surname = Console.ReadLine();

//Console.WriteLine($"isminiz : {name} , Soyisminiz : {surname}");



// kullanıcıdan isim , soyisim , yaş , okuduğu bölüm bilgisini alan  ve ekrana çıktı veren kod
// Emir Bakkal doğru cevapladı.

//Console.WriteLine("Lütfen adınızı yazınız : ");
//string name = Console.ReadLine();

//Console.WriteLine("Lütfen soyadınızı yazınız : ");
//string surname = Console.ReadLine();

//Console.WriteLine("Lütfen yaşınızı yazınız: ");
//string age = Console.ReadLine();

//Console.WriteLine("Lütfen bölümünüzü yazınız.");
//string department = Console.ReadLine();

//Console.WriteLine($"adınız : {name} soyadınız : {surname}");
//Console.WriteLine($"yaşınız : {age} , bölüm : {department}");


// double : Ondalıklı sayıları tutan veri tipidir.

double ondalik1 = 10.75;
double ondalik2 = 14.65;

Console.WriteLine($"{ondalik1} ve {ondalik2}");

//(int) Kullanıcıdan 2 tane sayı alıp ve toplamını ve çarpımını hesaplayınız.

//Console.WriteLine("Lütfen 1. sayıyı giriniz.");
//int num1 =Convert.ToInt32(Console.ReadLine()) ;

//Console.WriteLine("Lütfen 2. sayıyı giriniz.");
//int num2 =Int32.Parse(Console.ReadLine());

//Console.WriteLine($"{num1} ve {num2} nin toplamı : {num1+num2}");

//Console.WriteLine($"{num1} ve {num2} nin çarpımı : {num1 * num2}");


// boolean : doğruluk ifaedelerinde kullanılır. (true , false)

// < küçük müdür
// > büyük müdür 
// <= küçük eşit midir
// >= büyük eşit midir
// == eşit midir
// != eşit değil midir


bool dogruluk1 = 3==5;
bool dogruluk2 = 3!=5;

Console.WriteLine($"{dogruluk1} ve {dogruluk2}");

// if - else blokları 

// Konsoldan kullanıcının yaşını aldıktan sonra 18 yaşından büyük eşitse ehliyet alabilir
// aksi takdirde ehliyet alamaz

//Console.WriteLine("Lütfen yaşınızı giriniz : ");

//int age = Convert.ToInt32(Console.ReadLine());



//if (age >=18)
//{
//    Console.WriteLine("Ehliyet alabilirsiniz...");
//}
//else
//{
//    Console.WriteLine("Ehliyet alamazsınız...");
//}


// kullanıcıdan bir tam sayı değeri aldığımızda bu sayının tek mi çift mi olduğunu ekrana yazdıran kod

//Console.WriteLine(" Lütfen bir sayı giriniz...");    
//int input1 = Convert.ToInt32(Console.ReadLine());
//// 10  10 saysının 2 ye bölümünden kalan 0
//// 11  11 sayısının 2 ye bölümünden kalan 1
//// % ile mod alma işlemi yapılabilir.
//if (input1 % 2 ==0)
//{
//    Console.WriteLine("Girdiğiniz sayı  : Çift");
//}
//else
//{
//    Console.WriteLine("Girdiğiniz sayı : Tek");
//}
// if, else if , else

//alınan puanlara göre harf notu belirleyen sistemi tasarlayınız

int puan = 65;

if (puan >= 90)
{
    Console.WriteLine("Harf notunuz: A");
}
else if (puan>= 80)
{
    Console.WriteLine("Harf notunuz: B");
}

else if (puan >= 70)
{
    Console.WriteLine("Harf notunuz: C");
}
else
{
    Console.WriteLine("Harf notunuz: F");
}

// kullanıcıdan 1 ile 7 arasında sayılar alarak örneğin 2. gün Salı şeklinde ekrana çıktı veren kodu yazınız.

//Console.WriteLine("Lütfen 1 ile  7 arasında bir sayı giriniz.: ");
//int day = Convert.ToInt32(Console.ReadLine());

//if(day == 1)
//{
//    Console.WriteLine("1. Gün Pazartesi");
//}
//else if(day == 2)
//{
//    Console.WriteLine("2. Gün Salı");
//}
//else if (day == 3)
//{
//    Console.WriteLine("3. Gün Çarşamba");
//}
//else if (day == 4)
//{
//    Console.WriteLine("4. Gün Perşembe");
//}
//else if (day == 5)
//{
//    Console.WriteLine("5. Gün Cuma");
//}
//else if (day == 6)
//{
//    Console.WriteLine("6. Gün Cumartesi");
//}
//else if (day == 7)
//{
//    Console.WriteLine("7. Gün Pazar");
//}
//else
//{
//    Console.WriteLine("Girdiğiniz rakam 1 ile 7 arasında değildir.");
//}

// switch - case
// kullanıcıdan 1 den 12 ye kadar sayılar alalım bu sayıların örneğin
// 1 -> Ocak

//Console.WriteLine("Lütfen 1 den 12 ye kadar bir sayı giriniz : ");
//int ay = Convert.ToInt32(Console.ReadLine());

// 1. yöntem
//switch (ay)
//{
//    case 1: Console.WriteLine("Ocak");
//        break;
//    case 2: Console.WriteLine("Şubat");
//        break;
//    case 3: Console.WriteLine("Mart");
//        break;
//    case 4: Console.WriteLine("Nisan");
//        break;
//    case 5: Console.WriteLine("Mayıs");
//        break;
//    case 6: Console.WriteLine("Haziran");
//        break;
//    case 7: Console.WriteLine("Temmuz");
//        break;
//    case 8: Console.WriteLine("Ağustos");
//        break;
//    case 9: Console.WriteLine("Eylül");
//        break;
//    case 10: Console.WriteLine("Ekim");
//        break;
//    case 11: Console.WriteLine("Kasım");
//        break;
//    case 12: Console.WriteLine("Aralık");
//        break;
//    default:
//        Console.WriteLine("1 ile 12 arasında değer girmediniz.");
//        break;
//}

//2. Yöntem
// expression yöntemi ile switch case 
//string ayIsmi = ay switch
//{
//    1 => "Ocak",
//    2 => "Şubat",
//    3 => "Mart",
//    4 => "Nisan",
//    5 => "Mayıs",
//    6 => "Haziran",
//    7 => "Temmuz",
//    8 => "Ağustos",
//    9 => "Eylül",
//    10 => "Ekim",
//    11 => "Kasım",
//    12 => "Aralık",
//    _ => "1 ile 12 arasında değer girmediniz."
//};
//Console.WriteLine(ayIsmi);

// mevsimleri sınıflandıran kodu yazınız (if else)
// sesli sessiz harf ayıran kodu yazınız (s1, s2)

// Berk düzgün cevabı
//Console.WriteLine("Lütfen ay ismi giriniz.");
//string ay1 = Console.ReadLine();
//if(ay1 =="Aralık" ||ay1 =="Ocak"|| ay1 == "Şubat")
//{
//    Console.WriteLine("Kış mevsimindesiniz.");
//}
//else if(ay1 == "Mart" || ay1 == "Nisan" || ay1 == "Mayıs")
//{
//    Console.WriteLine("İlk Bahar mevsimindesiniz.");
//}
//else if (ay1 == "Haziran" || ay1 == "Temmuz" || ay1 == "Ağustos")
//{
//    Console.WriteLine("Yaz mevsimindesiniz.");
//}
//else if (ay1 == "Eylül" || ay1 == "Ekim" || ay1 == "Kasım")
//{
//    Console.WriteLine("Son Bahar mevsimindesiniz.");
//}
//else
//{
//    Console.WriteLine("Geçersiz bir ay girdiniz.");
//}
//// char : tek karakter tutan veri tipidir



// Emir bakkal doğru cevapladı (s2)
Console.WriteLine("harf girin ");

char harf = Console.ReadLine()[0];

string vowels = harf switch
{
    'a' => "Sesli",
    'e' => "Sesli",
    'ı' => "Sesli",
    'i' => "Sesli",
    'o' => "Sesli",
    'ö' => "Sesli",
    'u' => "Sesli",
    'ü' => "Sesli",
    'A' => "Sesli",
    'E' => "Sesli",
    'I' => "Sesli",
    'İ' => "Sesli",
    'O' => "Sesli",
    'Ö' => "Sesli",
    'U' => "Sesli",
    'Ü' => "Sesli",
    _ => "Sessiz"
};
Console.WriteLine(vowels);
// Değişiklik 