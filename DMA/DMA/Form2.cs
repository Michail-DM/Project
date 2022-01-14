using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DMA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Process p in Process.GetProcesses())
            listBox1.Items.Add(p.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string fileName = @"c:\windows\regedit.exe";
            // Получим информацию о свойствах файла.
            FileVersionInfo fileInfo = FileVersionInfo.GetVersionInfo(fileName);
            listBox1.Items.Add("Комментарии: " + fileInfo.Comments);
            listBox1.Items.Add("Производитель: " + fileInfo.CompanyName);
            listBox1.Items.Add("Имя файла: " + fileInfo.FileName);
            listBox1.Items.Add("Номер сборки файла: " + fileInfo.FileBuildPart);
            listBox1.Items.Add("Описание файла: " + fileInfo.FileDescription);
            listBox1.Items.Add("Номер версии файла: " + fileInfo.FileVersion);
            listBox1.Items.Add("Основная часть номера версии: " +
            fileInfo.FileMajorPart);
            listBox1.Items.Add("Вспомогательная часть номера версии: " +
            fileInfo.FileMinorPart);
            listBox1.Items.Add("Номер закрытой части файла: " +
            fileInfo.FilePrivatePart);
            listBox1.Items.Add("Авторские права: " + fileInfo.LegalCopyright);
            listBox1.Items.Add("Товарные знаки: " + fileInfo.LegalTrademarks);
            listBox1.Items.Add("Название продукта: " + fileInfo.ProductName);
            listBox1.Items.Add("Имя пользователя: " + SystemInformation.UserName);
        }
    }
}
