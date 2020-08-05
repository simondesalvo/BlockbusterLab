using System;
using System.Collections.Generic;

namespace BlockbusterLab
{
    public class DVD : Movie
    {
        //void method called Play() w/ no parameters that prints list of scenes, asks user what scene they want,
        //prints out scene selection

        public DVD() { }
        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes):base(Title, Category, RunTime, Scenes) { }

        public override void Play()
        {
            PrintScenes();
            Console.WriteLine($"Please select which scene you would like, numbers 0 to {Scenes.Count}");

            try
            {
                string pick = Console.ReadLine();
                int num = int.Parse(pick);
                Console.WriteLine(Scenes[num]);
            }
            catch (Exception)
            {
                Console.WriteLine("Yo, a number!");
            }
        }
    }
}
