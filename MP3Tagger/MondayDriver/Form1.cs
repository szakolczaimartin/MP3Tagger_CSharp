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

namespace MondayDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] drives = System.IO.Directory.GetLogicalDrives();

            foreach (string item in drives)
            {
                comboBox1.Items.Add(item);
            }

        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               listBox1.Items.Clear();
                pathText.Text = comboBox1.Text;
                string[] directoryList = Directory.GetDirectories(pathText.Text);
                foreach (string item in directoryList)
                {
                    listBox1.Items.Add(item.Substring(pathText.TextLength));
                    
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }


        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            string mark = "\\";
            string path = pathText.Text + listBox1.SelectedItem.ToString();
            string otherPath = pathText.Text + listBox1.SelectedItem.ToString() + mark;


            if (path[path.Length - 1].Equals(mark))
            {
                GetPath(path);
            }
            else
            {
                GetPath(otherPath);
            }
        }

        public void GetPath(string marketItem)
        {
            if (listBox1.SelectedItem.ToString().EndsWith(".mp3"))
            {
                mp3TextBox.Text = pathText.Text + listBox1.SelectedItem.ToString();
                PushId3Boxes(mp3TextBox.Text);
            }
            else
            {
                ListDirectory(@marketItem);
            }

        }

        public void PushId3Boxes(string filename)
        {

            Mp3D3Tagger myMp3 = new Mp3D3Tagger();
            myMp3.DoMP3Tagger(filename);

            tagBox.Text = myMp3.Tag;
           
            titleBox.Text = myMp3.Title;
            artistBox.Text = myMp3.Artist;
            albumBox.Text = myMp3.Album;
            yearBox.Text = myMp3.Year;
            commentBox.Text = myMp3.Comment;
            genreBox.Text = myMp3.Genre;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Mp3D3Tagger editMp3 = new Mp3D3Tagger();

            editMp3.Tag = tagBox.Text;
            editMp3.Artist = artistBox.Text;
            editMp3.Album = albumBox.Text;
            editMp3.Year = yearBox.Text;
            editMp3.Title = titleBox.Text;
            editMp3.Comment = commentBox.Text;
            editMp3.Genre = genreBox.Text;

            editMp3.CreateTheNewMp3(@mp3TextBox.Text, "C:\\Users\\Szakolczai Martin\\Desktop\\prob3.mp3");

            ClearIDTags();
            listBox1.Items.Clear();
            ListDirectory(pathText.Text);


        }


        private void ClearIDTags()
        {
            tagBox.Clear();
            artistBox.Clear();
            albumBox.Clear();
            yearBox.Clear();
            titleBox.Clear();
            commentBox.Clear();
            genreBox.Clear();
            mp3TextBox.Clear();


        }


        private void ListDirectory(string marketItem)
        {

            
                try
                {
                    string[] directoryList = Directory.GetDirectories(@marketItem);
                    string[] fileList = Directory.GetFiles(@marketItem);
                    pathText.Text = @marketItem;
                    listBox1.Items.Clear();
                    foreach (var directory in directoryList)
                    {
                        listBox1.Items.Add(directory.Substring(@marketItem.Length));
                    }
                    foreach (var file in fileList)
                    {
                        listBox1.Items.Add(file.Substring(@marketItem.Length));
                    }
                }
                catch (Exception exception)
                {

                    MessageBox.Show("This is a file which is not mp3.");


                }

        }


      
    }




}
