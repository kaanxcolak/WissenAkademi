using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSoft.Models;

public class GunlukRapor
{
    private DateTime dateTime = DateTime.Now;
    public List<Urun> SatılanUrunler { get; set; } = new List<Urun>();
    private static readonly string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\GünlükRapor.txt";
    public int SatılmaSayisi { get; set; }
    public void UrunEkle(Urun urun)
    {
        foreach (var item in SatılanUrunler)
        {
            if (urun.Ad == item.Ad)
            {
                item.SepetUrunAdet += urun.SepetUrunAdet;
                return;
            }
        }
        SatılanUrunler.Add(urun);
    }
    public void GunlukRaporOlustur()
    {
        FileStream file = File.Open(Path, FileMode.Append);
        StreamWriter writer = new StreamWriter(file);
        writer.WriteLine($"Oluşturulma Tarihi: {dateTime.ToString()}");
        foreach (var item in SatılanUrunler)
        {
            writer.WriteLine($"{item.Ad}-{item.SepetUrunAdet}");
        }
        writer.Close();
        writer.Dispose();
    }

}
