namespace AkbilYonetimiUI
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            //Bu formu gizleyeceğiz
            //Kayıt Ol formunu açacağız 
            this.Hide();
            FrmKayitOl frm = new FrmKayitOl();
            frm.Show();

        }
    }
}