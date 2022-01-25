using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.IO;

namespace DMA16Glava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UriBuilder ubuild = new UriBuilder(@"http:\\rusproject.narod.ru:80");
            listBox1.Items.Add(ubuild.Host);
            listBox1.Items.Add(ubuild.Port.ToString());
            listBox1.Items.Add(ubuild.Scheme);
            listBox1.Items.Add(ubuild.Uri.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UriBuilder builder = new UriBuilder("http://rusproject.narod.ru/");
            builder.Path = "index.htm";
            builder.Fragment = "main";
            Uri myUri = builder.Uri;
            listBox1.Items.Add(builder.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Net.IPHostEntry host;
            host = System.Net.Dns.GetHostEntry("yandex.ru");
            foreach (System.Net.IPAddress ip in host.AddressList)
            {
                listBox1.Items.Add(ip.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Environment.MachineName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strIP = "";
            System.Net.IPHostEntry host;
            host = System.Net.Dns.GetHostEntry(strIP);
            foreach (System.Net.IPAddress ip in host.AddressList)
            {
                listBox1.Items.Add(ip.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ping pingSender = new Ping();
            PingReply reply = pingSender.Send("rusproject.narod.ru");
            if (reply.Status == IPStatus.Success)
            {
                listBox1.Items.Add("Address: " + reply.Address.ToString());
                listBox1.Items.Add("RoundTrip time: " + reply.RoundtripTime);
                listBox1.Items.Add("Time to live: " + reply.Options.Ttl);
                listBox1.Items.Add("Don't fragment: " + reply.Options.DontFragment);
                listBox1.Items.Add("Buffer size: " + reply.Buffer.Length);
            }
            else
            {
                listBox1.Items.Add(reply.Status);
            }
        }

        public static bool CheckUrl(string url)
        {
            bool rt = false;
            if (url.ToLower().StartsWith("www."))
            {
                url = "http://" + url;
            }
            HttpWebResponse myResponse = null;
            try
            {
                HttpWebRequest myRequest =
                (HttpWebRequest)WebRequest.Create(url);
                myResponse = (HttpWebResponse)myRequest.GetResponse();
                rt = true;
            }
            catch (WebException err)
            {
                rt = false;
            }
            finally
            {
                if (!(myResponse == null))
                {
                    myResponse.Close();
                }
            }
            return rt;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(CheckUrl(textBox1.Text).ToString());
        }

        // Функция Windows API
       
       
        
        private void button8_Click(object sender, EventArgs e)
        {
           

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string sURL;
            sURL = "http://netsources.narod.ru/";
            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);
            Stream objStream;
            objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);
            string sLine = "";
            int i = 0;
            while (sLine != null)
            {
                i++;
                sLine = objReader.ReadLine();
                if (sLine != null)
                    listBox1.Items.Add(string.Format("{0}:{1}", i, sLine));
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string remoteUri = "http://rusproject.narod.ru/image/";
            string fileName = "ruspro.gif", myStringWebResource = null;
            // Создаем экземпляр класса WebClient
            WebClient myWebClient = new WebClient();
            // Соединим имя домена с именем файла
            myStringWebResource = remoteUri + fileName;
            textBox1.Text = "Загружаем файл " + fileName +
            " из " + myStringWebResource + "\r\n";
            // Загрузим файл и сохраним его в локальной файловой системе
            myWebClient.DownloadFile(myStringWebResource, "C:\\Users\\student\\Downloads" + fileName);
            listBox1.Items.Add ("Файл " + fileName + " из " + myStringWebResource +
            " успешно загружен" + "\r\n");
            listBox1.Items.Add("Загруженный файл сохранен на диске C:");
        }


        // Закачка файла на FTP-сервер
        private void FTPUploadFile(string filename)
        {
            FileInfo fileInfo = new FileInfo(filename);
            string uri = "ftp://" + "ftp.narod.ru" + "/" + fileInfo.Name;

            FtpWebRequest reqFTP;
            // Создаем объект FtpWebRequest, используя заданный адрес
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(
 new Uri("ftp://" + "ftp.narod.ru" + "/" + fileInfo.Name));
            // Используем учетную запись для доступа
            // Используйте реальные данные
            // В этом примере используются вымышленные данные
            reqFTP.Credentials = new NetworkCredential("csharp", "narod");
            // По умолчанию свойство KeepAlive равно true,
            // если соединение не обрывается после выполнения команды
            reqFTP.KeepAlive = false;
            // Задаем нужную команду.
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
            // Указываем тип данных при передаче файлов
            reqFTP.UseBinary = true;
            // Сообщаем серверу о размере закачиваемого файла
            reqFTP.ContentLength = fileInfo.Length;
            // Устанавливаем размер буфера в 2 Кбайт
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;
            // Открываем файловый поток (System.IO.FileStream) для чтения
            FileStream fs = fileInfo.OpenRead();
            try
            {
                // Поток, в который записывается закачиваемый на сервер файл
                Stream strm = reqFTP.GetRequestStream();
                // Читаем из файлового потока по 2 Kбайт за раз
                contentLen = fs.Read(buff, 0, buffLength);
                // Пока файл не закончился
                while (contentLen != 0)
                {
                    // Запишем прочитанное в поток закачки
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }
                // Закрываем файловый поток и поток запроса
                strm.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при закачке файла");
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            FTPUploadFile(@"C:\Users\student\Downloads\ruspro.gif");
        }

        public string[] GetFileList()
        {
            string[] downloadFiles;
            StringBuilder result = new StringBuilder();
            FtpWebRequest reqFTP;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(
                new Uri("ftp://" + "ftp.narod.ru" + "/"));
                reqFTP.UseBinary = true;
                // Используйте реальные данные пользователя
                reqFTP.Credentials = new NetworkCredential("csharp", "narod");
                // Задаем команду получения списка файлов
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                WebResponse response = reqFTP.GetResponse();
                StreamReader reader =
                new StreamReader(response.GetResponseStream());
                string line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();
                }
                // Удаляем завершающие символы '\n'
                result.Remove(result.ToString().LastIndexOf('\n'), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\n');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                downloadFiles = null;
                return downloadFiles;
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            // Выводим список файлов
            string[] allFiles = GetFileList();
            foreach (string file in allFiles)
            {
                listBox1.Items.Add(file);
            }
        }
    }
}
