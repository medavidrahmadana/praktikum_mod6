using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODUL6_1302213079;

namespace MODUL6_1302213079
{
    internal class SayaTubeVideo
    {
        private int id;
        public string title;
        public int playCount;

        public SayaTubeVideo(string title)
        {
            if (title == null || title.Length > 100)

            this.id = new Random().Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }
        public void IncreasePlayCount(int count)
        {
            if (count > 10000000)
            {
                this.playCount += count;
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: {0}", this.id);
            Console.WriteLine("Title: {0}", this.title);
            Console.WriteLine("Play count: {0}", this.playCount);
        }
    }
}

