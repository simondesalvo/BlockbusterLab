using System;
using System.Collections.Generic;

namespace BlockbusterLab
{
    public abstract class Movie
    {

        //properties string title, string category, int RunTime, list<string> Scenes

        //virtual method PrintInfo() prints everything to console bu the scenes

        //method called PrintScenes() that prints all the scenes in the list as well as the index

        //abstract method with no return type called Play()

        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }


        //constructor
        public Movie() { }
        public Movie(string Title, Genre Category, int RunTime, List<string> Scenes) { }


        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Run Time: {RunTime}");
        }

        public virtual void PrintScenes()
        {
            for (int i = 0; i <= Scenes.Count; i++)
            {
                Console.WriteLine(i.ToString(), Scenes[i]);
            }
        }

        public abstract void Play();
    }
}
