using InterfaceOrnek2.Entities;

namespace InterfaceOrnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpBoxIslemler.Enabled = false;
            radioBtnDikdortgen.Checked = false;
            radioBtnKare.Checked = true;
            // radiolar biri mutlaka seçili geldiði için
            // seçili gelen þekle göre groupboxý ayarladýk. 
            grpBoxIslemler.Enabled = true;

            lblKenar2.Visible = false;
            txtKenar2.Visible = false;
            lblKenar1.Text = "Kare Ýsim:";

            btnAlanHesapla.Click += new EventHandler(Hesapla);
            // btnAlanHesapla.Click += new EventHandler(btnAlanHesapla_Click);

            // btnCevreHesapla.Click += new EventHandler(Hesapla);
            btnCevreHesapla.Click += new EventHandler(btnCevreHesapla_Click);
        } // form load metot bitti

        private void Hesapla(object sender, EventArgs e) // týklanan OBJE
        {
            //sender kim?
            string islemAdi = "";
            if (((Button)sender).Name.Contains("Cevre"))
            {
                islemAdi = "cevre";
            }
            if (((Button)sender).Name == "btnAlanHesapla")
            {
                islemAdi = "alan";
            }

            // kimin alaný ya da kimin çevresi?
            if (radioBtnDikdortgen.Checked)
            {
                if (string.IsNullOrEmpty(txtKenar1.Text)
               || string.IsNullOrEmpty(txtKenar2.Text))
                {
                    MessageBox.Show("DÝKDÖRTGEN ÝÇÝN LÜTFEN BÝLGÝLERÝ EKSÝKSÝZ GÝR!");
                    return;
                }
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
                        sonuc = d.CevreHesapla();
                        break;
                    case "alan":
                        sonuc = d.AlanHesapla();
                        break;
                }
                MessageBox.Show($"{d.SekilAdi} adlý þeklin {islemAdi} hesaplandý = {sonuc}");
            }
            else if (radioBtnKare.Checked)
            {
                if (string.IsNullOrEmpty(txtKenar1.Text)
               )
                {
                    MessageBox.Show("KARE ÝÇÝN LÜTFEN BÝLGÝLERÝ EKSÝKSÝZ GÝR!");
                    return;
                }
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
                MessageBox.Show($"{k.SekilAdi} adlý þeklin {islemAdi} hesaplandý = {sonuc}");
            }
        }
        private void Temizle()
        {
            foreach (var item in grpBoxIslemler.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
            }
            grpBoxIslemler.Enabled = false;
        }

        private void radioBtnDikdortgen_CheckedChanged(object sender, EventArgs e)
        {
            Temizle();
            grpBoxIslemler.Enabled = true;

            lblKenar1.Visible = true;
            txtKenar1.Visible = true;

            lblKenar2.Visible = true;
            txtKenar2.Visible = true;

            lblKenar1.Text = "Kýsa Kenar:";
            lblKenar2.Text = "Uzun Kenar:";
            lblSekilAdi.Text = "Dikdörtgen Ýsim:";

        }

        private void radioBtnKare_CheckedChanged(object sender, EventArgs e)
        {
            Temizle();
            grpBoxIslemler.Enabled = true;
            lblKenar1.Visible = true;
            txtKenar1.Visible = true;

            lblKenar2.Visible = false;
            txtKenar2.Visible = false;

            lblKenar1.Text = "Kenar:";
            lblSekilAdi.Text = "Kare Ýsim:";
        }

        private void btnAlanHesapla_Click(object sender, EventArgs e)
        {
            // kimin alaný ya da kimin çevresi?
            if (radioBtnDikdortgen.Checked)
            {
                if (string.IsNullOrEmpty(txtKenar1.Text)
               || string.IsNullOrEmpty(txtKenar2.Text))
                {
                    MessageBox.Show("DÝKDÖRTGEN ÝÇÝN LÜTFEN BÝLGÝLERÝ EKSÝKSÝZ GÝR!");
                    return;
                }
                Dikdortgen d = new Dikdortgen()
                {
                    SekilAdi = txtSekilAdi.Text,
                    KisaKenar = Convert.ToInt32(txtKenar1.Text),
                    UzunKenar = Convert.ToInt32(txtKenar2.Text),
                };

                double sonuc = d.AlanHesapla();

                MessageBox.Show($"{d.SekilAdi} adlý þeklin ALANI hesaplandý = {sonuc}");
            }
            else if (radioBtnKare.Checked)
            {
                if (string.IsNullOrEmpty(txtKenar1.Text)
               )
                {
                    MessageBox.Show("KARE ÝÇÝN LÜTFEN BÝLGÝLERÝ EKSÝKSÝZ GÝR!");
                    return;
                }
                Kare k = new Kare()
                {
                    SekilAdi = txtSekilAdi.Text,
                    Kenar = Convert.ToInt32(txtKenar1.Text)
                };
                double sonuc = k.AlanHesapla();
                MessageBox.Show($"{k.SekilAdi} adlý þeklin ALANI hesaplandý = {sonuc}");
            }
        }

        private void btnCevreHesapla_Click(object sender, EventArgs e)
        {
            // kimin alaný ya da kimin çevresi?
            if (radioBtnDikdortgen.Checked)
            {
                if (string.IsNullOrEmpty(txtKenar1.Text)
               || string.IsNullOrEmpty(txtKenar2.Text))
                {
                    MessageBox.Show("DÝKDÖRTGEN ÝÇÝN LÜTFEN BÝLGÝLERÝ EKSÝKSÝZ GÝR!");
                    return;
                }
                Dikdortgen d = new Dikdortgen()
                {
                    SekilAdi = txtSekilAdi.Text,
                    KisaKenar = Convert.ToInt32(txtKenar1.Text),
                    UzunKenar = Convert.ToInt32(txtKenar2.Text),
                };

                double sonuc = d.CevreHesapla();

                MessageBox.Show($"{d.SekilAdi} adlý þeklin ÇEVRE hesaplandý = {sonuc}");
            }
            else if (radioBtnKare.Checked)
            {
                if (string.IsNullOrEmpty(txtKenar1.Text)
               )
                {
                    MessageBox.Show("KARE ÝÇÝN LÜTFEN BÝLGÝLERÝ EKSÝKSÝZ GÝR!");
                    return;
                }
                Kare k = new Kare()
                {
                    SekilAdi = txtSekilAdi.Text,
                    Kenar = Convert.ToInt32(txtKenar1.Text)
                };
                double sonuc = k.CevreHesapla();
                MessageBox.Show($"{k.SekilAdi} adlý þeklin ÇEVRE hesaplandý = {sonuc}");
            }

        }
    }
}