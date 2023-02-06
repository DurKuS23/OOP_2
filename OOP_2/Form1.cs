using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Ryba ryba = new Ryba("Kapr");
            listBox1.Items.Add(ryba.GetType().Name + " " + ryba.Druh + " " + ryba.UdelejZvuk());

            Ptak ptak = new Ptak("Kos");
            listBox1.Items.Add(ptak.GetType().Name + " " + ptak.Druh + " " + ptak.UdelejZvuk());

            ZpevnyPtak zpevnyptak = new ZpevnyPtak("Skřivan");
            listBox1.Items.Add(zpevnyptak.GetType().Name + " " + zpevnyptak.Druh + " " + zpevnyptak.UdelejZvuk());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Zvire[] zvirata = new Zvire[3];
            zvirata[0] = new Ryba("Kapr");
            zvirata[1] = new Ptak("Kos");
            zvirata[2] = new ZpevnyPtak("Skřivan");

            foreach (Zvire zvire in zvirata)
            {
                listBox1.Items.Add(zvire.GetType().Name + " " + zvire.Druh + " " + zvire.UdelejZvuk());
            }
        }
    }
}
