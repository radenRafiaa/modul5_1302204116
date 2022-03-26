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
            this.playCount = 0;

            Debug.Assert(title.Length < 200, "Judul video tidak boleh lebih dari 200 karakter");
            Debug.Assert(title != null, "Judul video tidak boleh kosong");

            string cek;

            try
            {
                cek = checked(title);
                this.title = title;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void IncreasePlayCount(int data)
        {
            Debug.Assert(this.playCount <= int.MaxValue);
            Debug.Assert(data <= 25000000, "Input penambahan play count tidak boleh lebih dari 25.000.000");
            Debug.Assert(data > 0, "Input play count tidak boleh  bilangan negatif");

            int cek;
            try
            {
                cek = checked(this.playCount + data);
                this.playCount += data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
                this.playCount = this.playCount;
            }
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