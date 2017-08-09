using System;

namespace MusicParser
{
    abstract class MusicNotation
    {
        protected int _flag;
        public int Flag{ get { return _flag; }
            set {
                if (value > 0)
                    _flag = value;
                else
                    throw new Exception("Flag was set below 0");
            }
        }

        public MusicNotation(int flag)
        {
            Flag = flag;
        }

        /// <summary>
        /// Takes the flag of the note and converts it into a milisecond value with a parameter of tempo in BPM
        /// </summary>
        /// <param name="tempo"></param>
        /// <returns></returns>
        protected int convertFlagToMiliseconds(int tempo)
        {
            double wholeNote = (60000D / tempo)*4D;
            double division = wholeNote / Flag;

            return (int)Math.Round(division);
        }

        /// <summary>
        /// Plays the note or Rest
        /// </summary>
        /// <param name="tempo"></param>
        public abstract void Play(int tempo);

    }
}
