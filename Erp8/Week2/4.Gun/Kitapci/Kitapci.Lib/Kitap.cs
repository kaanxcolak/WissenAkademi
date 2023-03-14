using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitapci.Lib;

public class Kitap : Urun
{
    public Kitap(){
    
    }
    public Kitap(string ad,string yazar,double fiyat)
    {

    }
    public override double FiyatHesapla()
    {
        return base.FiyatHesapla();
    }

}

   