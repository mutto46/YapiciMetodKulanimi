using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetodKulanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program başladı");
            Kisi kisi = new Kisi();
            Console.WriteLine("Adı:{0},Yaşı:{1}", kisi.Ad, kisi.Yas);
            Console.WriteLine("Program bitti");
        }
        class Kisi
        {
            int yas;
            string ad;
            public Kisi()
            {
                yas = 19;
                ad = "Ahmet";
                Console.WriteLine("Yapıcı metod çalıştı");
            }
            public int Yas
            {
                get
                {
                    return yas;
                }
            }
            public string Ad
            {
                get
                {
                    return ad;
                }
            }
        }

    }
}
