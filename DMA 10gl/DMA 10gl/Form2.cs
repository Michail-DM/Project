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
namespace DMA_10gl
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] astrFiles = System.IO.Directory.GetFiles(@"c:\");
            listBox1.Items.Add("Всего файлов: " + astrFiles.Length);
            foreach (string file in astrFiles)
                listBox1.Items.Add(file);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] directoryEntries =
System.IO.Directory.GetFileSystemEntries(@"c:\windows");
            foreach (string str in directoryEntries)
            {
                listBox1.Items.Add(str);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] astrFiles = System.IO.Directory.GetFiles(@"c:\", "*.tx?");
            listBox1.Items.Add("Всего файлов: " + astrFiles.Length);
            foreach (string file in astrFiles)
                listBox1.Items.Add(file);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Application.StartupPath + "\\test.txt"))
                label1.Text = "Файл test.txt существует";
            else
                label1.Text = "Файл test.txt не существует";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Полный путь к файлу
            string fileNamePath = @"c:\windows\system32\notepad.exe";
            // Имя файла с расширением
            listBox1.Items.Add(System.IO.Path.GetFileName(fileNamePath));
            // Имя файла без расширения
            listBox1.Items.Add(
            System.IO.Path.GetFileNameWithoutExtension(fileNamePath));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Полный путь к файлу
            string fileNamePath = @"c:\windows\system32\notepad.exe";
            // Получим расширение файла
            listBox1.Items.Add(System.IO.Path.GetExtension(fileNamePath));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // путь к тестовому файлу
            string path = @"c:\NewFolder\test.txt";
            // если файлы имел атрибут Скрытый
            if ((System.IO.File.GetAttributes(path) &
            System.IO.FileAttributes.Hidden)
            == System.IO.FileAttributes.Hidden)
            {
                // то устанавливаем атрибут Normal
                System.IO.File.SetAttributes(path,
                System.IO.FileAttributes.Normal);
                MessageBox.Show("Файл больше не является скрытым", path);
            }
            else // если файл не был скрытым
            {
                // то устанавливаем у файла атрибут Скрытый
                System.IO.File.SetAttributes(path,
                System.IO.File.GetAttributes(path) |
                System.IO.FileAttributes.Hidden);
                MessageBox.Show("Файл стал скрытым", path);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Выводим информацию о файле.
            System.IO.FileInfo file = new
            System.IO.FileInfo(@"c:\NewFolder\text.txt");
            listBox1.Items.Clear();
            listBox1.Items.Add("Свойства для файла: " + file.Name);
            listBox1.Items.Add("Наличие файла: " + file.Exists.ToString());
            if (file.Exists)
            {
                listBox1.Items.Add("Время создания файла: ");
                listBox1.Items.Add(file.CreationTime.ToString());
                listBox1.Items.Add("Последнее изменение файла: ");
                listBox1.Items.Add(file.LastWriteTime.ToString());
                listBox1.Items.Add("Файл был открыт в последний раз: ");
                listBox1.Items.Add(file.LastAccessTime.ToString());
                listBox1.Items.Add("Размер файла (в байтах): ");
                listBox1.Items.Add(file.Length.ToString());
                listBox1.Items.Add("Атрибуты файла: ");
                listBox1.Items.Add(file.Attributes.ToString());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.FileVersionInfo info =
System.Diagnostics.FileVersionInfo.GetVersionInfo(
@"C:\windows\system32\mspaint.exe");
            // Выводим информацию о выбранном файле
            listBox1.Items.Add("Выбранный файл: " + info.FileName);
            listBox1.Items.Add("Product Name: " + info.ProductName);
            listBox1.Items.Add("Product Version: " + info.ProductVersion);
            listBox1.Items.Add("Company Name: " + info.CompanyName);
            listBox1.Items.Add("File Version: " + info.FileVersion);
            listBox1.Items.Add("File Description: " + info.FileDescription);
            listBox1.Items.Add("Original Filename: " + info.OriginalFilename);
            listBox1.Items.Add("Legal Copyright: " + info.LegalCopyright);
            listBox1.Items.Add("InternalName: " + info.InternalName);
            listBox1.Items.Add("IsDebug: " + info.IsDebug);
            listBox1.Items.Add("IsPatched: " + info.IsPatched);
            listBox1.Items.Add("IsPreRelease: " + info.IsPreRelease);
            listBox1.Items.Add("IsPrivateBuild: " + info.IsPrivateBuild);
            listBox1.Items.Add("IsSpecialBuild: " + info.IsSpecialBuild);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // Создаем временный файл
            listBox1.Items.Add(System.IO.Path.GetTempFileName());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string randomFile = System.IO.Path.GetRandomFileName();
            MessageBox.Show(randomFile); // вернет что-то типа 5wvzx2n0.lby
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string tempText = System.IO.Path.ChangeExtension(
System.IO.Path.GetRandomFileName(), ".txt");
            MessageBox.Show(tempText);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string fileName = @"c:\NewFolder\test.txt";
            FileStream stream = new FileStream(fileName,
            FileMode.Open, FileAccess.Read, FileShare.None);
            //никому не даем доступ к файлу
            // здесь находится ваш код
            
// открываем снова файл для доступа
stream.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string fileName = @"c:\NewFolder\test.txt";
            // Создадим новый пустой файл
            if (System.IO.File.Exists(fileName))
            {
                MessageBox.Show("Указанный файл уже существует!", fileName);
                return;
            }
            System.IO.FileStream fs = new System.IO.FileStream(fileName,
            System.IO.FileMode.CreateNew);
            // Запишем данные в файл
            System.IO.BinaryWriter w = new System.IO.BinaryWriter(fs);
            for (int i = 0; i < 11; i++)
            {
                w.Write((int)i);
            }
            w.Close();
            fs.Close();
            // Попытаемся прочитать записанное
            fs = new System.IO.FileStream(fileName, System.IO.FileMode.Open,
            System.IO.FileAccess.Read);
            System.IO.BinaryReader binread = new System.IO.BinaryReader(fs);
            // считываем данные из test.bin
            for (int i = 0; i < 11; i++)
            {
                MessageBox.Show(binread.ReadInt32().ToString());
            }
            w.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string fileName = @"c:\NewFolder\test1.txt";
            if (System.IO.File.Exists(fileName))
            {
                MessageBox.Show("Указанный файл уже существует.", fileName);
                return;
            }
            System.IO.StreamWriter sr = System.IO.File.CreateText(fileName);
            sr.WriteLine("Раз, два, три, четыре, пять");
            sr.WriteLine("1, 2, 3. 9 1/2 и так далее");
            sr.WriteLine("Я изучаю {0} и {1}.", "C#", "Visual Basic");
            sr.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string fileName = @"c:\NewFolder\test.txt";
            // Добавляем одну строчку в текстовый файл
            using (System.IO.StreamWriter sw =
            System.IO.File.AppendText(fileName))
            {
                sw.WriteLine("Добавили еще одну строчку");
            }
            // Прочитаем текст из файла
            using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    MessageBox.Show(s);
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Создадим экземпляр StreamReader для чтения из файла
            using (System.IO.StreamReader sr =
            new System.IO.StreamReader(@"c:\NewFolder\test.txt"))
            {
                String line;
                // Читаем каждую строку, пока не достигнем конца файла
                while ((line = sr.ReadLine()) != null)
                {
                    MessageBox.Show(line);
                }
            }
        }
    }
}
