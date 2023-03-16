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
    public partial class KategorilerForm : Form
    {
        public KategorilerForm()
        {
            InitializeComponent();
        }
        public EnvanterContext DataContext { get; set; }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategori = new Kategori();
                kategori.Ad = txtKategoriAd.Text;
                DataContext.Kategoriler.Add(kategori);
                lstKategori.DataSource = null;
                lstKategori.DataSource = DataContext.Kategoriler;
                DataHelper.Save(DataContext);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Bir hata oluştu! {ex.Message}");
            }
        }

        private void KategorilerForm_Load(object sender, EventArgs e)
        {
            lstKategori.DataSource = DataContext.Kategoriler;
        }

        private void lstKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItem == null) return;
            Kategori seciliKategori = (Kategori)lstKategori.SelectedItem;
            txtKategoriAd.Text = seciliKategori.Ad;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItem == null) return;
            try
            {
                Kategori seciliKategori = (Kategori)lstKategori.SelectedItem;
                seciliKategori.Ad = txtKategoriAd.Text;
                lstKategori.DataSource = null;
                lstKategori.DataSource = DataContext.Kategoriler;
                DataHelper.Save(DataContext);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu! {ex.Message}");
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstKategori.SelectedItem == null) return;
            Kategori seciliKategori = (Kategori)lstKategori.SelectedItem;
            DataContext.Kategoriler.Remove(seciliKategori);
            for(int i = 0; i<DataContext.Urunler.Count;i++)
            {
                if(seciliKategori.Ad == DataContext.Urunler[i].Ad)
                {
                    DataContext.Urunler.Remove(DataContext.Urunler[i]);
                    i--;
                }
            }
            lstKategori.DataSource = null;
            lstKategori.DataSource = DataContext.Kategoriler;
            DataHelper.Save(DataContext);
        }
    }
}
