using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
namespace AracTakipUygulaması;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private List<Arac> _araclar = new List<Arac>();
    private Arac? _seciliArac;
    private MemoryStream _memoryStream = new MemoryStream();
    private int _bufferSize = 64;
    private byte[] _photosBytes = new byte[64];
    private void btnEkle_Click(object sender, EventArgs e)
    {
        if (_seciliArac == null)
        {
            try
            {
                Arac yeniArac = new Arac()
                {
                    Marka = txtMarka.Text,
                    Model = txtModel.Text,
                    ModelYili = txtModelYili.Text,
                    SaseNo = txtSase.Text,
                    YakitTipi = txtYakitTipi.Text,
                    VitesTipi = txtVitesTipi.Text,
                    MotorHacmi = txtMotorHacmi.Text,
                };
                if (_memoryStream.Length > 0)
                {
                    yeniArac.Fotograf = _memoryStream.ToArray();
                }
                _memoryStream = new MemoryStream();
                _araclar.Add(yeniArac);
                lstAraclar.DataSource = null;
                lstAraclar.DataSource = _araclar;
                FormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu! {ex.Message}");
            }
            //dosyaKaydet.Title = "Bir JSON dosyası seçiniz";
            //dosyaKaydet.Filter = "(JSON Dosyası) | *.json";
            //dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //dosyaKaydet.FileName = "Araclar.json";
            //if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            //{
            //    FileStream file = File.Open(dosyaKaydet.FileName, FileMode.Create);
            //    StreamWriter writer = new StreamWriter(file);
            //    writer.Write(JsonConvert.SerializeObject(_araclar));
            //    writer.Close();
            //    writer.Dispose();
            //}   
        }
        else
        {
            //Güncelleme
            try
            {
                _seciliArac.Marka = txtMarka.Text;
                _seciliArac.Model = txtModel.Text;
                _seciliArac.ModelYili = txtModelYili.Text;
                _seciliArac.SaseNo = txtSase.Text;
                _seciliArac.YakitTipi = txtYakitTipi.Text;
                _seciliArac.VitesTipi = txtVitesTipi.Text;
                _seciliArac.MotorHacmi = txtMotorHacmi.Text;
                if (_memoryStream.Length > 0)
                {
                    _seciliArac.Fotograf = _memoryStream.ToArray();
                }
                FormuTemizle();
                btnEkle.Text = "Ekle";
                _seciliArac = null;
                lstAraclar.DataSource = null;
                lstAraclar.DataSource = _araclar;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu! {ex.Message}");
            }
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
    private void lstAraclar_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstAraclar.SelectedItem == null)
        {
            _seciliArac = null;
            btnEkle.Text = "Ekle";
            return;
        }
        else
        {
            _seciliArac = lstAraclar.SelectedItem as Arac;
            txtMarka.Text = _seciliArac.Marka;
            txtModel.Text = _seciliArac.Model;
            txtModelYili.Text = _seciliArac.ModelYili;
            txtSase.Text = _seciliArac.SaseNo;
            txtYakitTipi.Text = _seciliArac.YakitTipi;
            txtVitesTipi.Text = _seciliArac.VitesTipi;
            txtMotorHacmi.Text = _seciliArac.MotorHacmi;
            pbAvatar.Image = _seciliArac.Fotograf != null ? Image.FromStream(new MemoryStream(_seciliArac.Fotograf)) : null;
            btnEkle.Text = "Güncelle";
        }
    }
    private void silToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (lstAraclar.SelectedItem == null) return;
        var seciliArac = lstAraclar.SelectedItem as Arac;
        DialogResult result = MessageBox.Show($"{seciliArac.Marka} {seciliArac.Model} aracını silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            _araclar.Remove(seciliArac);
            lstAraclar.DataSource = null;
            lstAraclar.DataSource = _araclar;
            FormuTemizle();
            btnEkle.Text = "Ekle";
        }
    }

    private void txtAra_KeyUp(object sender, KeyEventArgs e)
    {
        string arama = txtAra.Text.ToLower();
        List<Arac> sonuc = _araclar
            .Where(item => item.Marka.ToLower().Contains(arama) || item.Model.ToLower().Contains(arama))
            .ToList();
        lstAraclar.DataSource = null;
        lstAraclar.DataSource = sonuc;
    }



    private void pbAvatar_Click(object sender, EventArgs e)
    {
        dosyaAc.Title = "Bir fotoğraf dosyası seçiniz";
        dosyaAc.Filter = "JPG Dosyaları (*.jpg)|*.jpg|PNG Dosyaları (*.png)|*.png";
        dosyaAc.FileName = string.Empty;
        dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        if (dosyaAc.ShowDialog() == DialogResult.OK)
        {
            _memoryStream = new MemoryStream();
            FileStream fileStream = File.Open(dosyaAc.FileName, FileMode.Open);
            while (fileStream.Read(_photosBytes, 0, _bufferSize) != 0)
            {
                _memoryStream.Write(_photosBytes, 0, _bufferSize);
            }
            fileStream.Close();
            fileStream.Dispose();

            pbAvatar.Image = new Bitmap(_memoryStream);
        }
    }


    private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        dosyaAc.Title = "Bir JSON dosyası seçiniz";
        dosyaAc.Filter = "(JSON Dosyası) | *.json";
        dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        dosyaAc.FileName = "Araclar.json";
        if (dosyaAc.ShowDialog() == DialogResult.OK)
        {
            FileStream dosya = File.OpenRead(dosyaAc.FileName);
            StreamReader reader = new StreamReader(dosya);
            string dosyaIcerigi = reader.ReadToEnd();
            _araclar = JsonConvert.DeserializeObject<List<Arac>>(dosyaIcerigi);
            lstAraclar.DataSource = null;
            lstAraclar.DataSource = _araclar;
        }
    }

    private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
    {

        dosyaKaydet.Title = "Bir JSON dosyası seçiniz";
        dosyaKaydet.Filter = "(JSON Dosyası) | *.json";
        dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        dosyaKaydet.FileName = "Araclar.json";
        if (dosyaKaydet.ShowDialog() == DialogResult.OK)
        {
            FileStream file = File.Open(dosyaKaydet.FileName, FileMode.Create);
            StreamWriter writer = new StreamWriter(file);
            writer.Write(JsonConvert.SerializeObject(_araclar));
            writer.Close();
            writer.Dispose();
        }
    }
}