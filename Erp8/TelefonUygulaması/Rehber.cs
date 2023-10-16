using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonUygulaması
{
    public class Rehber
    {
        List<Kisi> kisiler = new List<Kisi>(); //Listemizin tipi Kisi objesi
        public Rehber()
        {
            //Constructor içerisinde yapıcı metot olduğğu için başlangıç ataması yaptık
            // Varsayılan 3 kişi
            kisiler.Add(new Kisi("Kaan", "Çırpıcıoğlu", "1806538"));
            kisiler.Add(new Kisi("Ahmet", "Çırpıcıoğlu", "1806537"));
            kisiler.Add(new Kisi("Nz", "Demir", "1806536"));            
        }

        public void AddNo()
        {
            Console.WriteLine("**** Yeni Numara Kaydetme ****");
            string name = "";
            string surname = "";
            string phone_number = "";
            //Kullanıcıdan aldığımız inputların validasyonu için bool ifadeleri ile kontrol sağlanır
            //Default olarak false
            bool nameIsValid = false;
            bool surnameIsValid = false;
            bool phoneIsValid = false;

            while (!nameIsValid || !surnameIsValid || !phoneIsValid) //tüm koşullar true olduğunda döngü sonlanır
            {
                if (!nameIsValid) //initial olarak bu block çalışır
                {
                    Console.Write("İsminizi giriniz: ");
                    name = Console.ReadLine().Trim(); // Kullanıcı boşluk kullanarak giriş yaparsa Trim metodu ile boşluklar silinir
                    if (string.IsNullOrEmpty(name)) //string kütüphanesinin bir metodu olan IsNullOrEmpty metodu ile name'in boş olup
                                                    //olmadığı kontrolü yapılır
                    {
                        Console.WriteLine("Uyarı !!!");
                        Console.WriteLine("İsim boş bırakılamaz");
                    }
                    else //name boş değilse
                    {
                        nameIsValid = true;
                    }
                }
                else if (!surnameIsValid)
                {
                    Console.Write("Soyisminizi giriniz: ");
                    surname = Console.ReadLine().Trim();
                    if (string.IsNullOrEmpty(surname))
                    {
                        Console.WriteLine("Uyarı !!!");
                        Console.WriteLine("Soyisim boş bırakılamaz");
                    }
                    else
                    {
                        surnameIsValid = true;
                    }
                }
                else if (!phoneIsValid)
                {
                    Console.Write("10 haneli telefon numaranızı giriniz: ");
                    phone_number = Console.ReadLine().Trim();

                    if (string.IsNullOrEmpty(phone_number))
                    {
                        Console.WriteLine("Uyarı !!!");
                        Console.WriteLine("Telefon numarası boş geçilemez");
                    }
                    else if (phone_number.Length == 10)
                    {
                        //string türündeki telefon numarasını TryParse metodu ile long türüne çevirmeye çalışılır
                        //Eğer çevrilemezse yapı false döner ve geçersiz telefon numarası uyarısı verir. 
                        if (long.TryParse(phone_number, out long converted_no) == false)
                        {
                            Console.WriteLine("Geçersiz telefon numarası");
                        }
                        else { phoneIsValid = true; }
                    }
                }
            }
            kisiler.Add(new Kisi(name, surname, phone_number));
            Console.WriteLine("Ekleme işlemi başarılı");
        }

    }
}
