using System;
using System.Collections.Generic;
using System.Text;

namespace TurnipConsoleApp
{
    class Hero
    {
        public string Name { get; set; } = "Некто";
        public void Action()
        {
            Console.WriteLine("Стоит и смотрит");
        }
    }
}
