using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaGiris
{
    public partial class FormKisiler : Form
    {
        public FormKisiler()
        {
            InitializeComponent();
        }

        private List<Kisi> _kisiler = new List<Kisi>();
        private Kisi? _seciliKisi;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_seciliKisi == null)
                try
                {
                    //Kisi kisi = new Kisi();
                    //kisi.Ad = txtAd.Text;
                    //kisi.Soyad = txtSoyad.Text;
                    //kisi.Tckn = txtTckn.Text;
                    //kisi.DogumTarihi = dtpDogumTarihi.Value;
                    //kisi.Telefon = txtTelefon.Text;
                    //kisi.Email = txtEmail.Text;
                    Kisi yeniKisi = new Kisi() //Object Initializer
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        Tckn = txtTckn.Text,
                        DogumTarihi = dtpDogumTarihi.Value,
                        Email = txtEmail.Text,
                        Telefon = txtTelefon.Text
                    };
                    //lstKisiler.DisplayMember = "Ad";
                    //lstKisiler.Items.Add(yeniKisi);
                    _kisiler.Add(yeniKisi);
                    lstKisiler.DataSource = _kisiler;
                    FormuTemizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu! {ex.Message}");
                }
            else
                //Guncelleme İşlemi
                try
                {
                    _seciliKisi.Ad = txtAd.Text;
                    _seciliKisi.Soyad = txtSoyad.Text;
                    _seciliKisi.Tckn = txtTckn.Text;
                    _seciliKisi.DogumTarihi = dtpDogumTarihi.Value;
                    _seciliKisi.Email = txtEmail.Text;
                    _seciliKisi.Telefon = txtTelefon.Text;
                    FormuTemizle();
                    btnKaydet.Text = "Kaydet";
                    _seciliKisi = null;
                    lstKisiler.DataSource = null;
                    lstKisiler.DataSource = _kisiler;


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata Oluştu! {ex.Message}");

                }

        }
        public void FormuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is DateTimePicker dPicker)
                {
                    //(item as DateTimePicker).Value = DateTime.Now; //Arasındaki farkı araştır mülakatta çıkar as - ...
                    //((DateTimePicker)item).Value = DateTime.Now; //as ile onunmuş gibi olur. DateTimePicker ile de cast yaparız
                    dPicker.Value = DateTime.Now;
                }
                else if (item is CheckBox cBox)
                    cBox.Checked = false;
                else if (item is ComboBox combo)
                    combo.SelectedIndex = -1;
                else if (item is ListBox listBox)
                {
                    listBox.SelectedIndex = -1;
                }
            }
        }
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null)
            {
                _seciliKisi = null;
                return;
            }

            _seciliKisi = lstKisiler.SelectedItem as Kisi;
            txtAd.Text = _seciliKisi.Ad;
            txtSoyad.Text = _seciliKisi.Soyad;
            txtTckn.Text = _seciliKisi.Tckn;
            txtTelefon.Text = _seciliKisi.Telefon;
            txtEmail.Text = _seciliKisi.Email;
            dtpDogumTarihi.Value = _seciliKisi.DogumTarihi;

            btnKaydet.Text = "Güncelle";

        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;
            var seciliKisi = lstKisiler.SelectedItem as Kisi;

            DialogResult result = MessageBox.Show($"{seciliKisi.Ad} " +
                $"{seciliKisi.Soyad} kişisini silmek istiyor musunuz?", "Silme " +
                "Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //lstKisiler.Items.Remove(seciliKisi);
                _kisiler.Remove(seciliKisi);
                lstKisiler.DataSource = null;
                lstKisiler.DataSource = _kisiler;
                FormuTemizle();
            }
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            string arama = txtAra.Text.ToLower(); //this formun text'i
            if (arama.Length < 3) return;
            List<Kisi> sonuc = new List<Kisi>();
            foreach (var item in _kisiler)
            {
                if (item.Ad.ToLower().Contains(arama) || item.Soyad.ToLower().Contains(arama) ||
                    item.Tckn.ToLower().StartsWith(arama))
                    sonuc.Add(item);
            }
            lstKisiler.DataSource = null;
            lstKisiler.DataSource = sonuc;

            //2.Yöntem
            sonuc = new();
            _kisiler.ForEach(item =>
            {
                if (item.Ad.ToLower().Contains(arama) || item.Soyad.ToLower().Contains(arama) ||
                   item.Tckn.ToLower().StartsWith(arama))
                    sonuc.Add(item);
            });
            lstKisiler.DataSource = null;
            lstKisiler.DataSource = sonuc;

            //3.Yöntem (Linq)
            sonuc = _kisiler
                .Where(item => item.Ad.ToLower().Contains(arama) || item.Soyad.ToLower().Contains(arama) ||
                   item.Tckn.ToLower().StartsWith(arama))
                    .ToList();
            lstKisiler.DataSource = null;
            lstKisiler.DataSource = sonuc;

        }
    }
}
