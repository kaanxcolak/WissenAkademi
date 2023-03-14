namespace KronometreWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int saat = 0;
        int dakika = 0;
        int saniye = 0;
        int salise = 0;
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++; 
            
            if (salise == 100)
            {
                salise = 0;
                saniye++;
            }
            else if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }
            else if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }
            lblSalise.Text = salise.ToString();
            lblSaniye.Text = saniye.ToString();
            lblDakika.Text = dakika.ToString();
            lblSaat.Text = saat.ToString();
            var interval = (int)(timer1.Interval * 0.85);
            timer1.Interval = interval <= 1 ? 1 : interval;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lstZamanlar.Items.Add($"{saat:00}:{dakika:00}:{saniye:00}:{salise:00}");
            btnStart.Text = "Continue";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            salise = 0;
            saniye = 0;
            dakika = 0;
            saat = 0;
            lblSalise.Text = salise.ToString();
            lblSaniye.Text = saniye.ToString();
            lblDakika.Text = dakika.ToString();
            lblSaat.Text = saat.ToString();
            lstZamanlar.Items.Clear();
            btnStart.Text = "Start";
        }
    }
}