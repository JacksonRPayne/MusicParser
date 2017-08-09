using System;

namespace MusicParser
{
    class Note : MusicNotation
    {
        private int _frequency;
        public int Frequency { get { return _frequency; }
            set {
                if (value > 0)
                    _frequency = value;
                else
                    throw new Exception("Frequency must be greater than zero");
            }
        }

        /// <summary>
        /// Takes in a key on a piano and converts it into a frequency (ex: 49 = A(440HZ))
        /// </summary>
        /// <param name="keyValue"></param>
        /// <returns></returns>
        public static int ConvertKeyValueToFrequency(int keyValue)
        {
            double returnedFrequency = Math.Pow(2D, (keyValue - 49) / 12D )* 440D;
            return (int)returnedFrequency;
        }

        public override void Play(int tempo)
        {
            int duration = convertFlagToMiliseconds(tempo);
            Console.Beep(Frequency, duration);
        }

        public Note(int frequency, int flag) : base(flag)
        {
            Frequency = frequency;
        }
    }
}
