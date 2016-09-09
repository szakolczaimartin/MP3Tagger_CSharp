using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MondayDriver
{
    class Mp3D3Tagger
    {
        private string tag;
        private string title;
        private string artist;
        private string album;
        private string year;
        private string comment;
        private string genre;


        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        public string Album
        {
            get { return album; }
            set { album = value; }
        }

        public string Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public string Tag
        {
            get { return tag; }
            set { tag = value; }
        }


        public byte[] Last128Bytes(string filename)
        {
            FileStream myFile;
            byte[] data;
            const int SIZE = 128;
            myFile = File.OpenRead(filename);
            data = new byte[SIZE];
            myFile.Seek(-128, SeekOrigin.End);
            myFile.Read(data, 0, SIZE);
            myFile.Close();

            return data;
        }

        public void ID3tagSet(byte[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (i < 3)
                {
                    Tag += Convert.ToChar(data[i]).ToString();
                }
                else if (3 <= i && i < 33)
                {
                    Title += Convert.ToChar(data[i]).ToString();
                }
                else if (33 <= i && i < 63)
                {
                    Artist += Convert.ToChar(data[i]).ToString();
                }
                else if (63 <= i && i < 93)
                {
                    Album += Convert.ToChar(data[i]).ToString();
                }
                else if (93 <= i && i < 97)
                {
                    Year += Convert.ToChar(data[i]).ToString();
                }
                else if (97 <= i && i < 127)
                {
                    Comment += Convert.ToChar(data[i]).ToString();
                }
                else
                {
                    Genre += Convert.ToChar(data[i]).ToString();
                }


            }
        }

        public void DoMP3Tagger(string filename)
        {

            byte[] data = Last128Bytes(filename);
            ID3tagSet(data);
        }



        public void CreateTheNewMp3(string filename, string targetFile)
        {
            byte[] last128 = new byte[128];
            String last128String;
            
            FillText();
            last128String = Createlast128String();
            byte[] firstPart = FirstPartBytes(filename);

            byte[] secondPart = System.Text.Encoding.ASCII.GetBytes(last128String);

            byte[] music = new byte[firstPart.Length + secondPart.Length];
            System.Buffer.BlockCopy(firstPart, 0, music, 0, firstPart.Length);
            System.Buffer.BlockCopy(secondPart, 0, music, firstPart.Length, secondPart.Length);

            File.WriteAllBytes(targetFile, music);
            Console.WriteLine("Ready");
        }




        private void FillText()
        {
            do
            {
                if (Tag.Length != 3)
                {
                    Tag += " ";
                }

            } while (Tag.Length < 3);

            do
            {
                if (Title.Length != 30)
                {
                    Title += " ";

                }
            } while (Title.Length < 30);

            do
            {
                if (Artist.Length != 30)
                {
                    Artist += " ";
                }
            } while (Artist.Length < 30);

            do
            {
                if (Album.Length != 30)
                {
                    Album += " ";
                }
            } while (Album.Length < 30);

            do
            {
                if (Year.Length != 4)
                {
                    Year += " ";
                }
            } while (Title.Length < 4);

            do
            {
                if (Comment.Length != 30)
                {
                    Comment += " ";
                }
            } while (Comment.Length < 30);

            do
            {
                if (Genre.Length != 1)
                {
                    Genre += " ";
                }
            } while (Genre.Length < 1);



        }

        private string Createlast128String()
        {

            StringBuilder sb = new StringBuilder();

            sb.Append(Tag.ToString());
            sb.Append(Title.ToString());
            sb.Append(Artist.ToString());
            sb.Append(Album.ToString());
            sb.Append(Year.ToString());
            sb.Append(Comment.ToString());
            sb.Append(Genre.ToString());

            return sb.ToString(); 


        }


        private byte[] FirstPartBytes(string filename)
        {
            byte[] firstPart;
            FileStream myFile;

            myFile = File.OpenRead(filename);
            int size = (int)myFile.Length - 128;
            firstPart = new byte[size];
            myFile.Seek(0, SeekOrigin.Begin);
            myFile.Read(firstPart, 0, size);
            myFile.Close();

            return firstPart;
        }

    }
}
