using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim.Lib;
public class Dikdortgen:Sekil
{
    public Dikdortgen() { }
    public Dikdortgen(int x, int y) : base(x)
    {
        this.Y = y;
    }
    public double Y { get; set; }
    public override double AlanHesapla() => X * Y;
    public override double CevreHesapla()
    {
        return 2 * (X + Y);
    }


}


