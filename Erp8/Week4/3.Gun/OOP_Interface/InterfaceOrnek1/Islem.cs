using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek1
{
    internal abstract class Islem:IislemIsmiYazdirir
    {
        public IslemTurleri IslemTuru { get; set; }

        public void IslemIsmiYazdir()
        {
            //Örnek. Toplama --> 1
            Console.WriteLine($"{IslemTuru} ---> {(byte)IslemTuru}");
        }
    }
    enum IslemTurleri:byte
    {
        //Farklı değerler verebiliriz
        Toplama=55, 
        Cikarma=1,
        Carpma=249
    }
}
