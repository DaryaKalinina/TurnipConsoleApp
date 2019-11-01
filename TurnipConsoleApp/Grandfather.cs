using System;
using System.Collections.Generic;
using System.Text;
using TurnipConsoleApp;

namespace Characters
{
    class Grandfather : Hero
    {
        public new string Name { get; set; } = "Дед";
        public new void Action()
        {
            Console.WriteLine("Пришел тянуть репку");

        }
    }
}
