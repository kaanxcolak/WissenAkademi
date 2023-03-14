using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOPGiris;
public class Kisi
{
    //ad, soyad, dogumTarihi, tckn, telefon, email, yas
    //Ad ve soyad da özel karakter ve sayı olmamalı. Okunurken ilk harf büyük sonraki harfler kücük şekilde gösterilmeli
    //TCKN 11 haeli olmalı ve sadece rakamlardan oluşmalı 
    //Telefon 10 hanelli olmalı ve sadece rakamlardan oluşmalı
    //Email adresi @ işaretinden sonra en az 2 karakter olmalı ve email kurallarına uygun olmalı
    //yas özelliği sadece okunur olmalı
    private string _ad, _soyad, _tckn, _telefon, _email;

    public string Ad
    {
        get
        {
            return _ad.Substring(0, 1).ToUpper() + _ad.Substring(1).ToLower(); //substring içindeki 2.parametre 1 adet al anlamında!
        }
        set
        {
            foreach (char harf in value)
            {
                if (char.IsDigit(harf) || char.IsSymbol(harf) || char.IsPunctuation(harf))
                    throw new Exception("Ad alanına özel karakter veya sayı girişi yapılamaz");
            }
            _ad = value;
        }
    }

    public string Soyad
    {
        get
        {
            return _soyad.ToUpper(); //substring içindeki 2.parametre 1 adet al anlamında!
        }
        set
        {
            foreach (char harf in value)
            {
                if (char.IsDigit(harf) || char.IsSymbol(harf) || char.IsPunctuation(harf))
                    throw new Exception("Ad alanına özel karakter veya sayı girişi yapılamaz");
            }
            _soyad = value;
        }
    }

    public DateTime DogumTarihi {get; set;}

    public string Tckn
    {
        get => _tckn;
        set
        {
            if (value.Length != 11)
                throw new Exception("TCKN 11 haneli olmalıdır");
            foreach(char harf in value)
            {
                if (!char.IsDigit(harf))
                    throw new Exception("TCKN sadece rakamlardan oluşmalı");
            }
            _tckn = value;
        }
    }

    public string Telefon
    {
        get => _telefon;
        set
        {
            if (value.Length != 10)
                throw new Exception("Telefon Numarası 10 haneli olmalıdır");
            foreach (char harf in value)
            {
                if (!char.IsDigit(harf))
                    throw new Exception("Telefon Numarası sadece rakamlardan oluşmalı");
            }
            _telefon = value;
        }
    }
    public string Email
    {
        get => _email;
        set{
            string emailRegEx = @"^[\w -\.] +@([\w -] +\.)+[\w -]{ 2,4}$";
            if(!Regex.IsMatch(value,emailRegEx,RegexOptions.IgnoreCase))
                throw new Exception("Doğru bir email adresi giremediniz");        
            _email = value;
        }
    }

    public int Yas => DateTime.Now.Year - this.DogumTarihi.Year; //Readonly property


}


