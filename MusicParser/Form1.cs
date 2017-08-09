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

            song.Notes.Add(new Note(Note.ConvertLetterNoteToFrequency("A", 3), 4));
            song.Notes.Add(new Note(Note.ConvertLetterNoteToFrequency("G", 2), 4));
            song.Notes.Add(new Note(Note.ConvertLetterNoteToFrequency("F", 2), 2));
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            song.Play();
        }
    }
}
