using CafeSoft.Models;
using CafeSoft.Data;
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
    public partial class AnaSayfaForm : Form
    {
        public AnaSayfaForm()
        {
            InitializeComponent();
        }
        private Masa _masa;
        private Button _clickedKategori;
        private Button _clickedKat;
        Urun eklenecekUrun;

        private EnvanterContext DataContext;
        private void AnaSayfaForm_Load(object sender, EventArgs e)
        {
            foreach (var item in DataContext.Katlar)
            {
                Button btn = new Button();
                btn.Text = item.KatAd;
                btn.Size = new Size(100, 50);
                btn.Click += KatButon_Click;
                flpKatlar.Controls.Add(btn);
                label1.Visible = false;
                lblToplam.Visible = false;
                btnHesapAl.Visible = false;
            }
        }
        private void KatButon_Click(object? sender, EventArgs e)
        {
            flpMasalar.Controls.Clear();
            flpKategoriler.Controls.Clear();
            flpUrunler.Controls.Clear();
            flpNuds.Controls.Clear();
            flpLabels.Controls.Clear();
            flpToplamFiyat.Controls.Clear();
            label1.Visible = false;
            lblToplam.Visible = false;
            btnHesapAl.Visible = false;
            if(_clickedKat != null) _clickedKat.BackColor = Color.White;
            foreach(var item in DataContext.Masalar)
            {
                if((sender as Button).Text == item.BulunduguKat.KatAd)
                {
                    Button btnMasa = new Button();
                    btnMasa.Name = item.Id.ToString();
                    btnMasa.Text = item.Ad;
                    btnMasa.Size = new Size(50, 50);
                    btnMasa.Click += MasaButon_Click;
                    if (item.DoluMu)
                        btnMasa.BackColor = Color.Red;
                    else
                        btnMasa.BackColor = Color.LightGreen;
                    flpMasalar.Controls.Add(btnMasa);
                } 
            }
            _clickedKat = sender as Button;
            _clickedKat.BackColor = Color.DarkGray;
        }

        private void MasaButon_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void flpKatlar_Paint(object sender, PaintEventArgs e)
        {

        }
        //GunlukRapor rapor = new GunlukRapor();
    }
}
