using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tahac tahac;
        NakladniAuto auto;
        private void button1_Click(object sender, EventArgs e)
        {
            auto = new NakladniAuto("6J2 4685", 4);
            tahac = new Tahac("", 4, 6);
            MessageBox.Show("Založení " + tahac.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tahac.NalozNaklad(Convert.ToInt32(textBox1.Text));
        }
    }
}
