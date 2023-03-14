using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSoft.Models;

public class Urun
{
    public Guid Id { get; set; }=Guid.NewGuid();
    public string Ad { get; set; }
    public decimal Fiyat { get; set; }
    public Kategori Kategori { get; set; }
    public int SepetUrunAdet { get; set;}
    public byte[]? Fotograf { get; set; } = null; //? koydum çünkü boş bırakılabilir bayt dizisi oluşturmayı hedefledim
    public decimal ToplamFiyat()
    {
        return Fiyat * SepetUrunAdet;
    }
    public override string ToString()
    {
        return $"{Kategori.Ad} - {Ad}-{Fiyat} ";
    }

}
