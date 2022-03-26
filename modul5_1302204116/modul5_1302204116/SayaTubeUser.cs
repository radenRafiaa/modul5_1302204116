using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204116
{
    internal class SayaTubeUser
    {
        private int id;
        private string username;
        List<SayaTubeVideo> uploadedVideos;

        public SayaTubeUser(string username)
        {
            Random shuffle = new Random();
            this.id = shuffle.Next(0, 100000);
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (SayaTubeVideo video in this.uploadedVideos)
            {
                total += video.getPlayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User : " + this.username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " Judul : " + this.uploadedVideos[i].getTitle());
            }
        }
    }
}
