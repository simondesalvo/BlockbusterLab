using System;
using System.Collections.Generic;

namespace BlockbusterLab
{
    public class VHS :Movie
    {


        public int CurrentTime { get; set; }



        public VHS() { }
        public VHS(string Title, Genre Category, int RunTime, List <string> Scenes, int CurrentTime) : base(Title, Category, RunTime, Scenes)
        {
            this.CurrentTime = CurrentTime;
            base.Title = Title;
            base.Category = Category;
            base.RunTime = RunTime;
            base.Scenes = Scenes;
        }

        public override void Play()
        {
            for (CurrentTime = 0; CurrentTime < Scenes.Count; CurrentTime++)
            {
                Console.WriteLine(Scenes[CurrentTime]);
            }
            Rewind();
        }

        public void Rewind()
        {
            Console.WriteLine("Would you like to be kind, rewind");
            string input = Console.ReadLine();
            input.ToLower();
            if (input == "y" || input == "yes")
            {
                CurrentTime = 0;
            }
            else
            {
                Console.WriteLine("Ouch. Mean");
            }
        }
    }
}
