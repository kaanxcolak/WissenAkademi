using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitapci;
public class Dergi:Urun
{    public string YayinEvi { get; set; }
    public int Cilt { get; set; }
    public int Sayi { get; set; }
    public int BasimYili { get; set; }
    public string Dil { get; set; }
    public string ISBN { get; set; }
}
