using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicParser
{
    class Song
    {
        private int _tempo;
        public int Tempo { get { return _tempo; }
            set
            {
                if (value > 0)
                    _tempo = value;
                else
                    throw new Exception("Tempo must be above zero");
            }
        }

        public List<MusicNotation> Notes { get; set; }

        public Song()
        {
            Notes = new List<MusicNotation>();
        }
        
        /// <summary>
        /// Plays all the Music Notations in the Notes list in succesion
        /// </summary>
        public void Play()
        {
            for (int i = 0; i < Notes.Count; i++)
            {
                Notes[i].Play(Tempo);
            }
        }
    }
}
