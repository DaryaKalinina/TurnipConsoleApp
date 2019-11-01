using System;
using System.Collections.Generic;
using System.Text;
using TurnipConsoleApp;

namespace Characters
{
    class Dog: Hero
    {
        public new string Name { get; set; } = "Жучка";
        public new void Action()
        {
            Console.WriteLine("Жучка пришла тянуть репку");

        }
    }
}
