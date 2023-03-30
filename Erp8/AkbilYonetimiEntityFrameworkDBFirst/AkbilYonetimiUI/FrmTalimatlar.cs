﻿
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani;
using AkbilYonetimiVeriKatmani.Models;

namespace AkbilYonetimiUI
{
    public partial class FrmTalimatlar : Form
    {
        AkbildbContext context = new AkbildbContext();

        public FrmTalimatlar()
        {
            InitializeComponent();
        }
        private void FrmTalimatlar_Load(object sender, EventArgs e)
        {
            //Comboxa akbilleri getir
            ComboBoxaKullanicininAkbilleriniGetir();
            cmbBoxAkbiller.SelectedIndex = -1;
            cmbBoxAkbiller.Text = "Akbil seçiniz...";
            // cmbBoxAkbiller.DropDownStyle = ComboBoxStyle.DropDownList;
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
                //burada bekleyen taliatları bulur
                var bekleyen = context.KullanicininTalimatlaris.Where(x => x.KullaniciId ==
                GenelIslemler.GirisYapanKullaniciID && !x.YuklendiMi);
                
                if (cmbBoxAkbiller.SelectedIndex > 0)
                {
                    //burada ise bekleyen talimatlar içinden sadece cmboda seçili olanın sayısını alıyoruz
                    bekleyen.Count(x => x.Akbil.Substring(0, 16)
                    == cmbBoxAkbiller.SelectedItem.ToString()).ToString();
                }
                else
                {
                    //bekleyen talimatı yukarıda almıştık.Aldığımız sonucu count ile saydık
                    lblBekleyenTalimat.Text = bekleyen.Count().ToString();
                }


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
                dataGridViewTalimatlar.DataSource = context.KullanicininTalimatlaris.Where(x =>
                x.KullaniciId == GenelIslemler.GirisYapanKullaniciID).ToString();

                foreach (DataGridViewColumn item in dataGridViewTalimatlar.Columns)
                {
                    item.Width = 200;
                }
                dataGridViewTalimatlar.Columns["Akbil"].Width = 400;

                //istediğiniz diğer kolonlara da ayarlama yapabilirsiniz.
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
                cmbBoxAkbiller.DataSource = context.Akbillers.Where(x => x.AkbilSahibiId ==
                GenelIslemler.GirisYapanKullaniciID).ToList();
                cmbBoxAkbiller.DisplayMember = "AkbilNo";
                cmbBoxAkbiller.ValueMember = "AkbilNo";
              
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu! " + hata.Message);
            }

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
            BekleyenTalimatSayisiniGetir();
            TalimatlariDataGrideGetir(checkBoxTumunuGoster.Checked);
        }

        private void btnTalimatKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBoxAkbiller.SelectedIndex < 0)
                {
                    MessageBox.Show("Akbil seçmeden talimat kaydedilemez! ");
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
            //GenelIslemler.GirisYapanKullaniciAdSoyad = string.Empty;
            //GenelIslemler.GirisYapanKullaniciID = 0;

            foreach (Form item in Application.OpenForms)
            {
                if (item.Name != "FrmGiris")
                {
                    item.Hide();
                }
            }
            Application.OpenForms["FrmGiris"].Show();
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
                    //Yüklenmiş bir talimat iptal edilemez/silinemez.
                    if ((bool)item.Cells["YuklendiMi"].Value)
                    {
                        MessageBox.Show($"DİKKAT! {item.Cells["Akbil"].Value} akbilin {item.Cells["Yüklenecek Tutar"].Value} liralık yüklemesi yapılmıştır. YÜKLENEN TALİMAT İPTAL EDİLEMEZ/SİLİNEMEZ! \nİşlemlerinize devam etmek için tamama basınız.");
                        continue;
                    } // if bitti                    

                } // foreach bitti

                MessageBox.Show($"Seçtiğiniz {sayac} adet talimat iptal edilmiştir.");
                TalimatlariDataGrideGetir();
                BekleyenTalimatSayisiniGetir();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir sorun oluştu! " + hata.Message);
            }
        }

        private void talimatiYukleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int sayac = 0;
                foreach (DataGridViewRow item in dataGridViewTalimatlar.SelectedRows)
                {
                    if ((bool)item.Cells["YuklendiMi"].Value)
                    {
                        continue;
                    }

                } // foreach bitti.
                MessageBox.Show($"{sayac} adet talimat akbile yüklendi!");
                TalimatlariDataGrideGetir();
                BekleyenTalimatSayisiniGetir();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu! " + hata.Message);
            }
        }
    }
}