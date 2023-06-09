﻿using System;
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
                    string baglantiCumlesi = @"Server=DESKTOP-P4SDEGD;Database=AKBILDB;Trusted_Connection=True;";
                    SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
                    SqlCommand komut = new SqlCommand($"select * from Kullanicilar where " +
                        $"Email = '{Properties.Settings1.Default.KullaniciEmail}' " +
                        $"and Parola='{Properties.Settings1.Default.KullaniciSifre}'", baglanti);
                    baglanti.Open();
                    SqlDataReader okuyucu = komut.ExecuteReader();
                    if (okuyucu.HasRows)
                    {
                        while (okuyucu.Read())
                        {
                            txtEmail.Text = okuyucu["Email"].ToString();
                            txtEmail.Enabled = false;
                            txtAd.Text = okuyucu["Ad"].ToString();
                            txtSoyad.Text = okuyucu["Soyad"].ToString();
                            dtpDogumTarihi.Value = Convert.ToDateTime(okuyucu["DogumTarihi"]);
                        }
                    }
                    baglanti.Close();
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
                string baglantiCumlesi = @"Server=DESKTOP-P4SDEGD;Database=AKBILDB;Trusted_Connection=True;";
                SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
                string sorgu = $"update Kullanicilar set Ad='{txtAd.Text.Trim()}',Soyad='{txtSoyad.Text.Trim()}'" +
                    $", DogumTarihi='{dtpDogumTarihi.Value.ToString("yyyyMMdd")}' ";
                if (!string.IsNullOrEmpty(txtSifre.Text))
                {
                    sorgu += $" ,Parola = '{txtSifre.Text.Trim()}'";
                }

                sorgu += $"where Email = '{txtEmail.Text.Trim()}'";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);                   
                baglanti.Open();
                if (komut.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Bilgiler Güncellendi!");
                    KullanicininBilgileriniGetir();
                }
                else
                {
                    MessageBox.Show("Bilgiler Güncellenemedi! ");
                }            
            }
            catch (Exception hata)
            {

                MessageBox.Show("Güncelleme başarısızdır!" + hata.Message);
            }
        }
    }
}
