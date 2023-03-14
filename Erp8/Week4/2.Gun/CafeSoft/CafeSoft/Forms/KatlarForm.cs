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

                for(int i = 1; i <= kat.MasaSayisi; i++)
                {
                    Masa masa = new Masa()
                    {
                        Ad = "Masa" + i.ToString(),
                        BulunduguKat = kat
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
    }
}
