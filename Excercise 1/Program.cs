using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Excercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            string text = null;
            StreamWriter outputFile = new StreamWriter("SomeText.txt");

            do
            {
                Console.Write("Enter some text : ");
                text = Console.ReadLine();
                if (text == "")
                    loop = false;
                else
                    outputFile.WriteLine(text);

            } while (loop == true);

            if (outputFile != null)
            {
                outputFile.Close();
            }


            try
            {
                text = File.ReadAllText("SomeText2.txt");

                Console.WriteLine("You wrote :\n" + text);
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
        }
    }
}
