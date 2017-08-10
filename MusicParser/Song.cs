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

        /// <summary>
        /// Takes in a string consisting of notes (ex: A(note),4(octave),4(flag);) and rests (R, 4(flag);) and adds them to the notes of the song
        /// </summary>
        /// <param name="inputString"></param>
        public void GetNotesFromString(string inputString)
        {
            //Removes all whitespace from the string
            string trimmedString = inputString.Replace(" ", "");
            //Splits the string by semicolons
            string[] Data = trimmedString.Split(';');
            string[] dataSpecifics;

            //Loops through the data
            for (int i = 0; i < Data.Length - 1; i++)
            {
                //Splits data by comma
                dataSpecifics = Data[i].Split(',');

                //Checks if its a rest or a note then creates it
                if (dataSpecifics[0] == "R")
                {
                    Notes.Add(new Rest(Convert.ToInt32(dataSpecifics[1])));
                }
                else
                {
                    Notes.Add(new Note(
                        Note.ConvertLetterNoteToFrequency(dataSpecifics[0], Convert.ToInt32(dataSpecifics[1])),
                        Convert.ToInt32(dataSpecifics[2])));
                }
            }

        }

    }
}

