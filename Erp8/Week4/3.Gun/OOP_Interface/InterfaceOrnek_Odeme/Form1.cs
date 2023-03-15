namespace InterfaceOrnek_Odeme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxKapi_CheckedChanged(object sender, EventArgs e)
        {
            //1.Yontem
            if (checkBoxKapi.Checked)
            {
                checkBoxCuzdan.Checked = false;
                checkBoxKrediKart.Checked = false;
                checkBoxCuzdan.Enabled = false;
                checkBoxKrediKart.Enabled = false;
            }
            else
            {
                //////////////////////////77
            }
        }

        private void checkBoxKrediKart_CheckedChanged(object sender, EventArgs e)
        {
            //2.Yontem
            if (checkBoxKrediKart.CheckState == CheckState.Checked)
            {
                foreach (CheckBox item in grpBoxOdemeSekli.Controls)
                {
                    if (item.Name != ("checkBoxKrediKart"))
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
            else
            {
                foreach (CheckBox item in grpBoxOdemeSekli.Controls)
                {
                    if (item.Name != ("checkBoxKrediKart"))
                    {
                        item.Enabled = true;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lblTutar.Text = rnd.Next(1000, 5000).ToString();
            groupBoxKrediKarti.Visible = false;
            kartSon
        }
        private void groupBoxKrediKartiTemizle()
        {
            txtKartCVC.Clear();
            txtKartSahibi.Clear();
            maskedtxtKartNo.Clear();
            kartSonYil.Clear();
            kartSonAy.Clear();

        }
    }
}