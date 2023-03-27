using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace AkbilYonetimiUI
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            //Bu formu gizleyeceğiz
            //Kayıt Ol formunu açacağız 
            this.Hide();
            FrmKayitOl frm = new FrmKayitOl();
            frm.Show();

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                //1)Email ve şifre textboxları dolu mu?
                if(string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show("Bilgileri eksiksiz giriniz!",
                     "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                //2)Girdiği email ve şifre veritabanında mevcut mu?
                //select * from Kullanicilar where Email = '' and Sifre=''
                string baglantiCumlesi = @"Server=DESKTOP-P4SDEGD;Database=AKBILDB;Trusted_Connection=True;";
                SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
                string sorgu = $"select * from Kullanicilar where Email = '{txtEmail.Text.Trim()}' and Sifre='{txtSifre.Text.Trim()}'"; 
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                baglanti.Open();
                SqlDataReader okuyucu = komut.ExecuteReader();
                if (!okuyucu.HasRows)    //DEĞİLSE yanlış giriş mesajı verecek
                {
                    MessageBox.Show("Email ya da şifrenizi doğru girdiğinize emin olunuz",
                     "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    baglanti.Close();
                    return;
                }
                else
                {
                    while(okuyucu.Read())
                    {
                        MessageBox.Show($"Hoşgeldiniz {okuyucu["Ad"]} {okuyucu["Soyad"]}");
                    }
                    baglanti.Close();
                }
                //eğer email ve şifre doğruysa hoşgeldiniz yazacak ve anasayfa formuna yönlendirilecek
                //.eğer beni Hatırla'yı tıkladıysa ?? Bilgileri hatırlanacak...
                if(checkBoxHatirla.Checked)
                {
                    Properties.Settings1.Default.BeniHatirla = true;
                    Properties.Settings1.Default.KullaniciEmail = txtEmail.Text.Trim();
                    Properties.Settings1.Default.KullaniciSifre = txtSifre.Text.Trim();
                }
                //Bu form gizlenecek
                //Ana sayfa formu açılacak!!!

             
            }
            catch (Exception hata)
            {
                //Dipnot: exceptionlar asla kullanıcıya gösterilmez.
                //Exceptionlar loglanır. Biz şuan öğrenme/geliştirme aşamasında olduğumuz için yazdık.
                MessageBox.Show($"Beklenmedik bir hata oluştu! "+ hata.Message);
            }
        }
    }
}