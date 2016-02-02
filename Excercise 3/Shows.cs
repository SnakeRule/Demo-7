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
        // Creating the stream used to write and read the file
        Stream tvShowsFileStream;


        /// <summary>
        /// Shows constructor creates the lists
        /// </summary>
        public Shows()
        {
            shows = new List<Show>();
            loadedShows = new List<Show>();
        }


        /// <summary>
        /// AddShow adds a show to the list
        /// </summary>
        /// <param name="show">object containing the tv show data</param>
        public void AddShow(Show show)
        {
            shows.Add(show);
        }


        /// <summary>
        /// Writing the shows list to a file
        /// </summary>
        public void WriteToFile()
        {
            try
            {
                // Creating a Filestream for the writing the file
                tvShowsFileStream = new FileStream("tvShows.bin", FileMode.Create, FileAccess.Write, FileShare.None);

                // Creating a BinaryFormatter object
                IFormatter formatter = new BinaryFormatter();

                // shows list gets serialized to tvShowsFileStream and ends up in tvShowsFileStream.bin file
                formatter.Serialize(tvShowsFileStream, shows);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }

            catch (Exception)
            {
                Console.WriteLine("Something really broke now!");
            }

            finally
            {
                // Closing the Filestream
                if(tvShowsFileStream != null)
                {
                    tvShowsFileStream.Close();
                }
            }
        }


        /// <summary>
        /// Method for reading the file to a list
        /// </summary>
        public void ReadFile()
        {
                try
                {
                    // Creating a filestream for reading the file
                    tvShowsFileStream = new FileStream("tvShows.bin", FileMode.Open, FileAccess.Read, FileShare.None);

                    // Creating a BinaryFormatter object
                    IFormatter formatter = new BinaryFormatter();

                    // The binary data gets Deserialized and put into the list loadedShows
                    loadedShows = (List<Show>)formatter.Deserialize(tvShowsFileStream);
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File not found!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went really wrong!");
                }
                finally
                {
                    if (tvShowsFileStream != null)
                    {
                       tvShowsFileStream.Close();
                    }
                }
        }

        /// <summary>
        /// Method for printing the loaded data
        /// </summary>
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
