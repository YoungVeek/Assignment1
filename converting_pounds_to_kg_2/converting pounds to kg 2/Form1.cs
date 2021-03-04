using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace converting_pounds_to_kg_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Pound = (double)numericUpDown1.Value;
            double Answer = Pound * 0.453592;
            label3.Text = Answer.ToString() + "kg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double kilogram = (double)numericUpDown2.Value;
            double Answer2 = kilogram * 2.20462;
            label3.Text = Answer2.ToString() + "lbs";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            label3.Text = "Answer";
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
