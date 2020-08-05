using System;
using System.Collections.Generic;

namespace BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster theStore = new Blockbuster();
            while (true)
            {
                
                Console.WriteLine("Welcome to Blockbuster, home of the Blockbuster, may I take your order? Here's your selection:");
                Console.WriteLine("Press 1 for a list of what we have");
                Console.WriteLine("Press 2 to check out");
                Console.WriteLine("Press 3 to watch a movie in here");
                int numInput;
                string input = Console.ReadLine();
                int.TryParse(input, out numInput);
                if (numInput == 1)
                {
                    theStore.PrintMovies();
                }
            }
            

        }
    }
}
