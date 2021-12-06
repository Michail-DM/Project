using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMA_BMI_calculator
{
    public partial class Form2 : Form
    {
        float g;
        float vs;
        float ro;
        float age;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = 66;
            vs = 13.7f;
            ro = 5;
            age = 6.8f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g = 655;
            vs = 9.6f;
            ro = 1.8f;
            age = 4.7f;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rostBox.Clear();
            vesBox.Clear();
            ageBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float ves = float.Parse(vesBox.Text);
            float rost = float.Parse(rostBox.Text);
            float ag = float.Parse(ageBox.Text);
            float f = g + (vs * ves) + (ro * rost) + (age * ag);
            label5.Text = f.ToString();

            label12.Text = f.ToString();
            label13.Text = f.ToString();
            label14.Text = f.ToString();
            label15.Text = f.ToString();
            label16.Text = f.ToString();
        }
    }
}
