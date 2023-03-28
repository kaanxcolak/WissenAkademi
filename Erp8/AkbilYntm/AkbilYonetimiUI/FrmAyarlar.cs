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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            dtpDogumTarihi.MaxDate = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Value = new DateTime(2016, 1, 1);
            dtpDogumTarihi.Format = DateTimePickerFormat.Short;

            KullanicininBilgileriniGetir();

        }

        private void KullanicininBilgileriniGetir()
        {
            try
            {
                //Giriş yapmış kullanıcının bilgileriyle select sorgusu yazacağız
                //Kullanıcı bilgisini alabilmek için burada 2 yöntem kullanabiliriz.
                //Static bir class açıp içinde static GirisYapmisKullaniciEmail propertysi kullanılabilir.
                //2.Yöntem olarak properties settings içine kayıtlı email bilgisinden yararlanılabilir.
                if (string.IsNullOrEmpty(Properties.Settings1.Default.KullaniciEmail))
                {
                    MessageBox.Show("Giriş yapmadan bu sayfaya ulaşamazsınız!");
                    return;
                    //Giriş formuna yönlendirilebilir.....showDialog()
                }
                else
                {
                   
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show($"Beklenmedik hata oluştu!" + hata.Message);
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception hata)
            {

                MessageBox.Show("Güncelleme başarısızdır!" + hata.Message);
            }
        }
    }
}
