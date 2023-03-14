using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arac.Lib;

public abstract class Araclar
{
    public Kisi KiralayanKisi { get; set; }
    private double _gunlukUcret;
    public string Marka { get; set; }
    public int ModelYılı { get; set; }
    public string Plaka { get; set; }
    public double GunlukUcret
    {
        get { return _gunlukUcret; }
        set
        {
            if (value <= 0)
                throw new Exception("Günlük ücret sıfırdan küçük olamaz");
        }
    }

    public DateTime KiralamaBaslangicTarihi { get; set; }
    public DateTime KiralamaBitisTarihi { get; set; }

    public double ToplamUcret()
    {
        return (KiralamaBaslangicTarihi.Day - KiralamaBitisTarihi.Day) * _gunlukUcret;

    }

}
