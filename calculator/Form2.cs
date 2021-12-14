using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form2 : Form
    {
        float g;
        float vs;
        float ro;
        float age;
        float p1;
        float p2;
        float p3;
        float p4;
        float p5;
        
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
            float p1 = f*1.2f;
            float p2 = f * 1.375f;
            float p3 = f * 1.55f;
            float p4 = f * 1.725f;
            float p5 = f * 1.9f;
            
            label12.Text = p1.ToString("##.##");
            label13.Text = p2.ToString("##.##");
            label14.Text = p3.ToString("##.##");
            label15.Text = p4.ToString("##.##");
            label16.Text = p5.ToString("##.##");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible=true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
