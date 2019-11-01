using System;
using System.Collections.Generic;
using System.Text;
using TurnipConsoleApp;

namespace Characters
{
    class Granddaughter :Hero
    {
        public new string Name { get; set; } = "Внучка";
        public new void Action()
        {
            Console.WriteLine("Внучка пришла тянуть репку");

        }
    }
}
