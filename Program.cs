using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayerr
{
    class Program
    {
        static void Main(string[] args)
        {
            IAudioFile audioFile;

            audioFile = new Mp3File("song.mp3");
            audioFile.Play();

            audioFile = new WavFile("sound.wav");
            audioFile.Play();

            audioFile = new OggFile("music.ogg");
            audioFile.Play();
        }
    }

    interface IAudioFile
    {
        void Play();
    }



}

