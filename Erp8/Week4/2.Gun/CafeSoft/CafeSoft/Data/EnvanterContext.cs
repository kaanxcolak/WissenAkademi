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
}
