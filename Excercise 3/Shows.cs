using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3
{
    class Shows
    {
        // Creating a list for the shows and then the loaded shows
        public List<Show> shows;
        public List<Show> loadedShows;

        // Shows constructor creates the lists
        public Shows()
        {
            shows = new List<Show>();
            loadedShows = new List<Show>();
        }

        // AddShow adds a show to the list
        public void AddShow(Show show)
        {
            shows.Add(show);
        }

        // Writing the shows list to a file
        public void WriteToFile()
        {
            // Creating a Filestream for the writing the file
            Stream tvShows = new FileStream("TvShows.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            // Creating a BinaryFormatter object
            IFormatter formatter = new BinaryFormatter();

            // shows list gets serialized to tvshows and ends up in TvShows.bin file
            formatter.Serialize(tvShows, shows);

            // Closing the Filestream
            tvShows.Close();
        }

        // Method for reading the file to a list
        public void ReadFile()
        {
            // Creating a filestream for reading the file
            Stream tvShowsRead = new FileStream("TvShows.bin", FileMode.Open, FileAccess.Read, FileShare.None);

            // Creating a BinaryFormatter object
            IFormatter formatter = new BinaryFormatter();

            // The binary data gets Deserialized and put into the list loadedShows
            loadedShows = (List<Show>) formatter.Deserialize(tvShowsRead);
        }

        // Method for printing the loaded data
        public void PrintLoadedData()
        {
            shows.Clear(); // Clears the original shows list as proof that the data is being loaded from the loadedShows list
            foreach(Show loadedShows in loadedShows)
            {
                Console.WriteLine("Show Name : " + loadedShows.Name + "\nChannel : " + loadedShows.Channel + "\nStarting time : " + loadedShows.StartTime + "\nEnding time : " + loadedShows.EndTime + "\nShow Info : " + loadedShows.info + "\n\n");
            }
        }
    }
}
