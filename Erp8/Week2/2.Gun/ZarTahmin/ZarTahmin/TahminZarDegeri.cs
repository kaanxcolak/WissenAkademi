using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarTahmin
{
    internal class TahminZarDegeri
    {
        private int _tahminZar;
        public int TahminZar
        {
            get => _tahminZar;
            set
            {
                if (value < 0 || value > 6)
                {
                    throw new Exception("Lütfen 1-6 arasında değer giriniz.");
                }
                _tahminZar = value;
            }
        }

    }
}
