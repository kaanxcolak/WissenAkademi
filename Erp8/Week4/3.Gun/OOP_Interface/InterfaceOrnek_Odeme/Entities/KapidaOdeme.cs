using InterfaceOrnek_Odeme.AbstractEntities;
using InterfaceOrnek_Odeme.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek_Odeme.Entities
{
    internal class KapidaOdeme : Odeme, IOdemeAlabilir
    {
        public string OdemeAlanPersonel { get; set; } = "Kaan Çolak";
        public bool PosMakinesiIstiyorMu { get; set; }
        public bool NakitMi { get; set; }
        public decimal NakitOdenenTutar { get; set; }
        public bool KrediKartiMi { get; set; }
        public decimal KrediKartiylaOdenenTutar { get; set; }
        public string AcikAdres { get; set; }

        public string OdemeYap()
        {

            return $"Bilgileriniz kaydedildi...\nKapıda Ödemeniz  {OdemeAlanPersonel} tarafından " + $"{OdemeTarihi.ToString("dd.MMM.yyyy")} tarihinde yapılacaktır.";


            //KrediKartiMi= PosMakinesiIstiyorMu ?  true  : false;

            //string mesaj = string.Empty; //
            //string mesaj2 = "";

            //mesaj = NakitOdenenTutar > 100 ? "zenginmişsin" : "fakirmişssin";

            //mesaj = KrediKartiMi==true ? "ödemeyi kartla yapmışsın" : 
            //    "kredi kartın yok MU HALA?";

            //mesaj = KrediKartiMi==false ? "kredi kartın yok MU HALA? "
            //    :"ödemeyi kartla yapmışsın" ;

            //mesaj2 = (NakitMi && NakitOdenenTutar > 500) ? "x" : "y";

            //mesaj2 = NakitMi ? (NakitOdenenTutar> 500 ? "Nakitte zenginsin":"Nakitte fakirsin")
            //    : KrediKartiMi ? (KrediKartiylaOdenenTutar > 500 ? "Kartın zengin" :
            //    "Kartın limiti düşükmüş")
            //    : "Ne nakit ne kredi sen ödeme YAPMAMIŞSIn! ";

            //int ortalamaKacgundeKargolanir = 3;
            //DateTime trh = ortalamaKacgundeKargolanir > 3 ||( NakitOdenenTutar>50 && NakitMi)
            //    ? DateTime.Now.AddDays(5) : DateTime.Now.AddDays(1);

        }
    }
}
