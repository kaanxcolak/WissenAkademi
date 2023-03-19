using InterfaceOrnek_Odeme.Entities;

namespace InterfaceOrnek_Odeme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lblTutar.Text = rnd.Next(1000, 5000).ToString();
            groupBoxKrediKarti.Visible = false;
            kartSonAy.Minimum = 1;
            kartSonAy.Maximum = 12;
        }
        private void groupBoxKrediKartiTemizle()
        {
            txtKartCVC.Clear();
            txtKartSahibi.Clear();
            maskedtxtKartNo.Clear();
            kartSonYil.Clear();
            kartSonAy.Value = kartSonAy.Minimum;
        }

        private void btnKrediKartiOde_Click(object sender, EventArgs e)
        {
            try
            {
                KrediKartiylaOdeme odeme = new KrediKartiylaOdeme();
                odeme.OdenecekTutar = Convert.ToDecimal(lblTutar.Text); // Randomu yukarý yazmadýk bu nedenle ödemeyi mecburen labeldan aldýk
                odeme.KartSahibi = txtKartSahibi.Text;
                odeme.KartNumarasi = txtKartNo.Text;
                odeme.SonKullanimYil = Convert.ToByte(kartSonYil.Text);
                odeme.SonKullanimAy = Convert.ToByte(kartSonAy.Value);
                odeme.CVC = Convert.ToInt32(txtKartCVC.Text);
                MessageBox.Show(odeme.OdemeYap());
                groupBoxKrediKartiTemizle();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxKapi_CheckedChanged(object sender, EventArgs e)
        {
            //1. yöntem
            if (checkBoxKapi.Checked)
            {
                checkBoxCuzdan.Checked = false;
                checkBoxKrediKart.Checked = false;
                checkBoxCuzdan.Enabled = false;
                checkBoxKrediKart.Enabled = false;
            }
            else
            {
                checkBoxCuzdan.Enabled = true;
                checkBoxKrediKart.Enabled = true;
            }
        }
        private void checkBoxKrediKart_CheckedChanged(object sender, EventArgs e)
        {
            //2. yöntem
            if (checkBoxKrediKart.CheckState == CheckState.Checked)
            {
                groupBoxKrediKarti.Visible = true;
                foreach (CheckBox item in grpBoxOdemeSekli.Controls)
                {
                    if (item.Name != "checkBoxKrediKart")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
            else
            {
                groupBoxKrediKarti.Visible = false;

                foreach (CheckBox item in grpBoxOdemeSekli.Controls)
                {
                    if (item.Name != "checkBoxKrediKart")
                    {
                        item.Enabled = true;
                    }
                }
            }
        }
    }
}






