Console.WriteLine("Hello, World!");

// fonskiyon(Metod) nedir : yapacapımız işlemleri tekrar tekrar kullanma ihtiyacı duyduğumuz zaman
// Kullandığımız soyutlama tekniğidir.

// Değer döndürmeyen metodlar : Herhangi bir değer bilgisi tutmayan işi yaptıktan sonra kodu devam
//ettiren fonksiyonlardır.

// void fonsksiyon_adı(parametre){}

// ekrana Merhaba yazdıran fonksiyonu yazınız.

// fonksiyon çağrıldı.
//SayHello();
//SayHello();
//SayHello();
//SayHello();
//SayHello();
//SayPersonInfo("İhsan","Arslan",24);
//SayPersonInfo(yas:35,soyad:"Mutlu",ad:"Kemal");
//SayHello();

//int toplam= Topla(258, 963);
//Console.WriteLine(toplam);

//double kuvvet = Kuvvet(4.5, 25);
//Console.WriteLine(kuvvet);

//Console.WriteLine("Lütfen vize notunuzu giriniz : ");
//double vize = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Lütfen final notunuzu giriniz : ");
//double final = Convert.ToDouble(Console.ReadLine());

//double not = NotHesapla(vize,final);

//Console.WriteLine($"Not ortalamanız : {not}");

//double daireAlan = DaireAlan(5);
//Console.WriteLine(daireAlan);

double daireCevre = DaireCevre(5);
Console.WriteLine(daireCevre);


// fonksiyon tanımlandı
void SayHello()
{
    Console.WriteLine("Merhaba");
}



// parametreli metod
// Fonksiyonda kullanıcının adı, soyadı, yaş bilgisi alındıktan sonra bilgilerini ekrana 
// yazdıran kodu yazınız.

void SayPersonInfo(string ad, string soyad, int yas)
{
    Console.WriteLine($"Adınız : {ad} , Soyadınız : {soyad}, Yaşınız : {yas}");
}

// 1-) Dairenin alanını hesaplayan fonksiyonu yazınız. (pi * r * r)
//2-) Dairenin çevresini hesaplayan fonksiyonu yazınız.( 2 * pi * r)

double DaireAlan(double r)
{
    // 1. Yöntem
    //return 3.14 * r * r;

    //  2. Yöntem

    double yaricapKare = Math.Pow(r,2);

    return Math.PI * yaricapKare;

}

double DaireCevre(double r)
{

    return Math.PI * r * 2;
}





// değer döndüren metodlar 
// dönüş_tipi fonksiyon_adı(parametreler){
//return dönüş_tipinde_değer;
// }

// 2 Sayının toplamını değer olarak döndüren fonksiyonu yazınız.

int Topla(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}


// F = m * a
double Kuvvet(double m , double a)
{
    return m * a;
}


// bir metod yazınız bu metodda kullanıcı vize ve final notlarını girsin 
// not ortalamasını hesaplayıp döndüren kodu yazınız.
// vize = %40 finalin %60 ı 

double NotHesapla(double vize, double final)
{
    return vize * 0.4 + final * 0.6;
}