using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim.Lib;

public abstract class Sekil
{    public Sekil()
    {

    }

    public Sekil(int x)
    {
        this.X = x;
    }
    public double X { get; set; }
    public virtual double AlanHesapla() => X * X; //virtual tanımlı class öğeleri kalıtım alınan yerlerde tanımlandığı gibi çalışır.
    //Eğer çalışma şeklini değiştirmek istiyorsak override ile değiştirebiliriz.
    public abstract double CevreHesapla();


}
