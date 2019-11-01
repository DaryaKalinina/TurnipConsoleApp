using System;
using System.Collections.Generic;
using System.Text;
using TurnipConsoleApp;

namespace Characters
{
    class Cat : Hero
    {
        public new string Name { get; set; } = "Кошка";
        public new void Action()
        {
            Console.WriteLine("Кошка пришла тянуть репку");

        }
    }
}
