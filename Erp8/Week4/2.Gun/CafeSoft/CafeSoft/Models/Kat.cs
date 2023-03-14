using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSoft.Models;

public class Kat
{
    public string KatAd { get; set; }
    public int MasaSayisi { get; set; }
    public override string ToString()
    {
        return $"{KatAd} - {MasaSayisi}";
    }
}
