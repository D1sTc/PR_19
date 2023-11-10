using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_19
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // кто разработал
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Youtube аккаунт
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // label5.Click = true;
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC4IXco8nc4u-DMYnTrLIysQ/");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // специальность
        }
    }
}
