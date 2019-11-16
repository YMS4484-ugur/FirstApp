using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MetroTile3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }
        Random rnd = new Random();
        private void Timer1_Tick(object sender, EventArgs e)
        {
            int index = rnd.Next(0, imageList1.Images.Count);
            pictureBox1.Image = imageList1.Images[index];
        }

        private void MetroScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
         
        }

        private void MetroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
          
        }
    }
}
