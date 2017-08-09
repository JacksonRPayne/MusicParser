using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicParser
{
    public partial class Form1 : Form
    {
        Song song;
        public Form1()
        {
            InitializeComponent();

            song = new Song();
            song.Tempo = 120;

            song.Notes.Add(new Note(Note.ConvertKeyValueToFrequency(49), 4));
            song.Notes.Add(new Note(Note.ConvertKeyValueToFrequency(47), 4));
            song.Notes.Add(new Note(Note.ConvertKeyValueToFrequency(45), 2));

            song.Notes.Add(new Note(Note.ConvertKeyValueToFrequency(49), 4));
            song.Notes.Add(new Note(Note.ConvertKeyValueToFrequency(47), 4));
            song.Notes.Add(new Note(Note.ConvertKeyValueToFrequency(45), 2));

            for (int i = 0; i < 4; i++)
            {
                song.Notes.Add(new Note(Note.ConvertKeyValueToFrequency(45), 8));
            }
            for (int i = 0; i < 4; i++)
            {
                song.Notes.Add(new Note(Note.ConvertKeyValueToFrequency(47), 8));
            }

            song.Notes.Add(new Note(Note.ConvertKeyValueToFrequency(49), 4));
            song.Notes.Add(new Note(Note.ConvertKeyValueToFrequency(47), 4));
            song.Notes.Add(new Note(Note.ConvertKeyValueToFrequency(45), 2));

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            song.Play();
        }
    }
}
