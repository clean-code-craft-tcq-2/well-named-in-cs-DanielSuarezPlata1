using System;
using System.Collections.Generic;
using System.Text;

namespace TelCo.ColorCoder
{
    public partial class Program
    {
        public static int ShowReferenceManual()
        {
            Console.WriteLine("___________________________________________");
            Console.WriteLine("|            Reference Manual             |");
            Console.WriteLine("-------------------------------------------");


            Console.WriteLine(String.Format("|{0,7}|{1,7}|{2,7}|", " Pair Number ", " Major Color ", " Minor Color "));
            Console.WriteLine("-------------------------------------------");

            int numberOfPairs = colorMapMajor.Length * colorMapMinor.Length;

            int numberOfPairsPrinted = 0;

            for (int i = 0; i < numberOfPairs; i++)
            {
                numberOfPairsPrinted = i + 1;

                ColorPair pair = Program.FetchColorPair(numberOfPairsPrinted);

                Console.WriteLine(
                        String.Format("|{0,13}|{1,13}|{2,13}|", numberOfPairsPrinted, pair.majorColor.Name, pair.minorColor.Name)
                    );
                Console.WriteLine("-------------------------------------------");
            }

            return numberOfPairsPrinted;
        }

    }
}
