using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DMA11Glava
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            this.Text = WMP.versionInfo;
            WMP.URL =
            @"C:\Users\student\Downloads\bon-jovi-livin-on-a-prayer.mp3";
            WMP.controls.play();

        }

    }
}
