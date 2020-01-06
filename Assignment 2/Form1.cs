using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
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

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            double ResistorSeries1 = double.Parse(textBox1.Text);
            double ResistorSeries2 = double.Parse(textBox2.Text);
            double ResistorParallel1 = double.Parse(textBox3.Text);
            double ResistorParallel2 = double.Parse(textBox4.Text);
            double ResistorSeries3 = double.Parse(textBox6.Text);
            double ResistorSeries4 = double.Parse(textBox7.Text);
            double ResistorSeries5 = double.Parse(textBox8.Text);
            double ResistorParallel3 = double.Parse(textBox5.Text);
            double ResistorParallel4 = double.Parse(textBox9.Text);
            double ResistorParallel5 = double.Parse(textBox10.Text);

        }
    }
}
