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
    public partial class Form1 : Form
    {
        protected Process[] procs;
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            string appPath = Application.ExecutablePath;

            MessageBox.Show(appPath);
        }

        private void buttonBase_Click(object sender, EventArgs e)
        {
            // Выводим путь к папке, откуда запущено приложение
            MessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory);
            // Другой способ
            MessageBox.Show(Application.StartupPath);
        }

     

        private void butCloseNotepad_Click(object sender, EventArgs e)
        {
         
        }

        private void btnexe_Click(object sender, EventArgs e)
        {
            // создаем новый процесс
            Process proc = new Process();
            // Запускаем Блокнот
            proc.StartInfo.FileName = @"Notepad.exe";
            proc.StartInfo.Arguments = "";
            proc.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe", "netsources.narod.ru");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Устанавливаем информацию
            ProcessStartInfo start_info = new ProcessStartInfo
            (@"C:\windows\system32\notepad.exe");
            start_info.UseShellExecute = false;
            start_info.CreateNoWindow = true;
            // создаем новый процесс
            Process proc = new Process();
 proc.StartInfo = start_info;
            // Запускаем процесс
            proc.Start();
            // Ждем, пока Блокнот запущен
            proc.WaitForExit();
            MessageBox.Show("Код завершения: " + proc.ExitCode, "Завершение " +
            "Код", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            procs = Process.GetProcessesByName("Notepad");
            int i = 0;
            while (i != procs.Length)
            {
                procs[i].Kill();
                i++;
                MessageBox.Show("Всего : " + i.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Получим путь к нужной папке
            string sysFolder = 
            Environment.GetFolderPath(Environment.SpecialFolder.System);
            // Создадим новую структуру ProcessStartInfo
            ProcessStartInfo pInfo = new ProcessStartInfo();
            // Установим полный путь к имени файла
            pInfo.FileName = sysFolder + @"\лаб 6.docx";
 // По умолчанию UseShellExecute равно true.
 // В данном случае указываем это поле явно для иллюстрации.
            pInfo.UseShellExecute = true;
            Process p = Process.Start(pInfo);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int am = Process.GetCurrentProcess().ProcessorAffinity.ToInt32();
            int processorCount = 0;
            while (am != 0)
            {
                processorCount++;
                am &= (am - 1);
            }
            MessageBox.Show(processorCount.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
 String.Format(
 "Число процессоров: {0}",
 Environment.ProcessorCount.ToString()));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Делаем паузу на 3 секунды
            System.Threading.Thread.Sleep(3000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }
    }

}
