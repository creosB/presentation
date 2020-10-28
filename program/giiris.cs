using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biyoloji_perf
{
    public partial class giiris : Form
    {
        public giiris()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (kadı.Text == "baris" && sifre.Text == "biyoloji")
            {
                Form1 yeni = new Form1();
                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tekrar deneyiniz");
            }
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
