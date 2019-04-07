using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UInt64 TcNo, bol, kontrol1, kontrol2;
        UInt64[] basamak = new UInt64[12];

        private void button1_Click(object sender, EventArgs e)
        {
            bol = 1;
            TcNo = Convert.ToUInt64(textBox1.Text);

            if (textBox1.Text.Length == 11)
            {
                for (int i = 11; i >= 1; i--)
                {
                    basamak[i] = (TcNo / bol) % 10;
                    listBox1.Items.Add(basamak[i]);
                    bol = bol * 10;
                }

                kontrol1 = (basamak[1] + basamak[3] + basamak[5] + basamak[7] + basamak[9]) * 7 - (basamak[2] + basamak[4] + basamak[6] + basamak[8]);
                kontrol1 = kontrol1 % 10;

                kontrol2 = basamak[1] + basamak[2] + basamak[3] + basamak[4] + basamak[5] + basamak[6] + basamak[7] + basamak[8] + basamak[9] + basamak[10];
                kontrol2 = kontrol2 % 10;
              
                if (kontrol1 == basamak[10] && kontrol2 == basamak[11])
                {
                    label1.Text = "Doğru Tc Kimlik Numarası Girildi.";
                }
                else
                {
                    label1.Text = "Yanlış Tc Kimlik Numarası Girildi.";
                }
            }

            else
            {
                label1.Text = "Eksik Haneli Tc Kimlik Numarası Girdiniz.";
            }
        }
    }
}
