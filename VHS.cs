using System;
using System.Collections.Generic;

namespace BlockbusterLab
{
    public class VHS :Movie
    {
        //property called CurrentTime

        public int CurrentTime { get; set; }

        //constructor : base

        public VHS() { }
        public VHS(string Title, Genre Category, int RunTime, List <string> Scenes, int CurrentTime) : base(Title, Category, RunTime, Scenes) { }

        public override void Play()
        {
            Console.WriteLine(Scenes[CurrentTime]);
            CurrentTime++;

        }

        //method called Play() that plays the scene at the current time and then increments CurrentTime
        //a method called Rewind() that retruns nothing and sets CurrentTime to 0
    }
}
