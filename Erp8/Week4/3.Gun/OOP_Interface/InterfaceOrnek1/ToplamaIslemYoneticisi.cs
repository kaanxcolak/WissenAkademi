using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek1
{
    internal class ToplamaIslemYoneticisi:Islem,IislemYap
    {
        public ToplamaIslemYoneticisi() //new olduğunda ilk bu çalışır. Yapıcı Metot.
        {
            IslemTuru = IslemTurleri.Toplama;
        }

        public void IslemSonucunuYazdir()
        {
            Console.WriteLine("1.Sayi gir:");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Sayi gir:");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sonuc: {s1+s2}");
        }
    }
}
