using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace DMA14Glava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FillListBox()
        {
            string culture = cboCulture.SelectedItem.ToString();
            CultureInfo ci = new CultureInfo(culture);
            DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
            dtfi = ci.DateTimeFormat;

            DateTime dt;
            lstMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                dt = new DateTime(1900, i, 1);
                lstMonth.Items.Add(dt.ToString("MMMM", ci));
            }
            lstWeek.Items.Clear();
            for (DayOfWeek i = DayOfWeek.Sunday; i <= DayOfWeek.Saturday; i++)
            {
                lstWeek.Items.Add(dtfi.GetDayName(i));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cboCulture.Items.Add("ru-RU");
            cboCulture.Items.Add("en-US");
            cboCulture.Items.Add("de-DE");
            cboCulture.Items.Add("fr-FR");
            cboCulture.Items.Add("uk-UA");
            cboCulture.Items.Add("fi-FI");
            cboCulture.SelectedIndex = 0;
        }

        private void cboCulture_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillListBox();
        }
    }
}
