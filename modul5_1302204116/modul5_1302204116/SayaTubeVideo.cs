using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204116
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random shuffle = new Random();
            this.id = shuffle.Next(0, 100000);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int data)
        {
                this.playCount += data;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Id         : " + this.id);
            Console.WriteLine("Title      : " + this.title);
            Console.WriteLine("Play Count : " + this.playCount);
        }

        public string getTitle()
        {
            return this.title;
        }

        public int getPlayCount()
        {
            return this.playCount;
        }
    }
}