using System.Threading;

namespace MusicParser
{
    class Rest : MusicNotation
    {
        public Rest(int flag) : base(flag)
        {
        }

        public override void Play(int tempo)
        {
            int duration = convertFlagToMiliseconds(tempo);
            Thread.Sleep(duration);
        }
    }
}
