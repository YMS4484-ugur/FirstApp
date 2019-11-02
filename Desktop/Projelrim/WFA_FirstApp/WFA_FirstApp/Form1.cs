using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPasword.Text;






            MessageBox.Show("kullanıcı adınız:" + username + "şifreniz:" + password);
        }
    }
}
