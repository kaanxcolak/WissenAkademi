using CafeSoft.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSoft.Forms
{
    public partial class KategorilerForm : Form
    {
        public KategorilerForm()
        {
            InitializeComponent();
        }
        public EnvanterContext DataContext { get; set; }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}
