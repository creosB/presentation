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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(ikinciUC1);
            bunifuTransition1.ShowSync(ilkUC1);

            bunifuCircleProgressbar1.Value = 25;

            System.Diagnostics.Process.Start("biyoloji.pptx");
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(ilkUC1);
            bunifuTransition1.ShowSync(ikinciUC1);

            bunifuCircleProgressbar1.Value = 50;

            System.Diagnostics.Process.Start("video.wmv");
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(ikinciUC1);
            bunifuTransition1.ShowSync(ilkUC1);

            bunifuCircleProgressbar1.Value = 75;

            System.Diagnostics.Process.Start("qwe.exe");
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(ilkUC1);
            bunifuTransition1.ShowSync(ikinciUC1);

            bunifuCircleProgressbar1.Value = 100;

            Form2 yeni = new Form2();
            yeni.Show();
        }
    }
}
