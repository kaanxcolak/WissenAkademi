﻿using AkbilYntmIsKatmani;
using AkbilYntmVeriKatmani;
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
    public partial class FrmAkbiller : Form
    {
        IVeriTabaniIslemleri veriTabaniIslemleri = new SQLVeriTabaniIslemleri();
        public FrmAkbiller()
        {
            InitializeComponent();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // kontroller

                if (cmbBoxAkbilTipleri.SelectedIndex < 0)
                {
                    MessageBox.Show("Lütfen ekleyeceğiniz akbilin türünü seçiniz!");
                    return;
                }
                if (maskedTextBoxAkbilNo.Text.Length < 16)
                {
                    MessageBox.Show("Akbil No 16 haneli olmak zorundadır!");
                    return;
                }
                Dictionary<string, object> yeniAkbilBilgileri = new Dictionary<string, object>();
                yeniAkbilBilgileri.Add("AkbilNo", $"'{maskedTextBoxAkbilNo.Text}'");
                yeniAkbilBilgileri.Add("Bakiye", 0);
                yeniAkbilBilgileri.Add("AkbilTipi", $"'{cmbBoxAkbilTipleri.SelectedItem}'");
                yeniAkbilBilgileri.Add("EklenmeTarihi", $"'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'");
                yeniAkbilBilgileri.Add("VizelendigiTarih", "null");
                yeniAkbilBilgileri.Add("AkbilSahibiId", GenelIslemler.GirisYapanKullaniciID);

                string insertCumle = veriTabaniIslemleri.VeriEklemeCumlesiOlustur("Akbiller", yeniAkbilBilgileri);
                int sonuc = veriTabaniIslemleri.KomutIsle(insertCumle);
                if (sonuc > 0)
                {
                    MessageBox.Show("Akbil eklendi");
                    DataGridViewiDoldur();
                    maskedTextBoxAkbilNo.Clear();
                    cmbBoxAkbilTipleri.SelectedIndex = -1;
                    cmbBoxAkbilTipleri.Text = "Akbil Tipi Seçiniz";
                }
                else
                {
                    MessageBox.Show("Akbil eklenemedi!");
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu !" + hata.Message);
            }
        }

        private void FrmAkbiller_Load(object sender, EventArgs e)
        {
            cmbBoxAkbilTipleri.Text = "Akbil tipi seçniz...";
            cmbBoxAkbilTipleri.SelectedIndex = -1;

            DataGridViewiDoldur();
        }

        private void DataGridViewiDoldur()
        {
            try
            {

                dataGridViewAkbiller.DataSource = veriTabaniIslemleri.VeriGetir("Akbiller", kosullar: $"AkbilSahibiId={GenelIslemler.GirisYapanKullaniciID}");

                //bazı kolonlar gizlensin
                dataGridViewAkbiller.Columns["AkbilSahibiId"].Visible = false;
                dataGridViewAkbiller.Columns["VizelendigiTarih"].HeaderText = "Vizelendiği Tarih";
                dataGridViewAkbiller.Columns["VizelendigiTarih"].Width = 200;

            }
            catch (Exception hata)
            {

                MessageBox.Show("Akbilleri listeleyemedim !" + hata.Message);
            }
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frma = new FrmAnasayfa();
            this.Hide();
            frma.Show();

        }

        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış yapıldı");
            FrmAnasayfa frma = new FrmAnasayfa(); 
            this.Hide();
            frma.Show();
        }
    }
}