using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkbilYonetimiUI
{
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent(); //İnşa Etmek
        }

        private void FrmKayitOl_Load(object sender, EventArgs e)
        {
            #region Ayarlar
            txtSifre.PasswordChar = '*';
            dtpDogumTarihi.MinDate = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Value = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;
            #endregion

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                //1)Emailden kayıtlı biri zaten var mı?
                string baglantiCumlesi = "Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;";

                SqlConnection baglanti = new SqlConnection(); //baglanti nesnesi
                baglanti.ConnectionString = baglantiCumlesi; //nereye bağlanacak?
                SqlCommand komut = new SqlCommand(); //komut nesnesi türettik
                komut.Connection = baglanti; //komutun hangi bağlantıda çalışacağını atadık
                komut.CommandText = $"select * from Kullaniciler (nolock) where Email = '{txtEmail.Text.Trim()}'"; //sql komutu
                baglanti.Open();

                SqlDataReader okuyucu = komut.ExecuteReader(); //çalıştır
                if(okuyucu.HasRows) //satır var mı?
                {
                    while (okuyucu.Read()) //verileri okurken x işlemleri yap
                    {

                    }
                }


;                //2) Emaili daha önce kayıtlı değilse KAYIT OLACAK
            }
            catch (Exception ex)
            {
                //ex log.txt'ye yazılacak(loglama)
                MessageBox.Show($"Beklenmedik bir hata oluştu! Lütfen tekrar deneyiniz !");
            }
        }
    }
}
