using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practice_DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var tester = new MediaTester();
            var mp3 = new Mp3Player();
            var mp4 = new Mp4Player();
            var mp3Delegate = new MediaTester.TestMedia(mp3.PlayMP3File);
            var mp4Delegate = new MediaTester.TestMedia(mp4.PlayMP4File);
            tester.RunTest(mp3Delegate);
            tester.RunTest(mp4Delegate);
            Console.ReadLine();
        }
    }

    class MediaTester
    {
        public delegate int TestMedia();
        public void RunTest(TestMedia testDelegate)
        {
            int result = testDelegate();
            if (result == 0)
            {
                Console.WriteLine("Works!");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }

    class Mp3Player
    {
        public int PlayMP3File()
        {
            Console.WriteLine("Playing Mp3 file.....");
            return 0;
        }
    }

    class Mp4Player
    {
        public int PlayMP4File()
        {
            Console.WriteLine("Playing Mp4 file.....");
            return 1;
        }
    }
}
