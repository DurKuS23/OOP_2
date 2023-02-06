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
        NakladniAuto auto;
      
        
        private void button1_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("Založení : " + auto.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            auto.NalozNaklad(Convert.ToInt32(textBox1.Text));
            MessageBox.Show(auto.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             auto = new NakladniAuto("6J5 4876", 8);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
             auto = new Tahac("6J2 2223", 4, 6);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            auto = new NakladniAuto("6J5 4876", 8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            auto.VylozNaklad(Convert.ToInt32(textBox2.Text));
            MessageBox.Show(auto.ToString());
        }
    }
}
