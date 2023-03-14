using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitapci;

public class Artist
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Ulke { get; set; }
    public string Cinsiyet { get; set; }
    public DateTime DogumTarihi { get; set; }
    public string DogumYeri { get; set; }
    public string Ozgecmis { get; set; }

    public List<Urun> Urunler { get; set; } = new List<Urun>();

}
