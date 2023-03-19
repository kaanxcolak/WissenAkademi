using InterfaceOrnek2.AbstractEntities;
using InterfaceOrnek2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek2.Entities
{
    internal class Dikdortgen : Sekil, ICevreyeSahiptir,
        IAlanaSahiptir, IKosegenli
    {
        #region Properties
        public int KisaKenar { get; set; }
        public int UzunKenar { get; set; }

        public double AlanHesapla()
        {
            return UzunKenar * KisaKenar;
        }
        public double CevreHesapla()
        {
            return 2 * (KisaKenar + UzunKenar);
        }

        public double KosegenHesapla()
        {
            return 0; //TODO: formülüne bakılacaktır
        }

        #endregion
    }
}