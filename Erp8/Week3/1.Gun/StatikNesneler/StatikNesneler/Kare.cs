using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatikNesneler;

public abstract class Sekil
{
    public double X { get; set; }
    public abstract double AlanHesapla();
}
public class Kare : Sekil
{
    public override double AlanHesapla() => X * X;
    public static double AlanHesapla(double x) => x * x;//bir nesnenin içerisine statik nesne
    //tanımlayabilmek için sınıfın statik tanımlanmasına gerek yoktur. Statik tanımlanan sınıflarda tüm sınıf elemanları statik tanımlanmalıdır.
}
public class Dikdortgen : Sekil
{
    public double Y { get; set; }
    public override double AlanHesapla() => X * Y; 
    public static double AlanHesapla(double x,double y) => x * y; //statik metodlar
}

public static class Geometri //statik sınıftan instance alınamaz.
{
    public static double X{ get;set; }
    public static double AlanHesapla(double x) => x * x;
    public static double AlanHesapla(double x,double y) => x * y;
    public static double AlanHesapla(int r, double pi = Math.PI) => r * r * pi;

}
