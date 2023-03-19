using InterfaceOrnek2.AbstractEntities;
using InterfaceOrnek2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek2.Entities
{
    internal class Kare : Sekil, IAlanaSahiptir, ICevreyeSahiptir,
        IKosegenli
    {

        #region Properties
        public int Kenar { get; set; }

        #endregion

        public double AlanHesapla()
        {
            try
            {
                return Math.Pow(Kenar, 2);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public double CevreHesapla()
        {
            return 4 * Kenar;
        }

        public double KosegenHesapla()
        {
            return 0; //TODO: formülüne bakıp ekleme yapılacak
        }
    }
}