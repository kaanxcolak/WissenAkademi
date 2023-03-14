namespace HesapMakinesiWinForm
{
    public partial class Form1 : Form
    {
        double firstNumber;
        string operation;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void BtnEsittir_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double result;
            secondNumber = Convert.ToDouble(txtGiris.Text);
            if (operation == "+")
            {
                result = (firstNumber + secondNumber);
                txtGiris.Text = Convert.ToString(result);
            }
            else if (operation == "-")
            {
                result = (firstNumber - secondNumber);
                txtGiris.Text = Convert.ToString(result);
            }
            else if (operation == "*")
            {
                result = (firstNumber * secondNumber);
                txtGiris.Text = Convert.ToString(result);
            }
            else if (operation == "/")
            {
                if (secondNumber == 0)
                    txtGiris.Text = "Uygulanamaz";
                else
                {
                    result = (firstNumber / secondNumber);
                    txtGiris.Text = Convert.ToString(result);
                }
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtGiris.Text == "0" && txtGiris.Text == null)
                txtGiris.Text = "0";
            else
                txtGiris.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtGiris.Text == "0" && txtGiris.Text == null)
                txtGiris.Text = "0";
            else
                txtGiris.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtGiris.Text == "0" && txtGiris.Text == null)
                txtGiris.Text = "2";
            else
                txtGiris.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtGiris.Text == "0" && txtGiris.Text == null)
                txtGiris.Text = "3";
            else
                txtGiris.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtGiris.Text == "0" && txtGiris.Text == null)
                txtGiris.Text = "4";
            else
                txtGiris.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtGiris.Text == "0" && txtGiris.Text == null)
                txtGiris.Text = "5";
            else
                txtGiris.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtGiris.Text == "0" && txtGiris.Text == null)
                txtGiris.Text = "6";
            else
                txtGiris.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtGiris.Text == "0" && txtGiris.Text == null)
                txtGiris.Text = "7";
            else
                txtGiris.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtGiris.Text == "0" && txtGiris.Text == null)
                txtGiris.Text = "8";
            else
                txtGiris.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtGiris.Text == "0" && txtGiris.Text == null)
                txtGiris.Text = "9";
            else
                txtGiris.Text += "9";
        }

        private void btnNokta_Click(object sender, EventArgs e)
        {
            txtGiris.Text += ",";
        }

        private void btnToplam_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtGiris.Text);
            txtGiris.Text = null;
            operation = "+";
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtGiris.Text);
            txtGiris.Text = null;
            operation = "-";
        }

        private void btnCarpim_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtGiris.Text);
            txtGiris.Text = null;
            operation = "*";
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtGiris.Text);
            txtGiris.Text = null;
            operation = "/";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtGiris.Text = null;
        }
    }
}