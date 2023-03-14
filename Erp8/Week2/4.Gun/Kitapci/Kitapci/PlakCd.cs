using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitapci;

public class PlakCd:Urun
{
    public Artist Artist { get; set; } //Complex Type
    public string AlbumAdi { get; set; }
    public string Tur { get; set; }
}
