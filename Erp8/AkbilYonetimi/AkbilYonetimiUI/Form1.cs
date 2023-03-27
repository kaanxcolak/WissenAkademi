using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace AkbilYonetimiUI
{
    public partial class FrmGiris : Form
    {
        public string Email { get; set; }   //kayıt ol formunda kayıt olan kullanıcının emaili buraya gelsin
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

            if (Properties.Settings1.Default.BeniHatirla)
            {
                txtEmail.Text = Properties.Settings1.Default.KullaniciEmail;
                txtSifre.Text = Properties.Settings1.Default.KullaniciSifre;
                checkBoxHatirla.Checked = true;

            }
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
                string baglantiCumlesi = @"Server=DESKTOP-P4SDEGD;Database=AKBILDB;Trusted_Connection=True;";
                SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
                string sorgu = $"select * from Kullanicilar where Email = '{txtEmail.Text.Trim()}' and Parola='{txtSifre.Text.Trim()}'";
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
                    while (okuyucu.Read())
                    {
                        MessageBox.Show($"Hoşgeldiniz {okuyucu["Ad"]} {okuyucu["Soyad"]}");
                        Properties.Settings1.Default.KullaniciId = (int)okuyucu["Id"];
                    }
                    baglanti.Close();
                }
                //eğer email ve şifre doğruysa hoşgeldiniz yazacak ve anasayfa formuna yönlendirilecek
                //.eğer beni Hatırla'yı tıkladıysa ?? Bilgileri hatırlanacak...
                if (checkBoxHatirla.Checked)
                {
                    Properties.Settings1.Default.BeniHatirla = true;
                    Properties.Settings1.Default.KullaniciEmail = txtEmail.Text.Trim();
                    Properties.Settings1.Default.KullaniciSifre = txtSifre.Text.Trim();

                    Properties.Settings1.Default.Save();

                }
                else
                {
                    Properties.Settings1.Default.BeniHatirla = false;
                    Properties.Settings1.Default.KullaniciEmail = "";
                    Properties.Settings1.Default.KullaniciSifre = string.Empty;

                    Properties.Settings1.Default.Save();
                }
                //Bu form gizlenecek
                //Ana sayfa formu açılacak!!!
                this.Hide();
                FrmAnasayfa frma = new FrmAnasayfa();
                frma.Show();


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