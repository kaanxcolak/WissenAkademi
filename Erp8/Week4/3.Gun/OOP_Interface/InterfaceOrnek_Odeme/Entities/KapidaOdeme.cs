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
            return $"Kapıda .ödemeniz {OdemeAlanPersonel} tarafından " +
                $"{OdemeTarihi.ToString("dd:MM:yyyy)} {DateTime.Now.AddDays(1)} yapılacaktir";
            //KrediKartiMi = PosMakinesiIstiyorMu ? true : false; 
            
        }
    }
}
