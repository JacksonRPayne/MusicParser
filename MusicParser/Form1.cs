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
            song.Tempo = 90;

            //song.GetNotesFromString("A,4,4; G,3,4; F,3,4;R,4;A,4,4; G,3,4; F,3,4;R,4;");
            song.GetNotesFromString("A,4,4");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            song.Play();
        }
    }
}
