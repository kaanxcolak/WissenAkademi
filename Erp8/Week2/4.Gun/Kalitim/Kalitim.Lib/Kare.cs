using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim.Lib;
public class Kare : Sekil
{
    public Kare()
    {

    }
    public Kare(int x) : base(x)
    {

    }
    public override double CevreHesapla()
    {
        return 4 * X;
    }

}
