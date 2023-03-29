using AkbilYntmIsKatmani;
using AkbilYntmVeriKatmani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkbilYonetimiUI
{
    public partial class FrmTalimatlar : Form
    {
        IVeriTabaniIslemleri veriTabaniIslemleri = new SQLVeriTabaniIslemleri(
            GenelIslemler.SinifSQLBaglantiCumlesi);
        public FrmTalimatlar()
        {
            InitializeComponent();
        }

        private void FrmTalimatlar_Load(object sender, EventArgs e)
        {
            //Comboboxa akbilleri getir
            ComboBoxaKullanicininAkbilleriniGetir();
            //cmbBoxAkbiller.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxAkbiller.SelectedIndex = -1;
            cmbBoxAkbiller.Text = "Akbil Seçiniz...";
            groupBoxYukleme.Enabled = false;

            dataGridViewTalimatlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            TalimatlariDataGrideGetir();
            dataGridViewTalimatlar.ContextMenuStrip = contextMenuStrip1;

            checkBoxTumunuGoster.Checked = false;
            BekleyenTalimatSayisiniGetir();
            timerBekleyenTalimat.Interval = 1000;
            timerBekleyenTalimat.Enabled = true;
        }

        private void BekleyenTalimatSayisiniGetir()
        {
            try
            {
                lblBekleyenTalimat.Text = veriTabaniIslemleri.VeriGetir("KullanicininTalimatlari", kosullar: $"KullanicininId={GenelIslemler.GirisYapanKullaniciID}" +
                    $"and YuklendiMi=0").Rows.Count.ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu! " + hata.Message);
            }
        }

        private void TalimatlariDataGrideGetir(bool tumunuGoster = false)
        {
            try
            {
                if (tumunuGoster) // tumunusGoster==true
                {
                    dataGridViewTalimatlar.DataSource = veriTabaniIslemleri.VeriGetir("KullanicininTalimatlari", kosullar: $"KullaniciId={GenelIslemler.GirisYapanKullaniciID}");
                }
                else
                {
                    dataGridViewTalimatlar.DataSource = veriTabaniIslemleri.VeriGetir("KullanicininTalimatlari", kosullar: $"KullaniciId={GenelIslemler.GirisYapanKullaniciID} and YuklendiMi=0");
                }
                dataGridViewTalimatlar.Columns["Id"].Visible = false;
                dataGridViewTalimatlar.Columns["KullaniciId"].Visible = false;
                dataGridViewTalimatlar.Columns["YuklendiMi"].HeaderText = "Talimat Yüklendi Mi?";

                foreach (DataGridViewColumn item in dataGridViewTalimatlar.Columns)
                {
                    item.Width = 200;
                }
                dataGridViewTalimatlar.Columns["Akbil"].Width = 400;

                //istediğiniz diğer kolonlara da ayarlama yapabilirsiniz.
                foreach (DataGridViewColumn item in dataGridViewTalimatlar.Columns)
                {
                    item.Width = 200;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Talimatlar getirilirken hata oluştu! " + hata.Message);
            }
        }

        private void ComboBoxaKullanicininAkbilleriniGetir()
        {
            try
            {
                cmbBoxAkbiller.DataSource = veriTabaniIslemleri.VeriGetir("Akbiller",
                    kosullar: $"AkbilSahibiId={GenelIslemler.GirisYapanKullaniciID}");
                cmbBoxAkbiller.DisplayMember = "AkbilNo";
                cmbBoxAkbiller.ValueMember = "AkbilNo"; //Genellikle benzersiz bilgi atanır.
                                                        //Örn:Primary Key kolonu
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu! " + hata.Message);
            }
        }

        private void txtYuklenecekTutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxAkbiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxAkbiller.SelectedIndex >= 0)
            {
                txtYuklenecekTutar.Clear();
                groupBoxYukleme.Enabled = true;
            }
            else
            {
                txtYuklenecekTutar.Clear();
                groupBoxYukleme.Enabled = false;
            }
        }

        private void btnTalimatKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBoxAkbiller.SelectedIndex < 0)
                {
                    MessageBox.Show("Akbil seçmeden işlem yapamazsın");
                    return;
                }
                if (string.IsNullOrEmpty(txtYuklenecekTutar.Text))
                {
                    MessageBox.Show("Yükleme miktarı girişi zorunludur! ");
                    return;
                }
                if (!decimal.TryParse(txtYuklenecekTutar.Text.Trim(), out decimal tutar))
                {
                    MessageBox.Show("Yükleme miktarı girişi uygun formatta olmalıdır! ");
                    return;
                }
                Dictionary<string, object> kolonlar = new Dictionary<string, object>();
                kolonlar.Add("EklenmeTarihi", $"'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'");
                kolonlar.Add("AkbilID", $"'{cmbBoxAkbiller.SelectedValue}'");
                kolonlar.Add("YuklenecekTutar", tutar);
                kolonlar.Add("YuklendiMi", "0");
                kolonlar.Add("YuklenmeTarihi", "null");

                string talimatinsert = veriTabaniIslemleri.VeriEklemeCumlesiOlustur("Talimatlar", kolonlar);
                int sonuc = veriTabaniIslemleri.KomutIsle(talimatinsert);
                if (sonuc > 0)
                {
                    MessageBox.Show("Talimat Kaydedildi...");
                    txtYuklenecekTutar.Clear();
                    cmbBoxAkbiller.SelectedIndex = -1;
                    cmbBoxAkbiller.Text = "Akbil Seçiniz...";
                    groupBoxYukleme.Enabled = false;
                    TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);
                    BekleyenTalimatSayisiniGetir();
                }
                else
                {

                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Talimat kaydedilemedi! " + hata.Message);
            }
        }

        private void checkBoxTumunuGoster_CheckedChanged(object sender, EventArgs e)
        {
            TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);
        }

        private void anaMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frma = new FrmAnasayfa();
            this.Hide();
            frma.Show();
        }

        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güle Güle Çıkış Yapıldı");
            GenelIslemler.GirisYapanKullaniciAdSoyad = string.Empty;
            GenelIslemler.GirisYapanKullaniciID = 0;

            foreach (Form item in Application.OpenForms)
            {
                if (item.Name != "Form1")
                {
                    item.Hide();
                }
            }
            Application.OpenForms["Form1"].Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void timerBekleyenTalimat_Tick(object sender, EventArgs e)
        {
            if (lblBekleyenTalimat.Text != "0")
            {
                if (DateTime.Now.Second % 2 == 0)
                {
                    lblBekleyenTalimat.Font = new Font("Segoe UI", 40);
                    lblBekleyenTalimat.ForeColor = Color.OrangeRed;
                }
                else
                {
                    lblBekleyenTalimat.Font = new Font("Segoe UI", 25);
                    lblBekleyenTalimat.ForeColor = Color.Red;
                }
            }
        }

        private void talimatiIptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int sayac = 0;
                foreach (DataGridViewRow item in dataGridViewTalimatlar.SelectedRows)
                {
                    //yüklenmiş bir talimat iptal edilemez/ silinemez
                    if ((bool)item.Cells["YuklendiMi"].Value)
                    {
                        MessageBox.Show($"DİKKAT! {item.Cells["Akbil"]} nolu akbilin {item.Cells["Yüklenecek Tutar"]} liralık yüklemesi yapılmıştır. " +
                            $"YÜKLENEN TALİMAT İPTAL EDİLEMEZ/SİLİNEMEZ \nİŞLEMLERİNNİZE devam etmek için tamama basınız.");
                        continue;
                    }//if bitti
                    sayac += veriTabaniIslemleri.VeriSil("Talimatlar", $"Id={item.Cells["Id"].Value}");
                }//foreach bitti
                MessageBox.Show($"Seçtiğiniz {sayac} adet talimat iptal edilmiştir.");
                TalimatlariDataGrideGetir();
                BekleyenTalimatSayisiniGetir();

            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir sorun oluştu! " + hata.Message);
            }
        }
    }
}
