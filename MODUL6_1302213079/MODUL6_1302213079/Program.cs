using MODUL6_1302213079;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL6_1302213079
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser David = new SayaTubeUser("David");
            SayaTubeVideo David2 = new SayaTubeVideo("David");

            David.AddVideo(new SayaTubeVideo("Review Film High&Low 1 oleh David"));
            David.AddVideo(new SayaTubeVideo("Review Film High&Low 2 oleh David"));
            David.AddVideo(new SayaTubeVideo("Review Film High&Low 3 oleh David"));
            David.AddVideo(new SayaTubeVideo("Review Film High&Low 4 oleh David"));
            David.AddVideo(new SayaTubeVideo("Review Film High&Low 5 oleh David"));
            David.AddVideo(new SayaTubeVideo("Review Film High&Low 6 oleh David"));
            David.AddVideo(new SayaTubeVideo("Review Film High&Low 7 oleh David"));
            David.AddVideo(new SayaTubeVideo("Review Film High&Low 8 oleh David"));
            David.AddVideo(new SayaTubeVideo("Review Film High&Low 9 oleh David"));
            David.AddVideo(new SayaTubeVideo("Review Film High&Low 10 oleh David"));
            
            David2.PrintVideoDetails();
            David.PrintAllVideoPlaycount();
        }
    }
}
