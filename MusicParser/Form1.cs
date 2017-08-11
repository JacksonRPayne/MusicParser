using System;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace MusicParser
{
    public partial class Form1 : Form
    {
        Song song;
        Thread playThread;
        public Form1()
        {
            InitializeComponent();

            song = new Song();
            btnPlay.Enabled = false;
        }

        /// <summary>
        /// When the Load button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Prompt to open a file
            OpenFileDialog ofd = new OpenFileDialog();

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                //Read through it and set the notes
                StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));
                song.Notes.Clear();
                song.GetNotesFromString(sr.ReadToEnd());
                //Update the file label and play button
                fileLabel.Text = ofd.FileName;
                btnPlay.Enabled = true;
            }
        }

        /// <summary>
        /// When the Play button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e) { 
            //Sets the song tempo
            song.Tempo = tempoTrack.Value;
            //Plays the song over a thread
            playThread = new Thread(song.Play);
            playThread.Start();

        }

        /// <summary>
        /// When the tempo slider is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tempoTrack_ValueChanged(object sender, EventArgs e)
        {
            //Updating tempo text
            tempoLabel.Text = "Tempo: " + tempoTrack.Value;
        }

        /// <summary>
        /// When the form closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Closes the playThread
            playThread.Abort();
        }
    }
}
