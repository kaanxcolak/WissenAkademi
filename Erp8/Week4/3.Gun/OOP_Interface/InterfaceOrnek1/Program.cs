// See https://aka.ms/new-console-template for more information


using InterfaceOrnek1;

//ToplamaIslemYoneticisi toplamaYoneticisi = new ToplamaIslemYoneticisi();

//IislemİsmiYazdirir islemim = toplamaYoneticisi;
////interface new ile instance alınamaz! ama interfaceden kalıtım alan class
//// newlenerek interface tipte bir değişkene sahip olabiliriz.
//IislemİsmiYazdirir islemim2 = new ToplamaIslemYoneticisi();
//ToplamaIslemYoneticisi islemim3 = new ToplamaIslemYoneticisi();

//IislemİsmiYazdirir[] islemler = new IislemİsmiYazdirir[]
//{
//    toplamaYoneticisi
//};
//List<IislemİsmiYazdirir> islemListesi = 
//    new List<IislemİsmiYazdirir>();
//islemListesi.Add(toplamaYoneticisi);


ToplamaIslemYoneticisi t = new ToplamaIslemYoneticisi();
CarpmaIslemYoneticisi c = new CarpmaIslemYoneticisi();


List<IislemIsmiYazdirir> islemler = new List<IislemIsmiYazdirir>
{ c};

foreach (var item in islemler)
{
    item.IslemIsmiYazdir();
}

Console.WriteLine("\n");

bool kontrol = int.TryParse(Console.ReadLine(), out int sectigiIslem);
if (!kontrol)
{
    Console.WriteLine("Lütfen geçerli seçim yapınız! ");
}
if (sectigiIslem == (int)IslemTurleri.Toplama)
{
    t.IslemSonucunuYazdir();
}
else if (sectigiIslem == (int)IslemTurleri.Carpma)
{
    c.IslemSonucunuYazdir();
}

Console.WriteLine("Hello, World!");
