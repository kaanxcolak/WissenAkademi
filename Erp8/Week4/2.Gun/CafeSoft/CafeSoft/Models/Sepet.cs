using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSoft.Models;

public class Sepet
{
    public decimal ToplamFiyat { get; set; }
    public List<Urun> Urunler { get; set; } = new List<Urun>();

}
