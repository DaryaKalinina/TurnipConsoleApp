using System;
using System.Collections.Generic;
using System.Text;
using TurnipConsoleApp;

namespace Characters
{
    class Granny :Hero
    {
        public new string Name { get; set; } = "Бабка";
        public new void Action()
        {
            Console.WriteLine("Бабка пришла тянуть репку");

        }
    }
}
