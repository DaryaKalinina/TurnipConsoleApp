using System;
using System.Collections.Generic;
using System.Text;
using TurnipConsoleApp;

namespace Characters
{
    class Mouse : Hero
    {
        public new string Name { get; set; } = "Мышка";
        public new void Action()
        {
            Console.WriteLine("Мышка пришла тянуть репку");

        }
    }
}
