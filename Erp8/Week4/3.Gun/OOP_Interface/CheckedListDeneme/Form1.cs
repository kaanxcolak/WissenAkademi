using System.Windows.Forms;

namespace CheckedListDeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.CheckOnClick = true;
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {

                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (i == e.Index) continue;
                    else
                    {
                        checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }

            }

        }


    }
}