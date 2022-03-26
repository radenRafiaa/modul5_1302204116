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
        internal string username;
        List<SayaTubeVideo> uploadedVideos;
        private string video;

        public SayaTubeUser(string username)
        {
            Random shuffle = new Random();
            this.id = shuffle.Next(0, 100000);
            this.uploadedVideos = new List<SayaTubeVideo>();

            Debug.Assert(username.Length < 100, "Nama username tidak boleh lebih dari 100 karakter");
            Debug.Assert(username != null, "Nama username tidak boleh kosong");

            string cek;

            try
            {
                cek = checked(username);
                this.video = username;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
            Debug.Assert(video != null, "Video tidak boleh kosong");

            string cek;

            try
            {
                cek = checked(this.video);
                this.video = this.video;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User : " + this.video);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " Judul : " + this.uploadedVideos[i].getTitle());
            }
        }
    }
}
