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
    public partial class Form1 : Form
    {
        float index;
        float r;
        float v;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            r = float.Parse(rostbox.Text);
            v = float.Parse(vesbox.Text);
            r = r / 100;
            index = v / (r * r);
            gg.Text = index.ToString();
            trackBar1.Value = (int)index;
            if (index < 18.5)
            {
                pictureBox3.Image = Image.FromFile(@"C:\Users\student\source\repos\DMA_BMI_calculator\DMA_BMI_calculator\Resources\bmi-underweight-icon.png");
            }
            else if (index < 25)
            {
                pictureBox3.Image = Image.FromFile(@"C:\Users\student\source\repos\DMA_BMI_calculator\DMA_BMI_calculator\Resources\bmi-healthy-icon.png");
            }
            else if(index < 29.9)
            {
                pictureBox3.Image = Image.FromFile(@"C:\Users\student\source\repos\DMA_BMI_calculator\DMA_BMI_calculator\Resources\bmi-overweight-icon.png");
            }
             else if (index > 30)
            {
                pictureBox3.Image = Image.FromFile(@"C:\Users\student\source\repos\DMA_BMI_calculator\DMA_BMI_calculator\Resources\bmi-obese-icon.png");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rostbox.Clear();
            vesbox.Clear();
        }
    }
}
