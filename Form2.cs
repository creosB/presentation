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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.Top = Screen.PrimaryScreen.Bounds.Height - this.Height - 100;
            this.Left = Screen.PrimaryScreen.Bounds.Height - this.Width - 100;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
