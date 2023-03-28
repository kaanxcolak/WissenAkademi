using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbilYntmVeriKatmani
{
    public class SqlVeriTabaniIslemleri : IVeriTabaniIslemleri
    {
        public string BaglantiCumlesi { get; set; }

        private SqlConnection baglanti;
        private SqlCommand komut;
        public SqlVeriTabaniIslemleri()
        {
            BaglantiCumlesi = "";
            baglanti = new SqlConnection(BaglantiCumlesi);
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }
        public SqlVeriTabaniIslemleri(string baglantiCumle)
        {
            BaglantiCumlesi = baglantiCumle;
            baglanti = new SqlConnection(BaglantiCumlesi);
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }

        private void BaglantiyiAc()
        {
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Open();    
            }            
        }

        public int KomutIsle(string eklemeyadaGuncellemeCumlesi)
        {
            try
            {
                using (baglanti)
                {
                    komut.CommandType = CommandType.Text;
                    komut.CommandText = eklemeyadaGuncellemeCumlesi;
                    BaglantiyiAc();
                    int etkilenenSatirSayisi = komut.ExecuteNonQuery();
                    return etkilenenSatirSayisi;

                    //return komut.ExecuteNonQuery()
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public string VeriEklemeCumlesiOlustur(string tabloAdi, Dictionary<string, object> kolonlar)
        {
            throw new NotImplementedException();
        }

        public DataTable VeriGetir(string tabloAdi, string kolonlar = "*", string? kosullar = null)
        {
            throw new NotImplementedException();
        }

        public string VeriGuncellemeCumlesiOlustur(string tabloAdi, Hashtable kolonlar)
        {
            throw new NotImplementedException();
        }

        public Hashtable VeriOku(string tabloAdi, string[] kolonlar, string? kosullar = null)
        {
            throw new NotImplementedException();
        }

        public int VeriSil(string tabloAdi, string? kosullar = null)
        {
            throw new NotImplementedException();
        }
    }
}
