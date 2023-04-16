using System;

namespace AudioPlayerr
{
    class OggFile : IAudioFile
    {
        private string _fileName;

        public OggFile(string fileName)
        {
            _fileName = fileName;
        }

        public void Play()
        {
            Console.WriteLine($"Playing OGG file {_fileName}");
        }
    }



}

