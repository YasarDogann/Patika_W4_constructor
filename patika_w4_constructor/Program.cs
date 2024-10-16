namespace patika_w4_constructor
{
    internal class Program
    {
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
    }
}
