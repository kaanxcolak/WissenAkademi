using CafeSoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSoft.Data;

public class EnvanterContext
{
    public List<Kat> Katlar { get; set; } = new List<Kat>();
    public List<Masa> Masalar { get; set; } = new List<Masa>();
    public List<Kategori> Kategoriler { get; set;} = new List<Kategori>();
    public List<Urun> Urunler { get; set; } = new List<Urun>();
    public List<Sepet> Sepetler { get; set; } = new List<Sepet>();

}
