using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitapci.Lib;

public abstract class Urun
{
    private double _fiyat;
    private string _ad;
    private string _yazar;
    private int _stok;
    public Urun() { }
    public Urun(string ad,string yazar,double fiyat)
    {
        _ad= ad;
        _yazar = yazar;
        _fiyat = fiyat;
    }
    public string Ad
    {
        get { return _ad; }
        set { _ad = value; }
    }
    public string Yazar{ 
        get { return _yazar; }
        set { _yazar = value; }
    }
    public double Fiyat {
        get { return _fiyat; }
        set {

            if (_fiyat <= 0)
                throw new Exception("Ürün fiyatı 0 veya daha aşağı olamaz!");
            else
                _fiyat = value;
        }
    }
    public int Stok
    {
        get { return _stok; }
        set
        {
            if (_stok <= 0)
                throw new Exception("Stok 0 veya aşağı olamaz!");
            else 
                _stok = value;
        }
    }
    public virtual double FiyatHesapla() => _fiyat * _stok;

}
