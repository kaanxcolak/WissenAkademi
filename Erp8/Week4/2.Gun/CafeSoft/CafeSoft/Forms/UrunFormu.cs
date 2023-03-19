using CafeSoft.Data;
using CafeSoft.Helpers;
using CafeSoft.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSoft.Forms
{
    public partial class UrunFormu : Form
    {
        public UrunFormu()
        {
            InitializeComponent();
        }
        public EnvanterContext DataContext { get; set; }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = new Urun()
                {
                    Kategori = (Kategori)cmbUrunKategori.SelectedItem,
                    Ad = txtUrunAd.Text,
                    Fiyat = decimal.Parse(txtUrunFiyat.Text)
                };
                if (pbAvatar.Image != null)
                {
                    urun.Fotograf = (byte[])(new ImageConverter().ConvertTo(pbAvatar.Image, typeof(byte[])));
                }
                DataContext.Urunler.Add(urun);
                lstUrunler.DataSource = null;
                lstUrunler.DataSource = DataContext.Urunler;
                DataHelper.Save(DataContext);


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaAc = new OpenFileDialog();
            dosyaAc.Title = "Görsel Seçiniz";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.Multiselect = false;
            dosyaAc.Filter = "Görsel Dosyası |*.jpg; *.png; *.jpeg";
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                pbAvatar.Image = Image.FromFile(dosyaAc.FileName);
            }
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;
            Urun urun = (Urun)lstUrunler.SelectedItem;
            txtUrunAd.Text = urun.Ad.ToString();
            txtUrunFiyat.Text = urun.Fiyat.ToString();
            cmbUrunKategori.SelectedItem = DataContext.Kategoriler.Find(x => x.Ad == urun.Kategori.Ad);
            if (urun.Fotograf != null)
            {
                pbAvatar.Image = (Image)(new ImageConverter().ConvertFrom(urun.Fotograf));
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;
            Urun urun = (Urun)lstUrunler.SelectedItem;

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;
            Urun seciliUrun = (Urun)lstUrunler.SelectedItem;
            DataContext.Urunler.Remove(seciliUrun);
            DataHelper.Save(DataContext);
            lstUrunler.DataSource = null;
            lstUrunler.DataSource = DataContext.Urunler;
        }

        private void UrunFormu_Load(object sender, EventArgs e)
        {
            cmbUrunKategori.DataSource = DataContext.Kategoriler;
            lstUrunler.DataSource = DataContext.Urunler;
        }
    }
}
