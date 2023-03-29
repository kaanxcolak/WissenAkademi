using AkbilYntmIsKatmani;
using AkbilYntmVeriKatmani;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Text;

namespace AkbilYonetimiUI
{
    public partial class FrmGiris : Form
    {
        public string Email { get; set; }   //kayıt ol formunda kayıt olan kullanıcının emaili buraya gelsin
        IVeriTabaniIslemleri veriTabaniIslemleri = new SQLVeriTabaniIslemleri();
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
                //select * from Kullanicilar where Email = '' and Sifre=''
                string[] istedigimKolonlar = new string[] { "Id", "Ad", "Soyad" };
                string kosullar = string.Empty;
                StringBuilder sb = new StringBuilder();
                sb.Append($"Email='{txtEmail.Text.Trim()}'");
                sb.Append(" and ");
                sb.Append($"Parola='{GenelIslemler.MD5Encryption(txtSifre.Text.Trim())}'");
                kosullar = sb.ToString();

                var sonuc = veriTabaniIslemleri.VeriOku("Kullanicilar", istedigimKolonlar, kosullar);

                if (sonuc.Count==0)
                {
                    MessageBox.Show("Email ya da şifre yanlış! tekrar dene! ");
                }
                else
                {
                    GenelIslemler.GirisYapanKullaniciID = (int)sonuc["Id"];
                    GenelIslemler.GirisYapanKullaniciAdSoyad = $"{sonuc["Ad"]} {sonuc["Soyad"]}";
                    MessageBox.Show($"Hoşgeldiniz... {GenelIslemler.GirisYapanKullaniciAdSoyad}");

                    //Beni hatırla yazılacak
                    this.Hide();
                    FrmAnasayfa frmanasayfa = new FrmAnasayfa();
                    frmanasayfa.Show();
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