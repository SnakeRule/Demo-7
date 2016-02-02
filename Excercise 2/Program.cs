using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double d;
            string text;
            bool integer;
            bool dubbles;
            bool loop = true;

            // Opening streamwriters for two files
            StreamWriter outputFileInts = new StreamWriter("Someints.txt"); // For saving integers
            StreamWriter outputFileDoubles = new StreamWriter("Somedoubles.txt"); // For saving doubles

            do
            {
                Console.Write("Give a Number (enter or not a number ends) : ");
                text = Console.ReadLine();

                integer = (int.TryParse(text, out i)); // Checking if the entered string can be parsed to an int
                if (integer)
                {
                    outputFileInts.WriteLine(i); // If parsing was possible, int i is saved to file Someints.txt
                }
                else if (dubbles = (Double.TryParse(text, out d))) // Checking if the entered string can be parsed to a double
                {
                    if (dubbles)
                    {
                        outputFileDoubles.WriteLine(d); // If parsing was possible double d is saved to file Somedoubles.txt
                    }
                }
                else
                    loop = false; // If something that can't be parsed is entered, the loop breaks

            } while(loop == true);


            // Closing the filestreams so they can be read soon after
            outputFileInts.Close(); 
            outputFileDoubles.Close();

            try // For Exception handling
            {
                Console.WriteLine("Contents of Someints.txt :");
                text = File.ReadAllText("Someints.txt");
                Console.WriteLine(text);


                Console.WriteLine("\nContents of Somedoubles.txt :");
                text = File.ReadAllText("Somedoubles.txt");
                Console.WriteLine(text);
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }

            catch (Exception)
            {
                Console.WriteLine("Well, you REALLY broke something now.");
            }
        }
    }
}
