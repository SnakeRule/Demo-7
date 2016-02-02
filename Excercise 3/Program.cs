using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Shows object tvshows
            Shows tvshows = new Shows();

            //Adding some shows to the shows list in the tvshows object
            Show xfiles = new Show { Name = "X-Files", Channel = "Fox", StartTime = "21:55", EndTime = "22:50", info = "The truth is out there" };
            tvshows.AddShow(xfiles);

            Show simpsons = new Show { Name = "The Simpsons", Channel = "Sub", StartTime = "20:30", EndTime = "21:00", info = "This show is old and tired." };
            tvshows.AddShow(simpsons);

            Show walker = new Show { Name = "Texas Ranger", Channel = "Sub", StartTime = "17:00", EndTime = "18:00", info = "Well, it's shit. But it does have Chuck Norris." };
            tvshows.AddShow(walker);

            tvshows.WriteToFile();

            tvshows.ReadFile();

            tvshows.PrintLoadedData();
        }
    }
}
