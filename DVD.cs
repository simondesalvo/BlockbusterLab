using System;
using System.Collections.Generic;

namespace BlockbusterLab
{
    public class DVD : Movie
    {
        //void method called Play() w/ no parameters that prints list of scenes, asks user what scene they want,
        //prints out scene selection

        public DVD() { }
        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes):base(Title, Category, RunTime, Scenes)
        {
            base.Title = Title;
            base.Category = Category;
            base.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        public override void Play()
        {
            bool dvdStart = true;
            while (dvdStart)
            {
                PrintScenes();
                Console.WriteLine($"Please select which scene you would like, numbers 0 to {Scenes.Count - 1}");

                try
                {
                    string pick = Console.ReadLine();
                    int num = int.Parse(pick);
                    Console.WriteLine(Scenes[num]);

                    Console.WriteLine("Want to watch another scene? y/n");
                    string input = Console.ReadLine();
                    input.ToLower();
                    if (input == "y" || input == "yes")
                    {
                        dvdStart = true;
                    }
                    else
                    {
                        Console.WriteLine("Cool, you don't have to rewind a DVD so just bring it back.");
                        dvdStart = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Yo, a number!");
                }
            }
        }
    }
}
