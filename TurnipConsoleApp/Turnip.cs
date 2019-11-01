using System;
using System.Collections.Generic;
using System.Text;

namespace TurnipConsoleApp
{
    class Turnip
    {
        protected string Name{ get;set;}
        public bool State { get; set; } = false;
        public void GetStatus()
        {
            if (State) Console.WriteLine($"{Name} Вытащили!");
            else Console.WriteLine($"{Name} Крепко сидит в земле!");

        }
        public Turnip()
        {
            Name = "Репка";
            State = false;
        }
        
    }
    
}
