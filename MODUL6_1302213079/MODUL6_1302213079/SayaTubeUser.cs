using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MODUL6_1302213079;


namespace MODUL6_1302213079
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public String Username;

        public SayaTubeUser(String Username) 
        {
            this.Username = Username;
            id = new Random().Next(10000, 99999);
            uploadedVideos= new List<SayaTubeVideo>();
        }
        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            for(int i = 0;i < uploadedVideos.Count;i++)
            {
                total += uploadedVideos.Count;
            }
            return total;
        }
        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User = " + Username);
            for (int i = 0; i < uploadedVideos.Count || i < 8; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " judul " + uploadedVideos[i].title);
            }
        }
    }
}
