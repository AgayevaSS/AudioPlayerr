using System;

namespace AudioPlayerr
{
    class WavFile : IAudioFile
    {
        private string _fileName;

        public WavFile(string fileName)
        {
            _fileName = fileName;
        }

        public void Play()
        {
            Console.WriteLine($"Playing WAV file {_fileName}");
        }
    }



}

