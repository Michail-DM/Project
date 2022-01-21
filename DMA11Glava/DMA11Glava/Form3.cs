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

    public partial class Form3 : Form
    {
        
        public Form3()
        {

            InitializeComponent();
            
        }

        struct MP3
        {
            public string filePath;
            public string fileName;
            public string fileComplete;
            public bool hasID3Tag;
            public string id3Title;
            public string id3Artist;
            public string id3Album;
            public string id3Year;
            public string id3Comment;
            public byte id3TrackNumber;
            public byte id3Genre;
            public MP3(string path, string name)
            {
                this.filePath = path;
                this.fileName = name;
                this.fileComplete = path + "\\" + name;
                this.hasID3Tag = false;
                this.id3Title = null;
                this.id3Artist = null;
                this.id3Album = null;
                this.id3Year = null;
                this.id3Comment = null;
                this.id3TrackNumber = 0;
                this.id3Genre = 0;
            }
        }
        private void butLoadMP3_Click(object sender, EventArgs e)
        {
            // Загружаем MP3-файл
            LoadMp3();
        }
        private void LoadMp3()
        {
            // Выбираем файл MP3
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "файлы MP3 (*.mp3)|*.mp3";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.Cancel) return;
            string fileName = fileDialog.FileName;
            FileInfo fFileInfo = new FileInfo(fileName);
            mp3file = new MP3(fFileInfo.DirectoryName, fFileInfo.Name);
            MP3Tag.ReadMP3Tag(ref mp3file);
            // Выводим полученную информацию на экран
            txtTitle.Text = mp3file.id3Title;
            txtArtist.Text = mp3file.id3Artist;
            txtAlbum.Text = mp3file.id3Album;
            txtYear.Text = mp3file.id3Year;
            txtComment.Text = mp3file.id3Comment;
            txtGenre.Text = mp3file.id3Genre.ToString();
            cboGenres.SelectedIndex = mp3file.id3Genre;
        }
        class MP3Tag
        {
            public enum genres : byte
            {
                Blues,
                ClassicRock,
                Country,
                Dance,
                Disco,
                Funk,
                Grunge,
                HipHop,
                Jazz,
                Metal,
                NewAge,
                Oldies,
                Other,
                Pop,
                RnB,
                Rap,
                Reggae,
                Rock,
                Techno,
                Industrial,
                Alternative,
                Ska,
                DeathMetal,
                Pranks,
                Soundtrack,
                EuroTechno,
                Ambient,
                TripHop,
                Vocal,
                JazzFunk,
                Fusion,
                Trance,
                Classical,
                Instrumental,
                Acid,
                House,
                Game,
                SoundClip,
                Gospel,
                Noise,
                AlternRock,
                Bass,
                Soul,
                Punk,
                Space,
                Mediative,
                InstrumentalPop,
                InstrumentalRock,
                Ethnic,
                Gothic,
                Darkwave,
                TechnoIndustrial,
                Electronic,
                PopFolk,
                Eurodance,
                Dream,
                SouthernRock,
                Comedy,
                Cult,
                Gangsta,
                Top40,
                ChristianRap,
                PopFunk,
                Jungle,
                NativeAmerican,
                Cabaret,
                NewWave,
                Psychadelic,
                Rave,
                Showtunes,
                Trailer,
                LoFi,
                Tribal,
                AcidPunk,
                AcidJazz,
                Polka,
                Retro,
                Musical,
                RocknRoll,
                HardRock,
                None = 255
            };
            public static void ReadMP3Tag(ref MP3 paramMP3)
            {
                // Считываем последние 128 байт (теги ID3) в байтовый массив
                FileStream fs;
                fs = new FileStream(paramMP3.fileComplete, FileMode.Open);
                byte[] bBuffer = new byte[128];
                fs.Seek(-128, SeekOrigin.End);
                fs.Read(bBuffer, 0, 128);
                fs.Close();
                // Конвертируем массив байтов в строки
                //Encoding instEncoding = new ASCIIEncoding();
                Encoding encoding = Encoding.GetEncoding(1251);

                string id3Tag = encoding.GetString(bBuffer);
                // Если имеется строка TAG, тогда начинаем
                // извлекать информацию
                if (id3Tag.Substring(0, 3) == "TAG")
                {
                    // название песни
                    paramMP3.id3Title = id3Tag.Substring(3, 30).Trim();
                    // исполнитель
                    paramMP3.id3Artist = id3Tag.Substring(33, 30).Trim();
                    // название альбома
                    paramMP3.id3Album = id3Tag.Substring(63, 30).Trim();
                    // год выпуска
                    paramMP3.id3Year = id3Tag.Substring(93, 4).Trim();
                    // комментарий
                    paramMP3.id3Comment = id3Tag.Substring(97, 28).Trim();
                    // Получим номер трека, если используется ID3 v1.1
                    // Сравниваем предоследний байт на равенство нулю
                    if (id3Tag[125] == 0)
                        paramMP3.id3TrackNumber = bBuffer[126];
                    else
                        paramMP3.id3TrackNumber = 0;
                    paramMP3.id3Genre = bBuffer[127];
                    paramMP3.hasID3Tag = true;
                }
                else
                {
                    // Если теги ID3 не найдены, то создаем пустые данные,
                    // чтобы потом пользователь мог записать свои данные
                    paramMP3.id3Title = "";
                    paramMP3.id3Artist = "";
                    paramMP3.id3Album = "";
                    paramMP3.id3Year = "";
                    paramMP3.id3Comment = "";
                    paramMP3.id3TrackNumber = 0;
                    paramMP3.id3Genre = 0;
                    paramMP3.hasID3Tag = false;
                }
            }
            public static void SaveMP3Tag(ref MP3 paramMP3)
            {
                // Удаляем любые пробелы
                paramMP3.id3Title = paramMP3.id3Title.Trim();
                paramMP3.id3Artist = paramMP3.id3Artist.Trim();
                paramMP3.id3Album = paramMP3.id3Album.Trim();
                paramMP3.id3Year = paramMP3.id3Year.Trim();
                paramMP3.id3Comment = paramMP3.id3Comment.Trim();
                // Не позволяем выходить строке за допустимые пределы длины
                if (paramMP3.id3Title.Length > 30)
                    paramMP3.id3Title = paramMP3.id3Title.Substring(0, 30);
                if (paramMP3.id3Artist.Length > 30)
                    paramMP3.id3Artist = paramMP3.id3Artist.Substring(0, 30);
                if (paramMP3.id3Album.Length > 30)
                    paramMP3.id3Album = paramMP3.id3Album.Substring(0, 30);
                if (paramMP3.id3Year.Length > 4)
                    paramMP3.id3Year = paramMP3.id3Year.Substring(0, 4);
                if (paramMP3.id3Comment.Length > 28)
                    paramMP3.id3Comment =
                    paramMP3.id3Comment.Substring(0, 28);
                // Создаем новый тег ID3 (128 байт)
                byte[] tagByteArray = new byte[128];
                for (int i = 0; i < tagByteArray.Length; i++)
                    // инициализация массива значением 0
                    tagByteArray[i] = 0;
                // Конвертируем массив байтов в строку кодировки Windows-1251
                Encoding encoding = Encoding.GetEncoding(1251);

                // Копируем "TAG" в массив
                byte[] newByteArray = encoding.GetBytes("TAG");
                Array.Copy(newByteArray, 0,
                tagByteArray, 0, newByteArray.Length);
                // Копируем Title в массив
                newByteArray = encoding.GetBytes(paramMP3.id3Title);
                Array.Copy(newByteArray, 0,
                tagByteArray, 3, newByteArray.Length);
                // Копируем Artist в массив
                newByteArray = encoding.GetBytes(paramMP3.id3Artist);
                Array.Copy(newByteArray, 0,
                tagByteArray, 33, newByteArray.Length);
                // Копируем Album в массив
                newByteArray = encoding.GetBytes(paramMP3.id3Album);
                Array.Copy(newByteArray, 0,
                tagByteArray, 63, newByteArray.Length);
                // Копируем Year в массив
                newByteArray = encoding.GetBytes(paramMP3.id3Year);
                Array.Copy(newByteArray, 0,
                tagByteArray, 93, newByteArray.Length);
                // Копируем Comment в массив
                newByteArray = encoding.GetBytes(paramMP3.id3Comment);
                Array.Copy(newByteArray, 0,
                tagByteArray, 97, newByteArray.Length);
                // Копируем Track и Genre в массив
                tagByteArray[126] = paramMP3.id3TrackNumber;
                tagByteArray[127] = paramMP3.id3Genre;
                // Сохраняем результат на диске
                FileStream fs =
                    new FileStream(paramMP3.fileComplete, FileMode.Open);
                if (paramMP3.hasID3Tag)
                    fs.Seek(-128, SeekOrigin.End);
                else
                    fs.Seek(0, SeekOrigin.End);
                fs.Write(tagByteArray, 0, 128);
                fs.Close();
                paramMP3.hasID3Tag = true;
            }
        }
        MP3 mp3file;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveMP3();
        }
        private void SaveMP3()
        {
            if (mp3file.id3Title == null) return;
            mp3file.id3Title = txtTitle.Text;
            mp3file.id3Artist = txtArtist.Text;
            mp3file.id3Album = txtAlbum.Text;
            mp3file.id3Year = txtYear.Text;
            mp3file.id3Comment = txtComment.Text;
            mp3file.id3Genre = Convert.ToByte(txtGenre.Text);
            MP3Tag.SaveMP3Tag(ref mp3file);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cboGenres.Items.Add("Блюз");
            cboGenres.Items.Add("Классический рок");
            cboGenres.Items.Add("Кантри");
            cboGenres.Items.Add("Dance");
            cboGenres.Items.Add("Диско");
            cboGenres.Items.Add("Фанк");
            cboGenres.Items.Add("Гранж");
            cboGenres.Items.Add("Хип-Хоп");
            cboGenres.Items.Add("Джаз");
            cboGenres.Items.Add("Метал");
            cboGenres.Items.Add("НьюЭйдж");
            cboGenres.Items.Add("Oldies");
            cboGenres.Items.Add("Другое");
            cboGenres.Items.Add("Поп"); 
            cboGenres.Items.Add("Не определен");
        }
    }
}
