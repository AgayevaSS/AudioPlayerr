using System;

namespace AudioPlayerr
{
    class Mp3File : IAudioFile
    {
        private string _fileName;

        public Mp3File(string fileName)
        {
            _fileName = fileName;
        }

        public void Play()
        {
            Console.WriteLine($"Playing MP3 file {_fileName}");
        }
    }



}

