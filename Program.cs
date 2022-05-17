using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace findinvalidchar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the full file path:");
            string filePath = Console.ReadLine();


            string[] lines = System.IO.File.ReadAllLines(filePath);

            int lineNumber = 0;
            
            foreach (string line in lines)
            {
                lineNumber++;

                Regex rg = new Regex(@"^[a-z A-Z0-9_:.@$=/-]*$");

                if (!rg.IsMatch(line))
                {
                    for(int i = 0; i < line.Length; i++)
                    { 
                        if(!rg.IsMatch(line[i].ToString()))
                        {
                            Console.WriteLine("\t" + line[i] + "  Character number " + i + " on line number " + lineNumber);
                        }    
                    }
                }


            }

        }

    }


}
