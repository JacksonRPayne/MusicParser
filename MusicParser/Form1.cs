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
            song.Tempo = 100;

            song.GetNotesFromString("Ab,4,4; C#,3,16; G,4,1;");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            song.Play();
        }
    }
}
