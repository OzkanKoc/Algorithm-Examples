using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimingStartAndEndSpaceChars
{
    class Program
    {
        static string GetTrimmedText(string input)
        {
            string output = string.Empty;
            string spaceChars = string.Empty;
            int index = 0;

            while (index < input.Length)
            {
                if (input[index] == ' ')
                {
                    spaceChars += ' ';
                }
                else
                {
                    if (output.Length > 0)
                    {
                        output += spaceChars;
                    }

                    spaceChars = string.Empty;
                    output += input[index];
                }
                index++;
            }

            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a text for triming");
            string input = Console.ReadLine();

            string output = GetTrimmedText(input);

            Console.WriteLine("Trimmed Text: \"{0}\"", output);

            Console.ReadLine();
        }
    }
}
