
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Text;
using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani;
using AkbilYonetimiUI.Models;

namespace AkbilYonetimiUI
{
    public partial class FrmGiris : Form
    {
        public string Email { get; set; }   //kayıt ol formunda kayıt olan kullanıcının emaili buraya gelsin
        AkbildbContext context = new AkbildbContext();  
        
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            if (Email != null)
            {
                txtEmail.Text = Email;
            }

            txtEmail.TabIndex = 1;
            txtSifre.TabIndex = 2;
            checkBoxHatirla.TabIndex = 3;
            btnGirisYap.TabIndex = 4;
            btnKayitOl.TabIndex = 5;

            txtEmail.Text = "kaan@gmail.com";
            txtSifre.Text = "123";
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
            GirisYap();
        }
        private void GirisYap()
        {
            try
            {
                //1)Email ve şifre textboxları dolu mu?
                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text))
                {
                    MessageBox.Show("Bilgileri eksiksiz giriniz!",
                     "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                //2)Girdiği email ve şifre veritabanında mevcut mu?
                var kullanici =  context.Kullanicilars.FirstOrDefault(x=> x.Email == txtEmail.Text && x.Parola ==GenelIslemler.MD5Encryption(txtSifre.Text));
                if (kullanici == null)
                {
                    MessageBox.Show("Email ya da şifrenizi yanlış girdiniz!");
                    return;
                }
                else
                {
                    MessageBox.Show($"Hoşgeldiniz... {kullanici.Ad} {kullanici.Soyad}");
                    GenelIslemler.GirisYapanKullaniciID = kullanici.Id;
                    GenelIslemler.GirisYapanKullaniciEmail = kullanici.Email;
                    GenelIslemler.GirisYapanKullaniciAdSoyad = $"{kullanici.Ad} {kullanici.Soyad}";
                    //Beni hatırla settings ile olacak
                    //temizlik
                    txtEmail.Clear(); txtSifre.Clear();
                    FrmAnasayfa frmAnasayfa = new FrmAnasayfa();
                    this.Hide();
                    frmAnasayfa.Show();

                }
            }
            catch (Exception hata)
            {
                //Dipnot: exceptionlar asla kullanıcıya gösterilmez.
                //Exceptionlar loglanır. Biz şuan öğrenme/geliştirme aşamasında olduğumuz için yazdık.
                MessageBox.Show($"Beklenmedik bir hata oluştu! " + hata.Message);
            }
        }
        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) //basilan tuş enter ise giriş yapacak
            {
                GirisYap();
            }
        }
    }
}