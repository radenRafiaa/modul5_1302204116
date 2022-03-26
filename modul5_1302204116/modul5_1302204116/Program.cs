using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204116
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SayaTubeUser user1 = new SayaTubeUser("DENRAFI");

            SayaTubeVideo video1 = new SayaTubeVideo("Review Film Captain America: The First Avenger oleh DENRAFI");
            user1.AddVideo(video1);
            SayaTubeVideo video2 = new SayaTubeVideo("Review Film Captain Marvel oleh DENRAFI");
            user1.AddVideo(video2);
            SayaTubeVideo video3 = new SayaTubeVideo("Review Film Iron Man oleh DENRAFI");
            user1.AddVideo(video3);
            SayaTubeVideo video4 = new SayaTubeVideo("Review Film Iron Man 2 oleh DENRAFI");
            user1.AddVideo(video4);
            SayaTubeVideo video5 = new SayaTubeVideo("Review Film The Incredible Hulk oleh DENRAFI");
            user1.AddVideo(video5);
            SayaTubeVideo video6 = new SayaTubeVideo("Review Film Thor oleh DENRAFI");
            user1.AddVideo(video6);
            SayaTubeVideo video7 = new SayaTubeVideo("Review Film The Avengers oleh DENRAFI");
            user1.AddVideo(video7);
            SayaTubeVideo video8 = new SayaTubeVideo("Review Film Iron Man 3 oleh DENRAFI");
            user1.AddVideo(video8);
            SayaTubeVideo video9 = new SayaTubeVideo("Review Film Thor: Dark World oleh DENRAFI");
            user1.AddVideo(video9);
            SayaTubeVideo video10 = new SayaTubeVideo("Review Film Captain America: Winter Soldier oleh DENRAFI");
            user1.AddVideo(video10);
            video1.IncreasePlayCount(4116);
            user1.PrintAllVideoPlaycount();
            Console.WriteLine(user1.GetTotalVideoPlayCount());
            user1.GetTotalVideoPlayCount();
        }
    }
}