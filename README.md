# Patika+ Week4 Constructor Uygulaması
Merhaba,
Bu proje C# ile Patika+ 4.hafta constructor için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- C# konsol uygulamasının yapısını anlamak
- Method kullanımı ve yapısını anlamak.
- Class yapısını anlamak
- Encapsulation yapısını öğrenmek
- Constructor Method yapısını öğrenmek

## İstenilen Görev
Bu örnekte sizlerden bir Bebek sınıfı tanımlamanız isteniyor.

Bebek sınıfının propertyleri -> Doğum Tarihi , Ad , Soyad 

Bebek sınıfı için 2 adet constructor tanımlayınız.

    1.si Default Constructor tarzında parametre almayan bir metot.

    2.si Ad ve Soyad parametrelerini alarak newleme işlemi sırasında değerleri propertylere atayan alternatif constructor.

    2 Constructor içinde ortak olarak bebek nesnesi oluşturulduğunda konsol ekranında bir " Ingaaaa " yazısı görülsün ve Doğum Tarihi o an olarak atansın.

Tanımlama sonrasında her iki constructor ile de birer bebek nesnesi tanımlayarak özelliklerini konsol ekranına yazdırınız.


## Kod
```csharp
 public class Bebek
{
    //fields
    private string name;
    private string surname;
    private DateTime birthday;

    //public özellikler Properies Encapsulation
    public string Name { get { return name; } set { name = value; } }
    public string Surname { get { return surname; } set { surname = value; } }
    public DateTime Birthday { get { return birthday; } set { birthday = value; } }


    //default Constructor
    public Bebek()
    {
        birthday = DateTime.Now; //Doğum tarihi şuanki zaman olarak ayarlanır
        BabySound();  //Bebek sesi çıktısı
    }
    //alternatif constructor
    public Bebek(string _name, string _surname) : this() //default constructor'ı çağırır
    {
        //özel alanlara değer atama (fields)
        this.name = _name;
        surname = _surname;
        BabySound();
    }

    public void BabyInfo() //bebek bilgilerini ekrana yazdırma
    {
        Console.WriteLine($"Adı: {name}");
        Console.WriteLine($"Soyadı: {surname}");
        Console.WriteLine($"Doğum Tarihi: {birthday}");
    }

    public void BabySound() //bebek sesi
    {
        Console.WriteLine("INGAAA");
    }
}
```
Bebek sınıfı oluşturuldu. Özellikler private olarak tanımlandı ve kapsülleme ile veriler alındı. Daha sonr bilgileri ekrana yazdırmak için Method oluşturuldu.

```csharp
static void Main(string[] args)
{
    Bebek baby1 = new Bebek(); //default constructor bir bebek nesnesi oluşturdu
    baby1.Name = "Erdal";  //adı set edildi
    baby1.Surname = "Kömürcü"; //soyadı set edildi
    Console.WriteLine("Baby1'in Bilgileri:\r\n");
    baby1.BabyInfo(); //baby1'in adı, soyadı ve doğum tarihini yazdırır

    Console.WriteLine("----------------------------");

    Bebek baby2 = new Bebek("Abuzer", "Kömürcü");  //alternatif constructor kullanılarak bebek2 nesnesi oluşturuldu
    Console.WriteLine("Baby2'nin Bilgileri:\r\n");
    baby2.BabyInfo(); //ekrana yazdırıldı
}
```
Main method içinde sınıftan nesneler oluşturuldu. Default Constructor ile parametre alan constructor'dan nesneler üretildi ve ekrana yazdırıldı.




