namespace ZarTahminWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly Random _rnd = new Random();
        private int _zar1 = 0, _zar2 = 0, _sayi = 0, _sayac = 0;
        private void btnDondur_Click(object sender, EventArgs e)
        {
            if (cmbSayilar.SelectedIndex == -1)
            {
                MessageBox.Show("Bir hata oluştu");
                return;
            }
            _sayi = cmbSayilar.SelectedIndex + 1;
            tmr1.Start();
            lstSonuc.Items.Clear();
            btnDondur.Enabled = false;
            tmr1.Interval = 1000;

        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            _sayac++;
            _zar1 = _rnd.Next(1, 7);
            _zar2 = _rnd.Next(1, 7);
            lstSonuc.Items.Insert(0, $"{_sayac:00}) denemede {_zar1} {_zar2}");
            btn1.Text = _zar1.ToString();
            btn2.Text = _zar2.ToString();
            this.Text = $"{_sayac}. Deneme";
            if (_zar1 == _zar2 && _zar1 == _sayi)
            {
                this.Text = $"{_sayac} denemede {_sayi}-{_sayi} tahmini bulundu";
                btnDondur.Enabled = true;
                _sayac = 0;
                tmr1.Stop();
            }
            var interval = (int)(tmr1.Interval * 0.85);
            tmr1.Interval = interval <= 1 ? 1 : interval;
        }
    }
}