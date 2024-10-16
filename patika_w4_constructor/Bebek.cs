using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_w4_constructor
{
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
}
