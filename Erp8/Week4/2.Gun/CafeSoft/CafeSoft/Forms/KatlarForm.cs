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
    public partial class KatlarForm : Form
    {
        public KatlarForm()
        {
            InitializeComponent();
        }
        public EnvanterContext DataContext { get; set; }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Kat kat = new Kat()
                {
                    KatAd = txtKatIsmi.Text,
                    MasaSayisi = Convert.ToInt32(txtMasaSayisi.Text)
                };
                DataContext.Katlar.Add(kat);
                lstKatlarimiz.DataSource = null;
                lstKatlarimiz.DataSource = DataContext.Katlar;

                for (int i = 1; i <= kat.MasaSayisi; i++)
                {
                    Masa masa = new Masa()
                    {
                        BulunduguKat = kat,
                        Ad = "Masa" + i.ToString()
                    };
                    DataContext.Masalar.Add(masa);
                }
                DataHelper.Save(DataContext);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir Hata Oluştu! {ex.Message}");
            }
        }

        private void KatlarForm_Load(object sender, EventArgs e)
        {
            lstKatlarimiz.DataSource = DataContext.Katlar;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKatlarimiz.SelectedItem == null) return;
            Kat? seciliKat = lstKatlarimiz.SelectedItem as Kat; //? değilde casting de yapılabilir
            try
            {
                seciliKat.KatAd = txtKatIsmi.Text;
                seciliKat.MasaSayisi = Convert.ToInt32(txtMasaSayisi.Text);
                for (int i = 0; i < DataContext.Masalar.Count; i++)
                {
                    if (seciliKat.KatAd == DataContext.Masalar[i].BulunduguKat.KatAd)
                    {
                        DataContext.Masalar.Remove(DataContext.Masalar[i]);
                        i--;
                    }
                }
                for (int i = 1; i <= seciliKat.MasaSayisi; i++)
                {
                    Masa masa = new Masa
                    {
                        Ad = "Masa" + i.ToString(),
                        BulunduguKat = seciliKat
                    };
                    DataContext.Masalar.Add(masa);
                }
                DataHelper.Save(DataContext);
                lstKatlarimiz.DataSource = null;
                lstKatlarimiz.DataSource = DataContext.Katlar;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu! {ex.Message}");
            }
        }
        private void lstKatlarimiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKatlarimiz.SelectedItem == null) return;
            Kat seciliKat = (Kat)lstKatlarimiz.SelectedItem;
            txtKatIsmi.Text = seciliKat.KatAd;
            txtMasaSayisi.Text = seciliKat.MasaSayisi.ToString();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstKatlarimiz.SelectedItem == null) return;
            Kat seciliKat = (Kat)lstKatlarimiz.SelectedItem;
            DataContext.Katlar.Remove(seciliKat);
            for (int i = 0; i < DataContext.Masalar.Count;i++)
            {
                DataContext.Masalar.Remove(DataContext.Masalar[i]);
                i--;
            }
            DataHelper.Save(DataContext);
            lstKatlarimiz.DataSource = null;
            lstKatlarimiz.DataSource = DataContext.Katlar;
        }
    }
}
