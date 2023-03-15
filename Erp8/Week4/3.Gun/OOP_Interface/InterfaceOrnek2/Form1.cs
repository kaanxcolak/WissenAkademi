using InterfaceOrnek2.Entities;

namespace InterfaceOrnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpBoxIslemler.Enabled = false;
            radioBtnDikdortgen.Checked = false;
            radioBtnKare.Checked = true;
            // radiolar biri mutlaka secilil geldiği için 
            //secili gelen şekle göre groupbox'ı ayarladık
            grpBoxIslemler.Enabled = true;
            lblKenar2.Visible = false;
            txtKenar2.Enabled = false;
            lblKenar1.Text = "Kare İsim";

            btnAlanHesapla.Click += new EventHandler(Hesapla);
            btnCevreHesapla.Click += new EventHandler(Hesapla);
        }//form load metot bitti

        private void Hesapla(object sender, EventArgs e) //
        {
            //sender kim?
            string islemAdi = "";
            if (((Button)sender).Name.Contains("cevre"))//casting işlemiyle ona sen Button sun edmiş oluruz
                islemAdi = "cevre";
            if (((Button)sender).Name == "btnAlanHesala")
                islemAdi = "alan";
            //kimin alanı ya da cevresi?
            if (radioBtnDikdortgen.Checked)
            {
                Dikdortgen d = new Dikdortgen()
                {
                    SekilAdi = txtSekilAdi.Text,
                    KisaKenar = Convert.ToInt32(txtKenar1.Text),
                    UzunKenar = Convert.ToInt32(txtKenar2.Text),
                };
                double sonuc = 0;
                switch (islemAdi)
                {
                    case "cevre":
                        //MessageBox.Show(d.CevreHesapla().ToString());
                        sonuc = d.CevreHesapla();
                        break;
                    case "alan":
                        //MessageBox.Show(d.AlanHesapla().ToString());
                        sonuc = d.AlanHesapla();
                        break;
                }
                MessageBox.Show($"{d.SekilAdi} adlı şeklin {islemAdi} hesaplandı = {sonuc}");

            }
            else if (radioBtnKare.Checked)
            {
                Kare k = new Kare()
                {
                    SekilAdi = txtSekilAdi.Text,
                    Kenar = Convert.ToInt32(txtKenar1.Text)
                };
                double sonuc = 0;
                switch (islemAdi)
                {
                    case "cevre":
                        sonuc = k.CevreHesapla();
                        break;
                    case "alan":
                        sonuc = k.AlanHesapla();
                        break;
                }
                MessageBox.Show($"{k.SekilAdi} adlı şeklin {islemAdi} hesaplandı = {sonuc}");
            }
            Temizle();
        }
        private void Temizle()
        {
            foreach (var item in grpBoxIslemler.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
            }
            //grpBoxIslemler.Enabled = false;
        }

        private void radioBtnDikdortgen_CheckedChanged(object sender, EventArgs e)
        {
            lblKenar1.Visible = true;
            txtKenar1.Visible = true;

            lblKenar2.Visible = true;
            txtKenar2.Visible = true;

            lblKenar1.Text = "Dikdörtgen Ýsim:";
        }

        private void radioBtnKare_CheckedChanged(object sender, EventArgs e)
        {
            lblKenar1.Visible = true;
            txtKenar1.Visible = true;

            lblKenar2.Visible = false;
            txtKenar2.Visible = false;

            lblKenar1.Text = "Kare Ýsim:";
        }
    }
}
