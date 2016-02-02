using System;
using System.Collections.Generic;
using System.Linq;
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
                dubbles = (Double.TryParse(text, out d));
                if (dubbles)
                {
                    outputFileDoubles.WriteLine(d);
                }


            } while(text.Length != 0);

            outputFileDoubles.Close();
            outputFileDoubles.Close();
        }
    }
}
