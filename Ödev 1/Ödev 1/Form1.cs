using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;

            }
            else
            {
                timer1.Enabled = true;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Left == 500)
            {
                button1.Location = new Point(-100, 203);

            }

            button1.Location = new Point(button1.Location.X + 2, 203);
        }
    }
}
