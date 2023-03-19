using CafeSoft.Data;
using CafeSoft.Forms;
using CafeSoft.Helpers;

namespace CafeSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private EnvanterContext _dataContext;
        private KatlarForm _katlarForm;
        private AnaSayfaForm _anaSayfaForm;
        private KategorilerForm _kategorilerForm;
        private UrunFormu _urunForm;
        private void Form1_Load(object sender, EventArgs e)
        {
            var data = DataHelper.Load();
            _dataContext = data ?? new EnvanterContext(); //"null coalescing operator"
            //--> ?? operatörü bir değişkenin null olup olmadığını kontrol eder ve null ise alternatif değer atar.
            //Hata alınmasını önlemek için kullanılır.
            anaSayfaToolStripMenuItem_Click(this, new EventArgs());
        }
        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_katlarForm != null) _katlarForm.Close();
            if (_urunForm != null) _urunForm.Close();
            if (_kategorilerForm != null) _kategorilerForm.Close();
            if (_anaSayfaForm == null || _anaSayfaForm.IsDisposed)
            {
                _anaSayfaForm = new AnaSayfaForm();
                _anaSayfaForm.MdiParent = this;
                _anaSayfaForm.Text = "AnaSayfa Form";
                _anaSayfaForm.WindowState = FormWindowState.Maximized;
                _anaSayfaForm.DataContext = _dataContext;
                _anaSayfaForm.Show();
            }
        }

        private void katToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_anaSayfaForm != null) _anaSayfaForm.Close();
            if (_kategorilerForm != null) _kategorilerForm.Close();
            if (_urunForm != null) _urunForm.Close();
            if (_katlarForm == null || _katlarForm.IsDisposed)
            {
                _katlarForm = new KatlarForm();
                _katlarForm.MdiParent = this;
                _katlarForm.Text = "KatlarForm";
                _katlarForm.WindowState = FormWindowState.Maximized;
                _katlarForm.DataContext = _dataContext;
                _katlarForm.Show();
            }
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_anaSayfaForm != null) _anaSayfaForm.Close();
            if (_urunForm != null) _urunForm.Close();
            if (_katlarForm != null) _katlarForm.Close();
            if (_kategorilerForm == null || _kategorilerForm.IsDisposed)
            {
                _kategorilerForm = new KategorilerForm();
                _kategorilerForm.MdiParent = this;
                _kategorilerForm.Text = "KategorilerForm";
                _kategorilerForm.WindowState = FormWindowState.Maximized;
                _kategorilerForm.DataContext = _dataContext;
                _kategorilerForm.Show();
            }
        }

        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_anaSayfaForm != null) _anaSayfaForm.Close();
            if (_katlarForm != null) _katlarForm.Close();
            if (_kategorilerForm != null) _kategorilerForm.Close();
            if (_urunForm == null || _urunForm.IsDisposed)
            {
                _urunForm = new UrunFormu();
                _urunForm.MdiParent = this;
                _urunForm.Text = "UrunFormu";
                _urunForm.WindowState = FormWindowState.Maximized;
                _urunForm.DataContext = _dataContext;
                _urunForm.Show();
            }

        }
    }
}