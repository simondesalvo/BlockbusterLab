using System;
using System.Collections.Generic;

namespace BlockbusterLab
{
    public class Blockbuster
    {
        //List<Movie> Movies w/ 3 DVDs and 3 VHS
        //PrintMovies()- prints titles and indexes
        //CheckOut() calls on PrintMovies() and ask the user which movie they want, get an index from the user,
        //select the movie from the list and PrintInfo() that movie
        List<Movie> Movies = new List<Movie>
        {
            new DVD("The Matrix", Genre.Action, 93, new List<string>(){"Start", "Middle", "Cool Part", "End" }),
            new DVD("Something's Gotta Give", Genre.Romance, 98, new List<string>(){"Start", "Ridiculousness", "She Doesn't Choose Keanu"}),
            new DVD("Bill and Ted's Excellent Adventure", Genre.Comedy, 90, new List<string>(){"Start", "Honestly Don't Remember", "End"}),
            new VHS("Knock Knock", Genre.Horror, 99, new List<string>(){"I've never seen it", "Didn't sound great", "Probably sexist"}, 0),
            new VHS("Devil's Advocate", Genre.Drama, 156, new List<string>(){"This movie is wild", "Al Pacino is the Devil", "Keanu is his lawyer"}, 0),
            new VHS("Sped", Genre.Action, 90, new List<string>(){"Keanu gets on the bus", "The bus goes either too fast or too slow", "Keanu gets off the bus"}, 0)
        };

        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine((i)+ Movies[i].Title);
            }
        }

        public void CheckOut()
        {
            PrintMovies();
            Console.WriteLine($"Which movie would you like? Pick a number between 0 and ${Movies.Count}");

            try
            {
                string pick = Console.ReadLine();
                int num = int.Parse(pick);
                Movies[num].PrintInfo();
            }
            catch (Exception)
            {
                Console.WriteLine("Yo, a number!");
            }
        }



    }
}
