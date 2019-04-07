using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         int sayi, taban, mod;

        private void button1_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(textBox1.Text);
            taban = Convert.ToInt32(textBox2.Text);
            
            while (sayi > taban - 1)
            {
                mod = sayi % taban;
                sayi = sayi / taban;
                label1.Text = mod.ToString();
            }

            label1.Text = sayi.ToString() + label1.Text;
        }
    }
}
