using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi, s;

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            s = rnd.Next(101);
            sayi = 100;
            label2.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi = sayi + (sayi / 2);
            label2.Text = sayi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi = sayi - (sayi / 2);
            label2.Text = sayi.ToString();
        }
    }
}
