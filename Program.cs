using System;
using System.Collections.Generic;

namespace BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster theStore = new Blockbuster();
            bool programStart = true;
            while (programStart)
            {
                
                Console.WriteLine("Welcome to Blockbuster, home of the Blockbuster, may I take your order?");
                Console.WriteLine("Press 1 for a list of what we have");
                Console.WriteLine("Press 2 to check out");
                Console.WriteLine("Press 3 to leave this weird KeanuLand");
                Console.WriteLine();
                int numInput;
                string input = Console.ReadLine();
                int.TryParse(input, out numInput);
                if (numInput == 1)
                {
                    theStore.PrintMovies();
                    Console.WriteLine();
                    programStart = true;
                }
                else if (numInput == 2)
                {
                    theStore.CheckOut();
                    Console.WriteLine();
                    programStart = true;
                }
                else if (numInput == 3)
                {
                    Console.WriteLine("Cool, see ya");
                    programStart = false;
                }
                else
                {
                    Console.WriteLine("Nope nope nope, 1-3");
                    programStart = true;
                }
            }
            

        }
    }
}
