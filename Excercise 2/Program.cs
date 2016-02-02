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

            System.IO.StreamWriter outputFileInts = new System.IO.StreamWriter("Someints.txt");
            System.IO.StreamWriter outputFileDoubles = new System.IO.StreamWriter("Somedoubles.txt");

            do
            {
                Console.Write("Give a Number (enter or not a number ends) : ");
                text = Console.ReadLine();
                integer = (int.TryParse(text, out i)) ;
                if (integer)
                {
                    outputFileInts.WriteLine(i);

                }
                else if (dubbles = (Double.TryParse(text, out d)))
                {
                    if (dubbles)
                    {
                        outputFileDoubles.WriteLine(d);
                    }
                }
                else
                    loop = false;

            } while(text.Length != 0 && loop == true);

            outputFileInts.Close();
            outputFileDoubles.Close();

            try
            {
                Console.WriteLine("Contents of Someints.txt :");
                text = File.ReadAllText("Someints.txt");
                Console.WriteLine(text);


                Console.WriteLine("\nContents of Somedoubles.txt :");
                text = File.ReadAllText("Somedoubles.txt");
                Console.WriteLine(text);
            }

            catch (Exception)
            {
                Console.WriteLine("Halp");
            }
        }
    }
}
