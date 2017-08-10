using System;
using System.Collections.Generic;

namespace MusicParser
{
    class Note : MusicNotation
    {
        private static Dictionary<string, double> noteFrequencies = new Dictionary<string, double>() {
                { "A", 27.5 },
                { "A#", 29.1352}, { "Bb", 29.1352},
                { "B", 30.8677},
                { "C", 32.7032 },
                { "C#", 34.6478 }, { "Db", 34.6478 },
                { "D", 36.7081},
                { "D#",  38.8909}, { "Eb",  38.8909},
                { "E", 41.2034 },
                { "F", 43.6535 },
                { "F#", 46.2493 }, { "Gb", 46.2493 },
                { "G", 48.9994 },
                { "G#", 51.9131 }, { "Ab", 51.9131 }
            };

        private int _frequency;
        public int Frequency { get { return _frequency; }
            set {
                if (value > 0)
                    _frequency = value;
                else
                    throw new Exception("Frequency must be greater than zero");
            }
        }

        public Note(int frequency, int flag) : base(flag)
        {
            Frequency = frequency;

        }

        /// <summary>
        /// Takes in a key on a piano and converts it into a frequency (ex: 49 = A(440HZ))
        /// </summary>
        /// <param name="keyValue"></param>
        /// <returns></returns>
        public static int ConvertKeyValueToFrequency(int keyValue)
        {
            double returnedFrequency = Math.Pow(2D, (keyValue - 49) / 12D )* 440D;
            return (int)Math.Round(returnedFrequency);
        }

        /// <summary>
        /// Takes in a string containing a letter and returns the frequency of that note (ex: "A" = 440HZ)
        /// </summary>
        /// <param name="letter"></param>
        /// <param name="octave"></param>
        /// <returns></returns>
        public static int ConvertLetterNoteToFrequency(string letter, int octave)
        {
            double returnedFrequency = Math.Pow(2D, octave) * noteFrequencies[letter];
            return (int)Math.Round(returnedFrequency);
        }

        public override void Play(int tempo)
        {
            //Finds the duration of the note in miliseconds based off of the tempo then plays it
            int duration = convertFlagToMiliseconds(tempo);
            Console.Beep(Frequency, duration);
        }

    }
}
