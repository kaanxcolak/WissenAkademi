using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracTakipUygulaması;

public class Arac
{
    private string _marka;
    private string _model;
    private string _saseNo;
    private string _yakitTipi;
    private string _vitesTipi;
    private string _motorHacmi;
    
    public string Marka { get; set; }
    public string Model { get; set; }
    public string ModelYili { get; set; }
    public string SaseNo { get; set; }
    public string YakitTipi { get; set;}
    public string VitesTipi { get;set;}
    public string MotorHacmi { get; set; }
    public byte[] Fotograf { get; set; }

    public override string ToString() => $"{this.Marka} {this.Model}";




}
