using System;
using System.Windows.Forms;

namespace WindowsFormsApplication73
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            var timeout = TimeSpan.FromSeconds(3);
            var result = form2.ShowWithTimeout(timeout);
            MessageBox.Show(result.ToString());
        }
    }
}