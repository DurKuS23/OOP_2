using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Retez veta;
        private void button1_Click(object sender, EventArgs e)
        {
       
            MessageBox.Show(veta.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           veta.Zkrat(Convert.ToInt32(textBox2.Text));
           MessageBox.Show(veta.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            veta.PocetSlov(out int pocetslov);
            MessageBox.Show("Počet slov v řetězci " + pocetslov);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RetezDalsi veta2 = new RetezDalsi(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            veta2.Zkrat(Convert.ToInt32(textBox3.Text));
            MessageBox.Show(veta2.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            veta = new Retez(textBox1.Text, Convert.ToInt32(textBox2.Text));
        }
    }
}
