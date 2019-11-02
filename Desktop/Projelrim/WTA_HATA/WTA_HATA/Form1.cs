using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTA_HATA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOrnek1_Click(object sender, EventArgs e)
        {
            int TransactionNo = Convert.ToInt32(textBox1.Text);
            MessageBox.Show("Kayıt İşlemi Başarılı");
        }

        private void BtnOrnek2_Click(object sender, EventArgs e)
        {
            try {
                int TransactionNo = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Kayıt İşlemi Başarılı");

            }
            catch {
                MessageBox.Show("işlem hatası");

            }
        }

        private void BtnOrnek3_Click(object sender, EventArgs e)
        {
            try
            {
                int TransactionNo = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Kayıt İşlemi Başarılı");

            }
            catch (Exception ex)
            {
                MessageBox.Show("işlem hatası");
                MessageBox.Show(ex.Message);
                // throw new Exception("Kullanıcı Transaction Numarasını giremedi");
            }
        }

        private void BtnOrnek4_Click(object sender, EventArgs e)
        {
            try
            {
                int TransactionNo = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Kayıt İşlemi Başarılı");

            }
            catch (DivideByZeroException ex)
            {
            }
            catch (FormatException ex)
            {
            }

            catch (Exception ex)
            {
                MessageBox.Show("işlem hatası");
                MessageBox.Show(ex.Message);

            }
        }

        private void BtnOrnek5_Click(object sender, EventArgs e)
        {
            try
            {
                int TransactionNo = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Kayıt İşlemi Başarılı");

            }
            catch
            {
                MessageBox.Show("işlem hatası");

            }

            finally
            {
                MessageBox.Show("her işlem sonrası mutlaka çalışırım");
            }
        }

    }
}

