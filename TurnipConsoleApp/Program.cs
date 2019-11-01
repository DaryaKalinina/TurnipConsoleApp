using Characters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TurnipConsoleApp
{
    public class CheckLine
    {
        public enum Line
        {
            Grandfather = 1,
            Granny,
            Granddaughet,
            Dog,
            Cat,
            Mouse
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            List<string> LineOfCharacters = new List<string>();
            List<string> GetDataFromEnum = Enum.GetNames(typeof(CheckLine.Line)).ToList();
            Turnip turnip = new Turnip();
            
            do
            {
                Console.WriteLine("Кого зовем?");
                foreach (string character in GetDataFromEnum)
                    Console.WriteLine(character);
                string p = Console.ReadLine();
                AddHero(LineOfCharacters, GetDataFromEnum, p);
                CheckStateTurnip(GetDataFromEnum, LineOfCharacters, turnip);
            }
            while ((Console.ReadLine() != "exit"));

        }
        static void AddHero(List<string> LineOfCharacters, List<string> GetDataFromEnum, string p)
        {

            if (p == "Grandfather")
            {
                Grandfather grandfather = new Grandfather();
                if (CheckQueue(LineOfCharacters, p))
                {
                    Console.WriteLine(grandfather.Name);
                    grandfather.Action();
                    LineOfCharacters.Add("Grandfather");
                }
                else
                {
                    Console.WriteLine("Дед уже тянет");
                    return;
                }


            }
            else if (p == "Granny" )
            {
                if (CheckQueue(LineOfCharacters, p))
                {
                    Granny granny = new Granny();
                    granny.Action();
                    LineOfCharacters.Add("Granny");
                }

                else
                {
                    Console.WriteLine("Бабка уже тянет");
                    return;
                }
            }
            else if (p == "Granddaughet")
            {
                if (CheckQueue(LineOfCharacters, p))
                {
                    Granddaughter granddaughter = new Granddaughter();
                    Console.WriteLine(granddaughter.Name);
                    granddaughter.Action();
                    LineOfCharacters.Add("Granddaughet");
                }
                else
                {
                    Console.WriteLine("Внучка уже тянет");
                    return;
                }
            }
            else if (p == "Dog")
            {
                if (CheckQueue(LineOfCharacters, p))
                {
                    Dog dog = new Dog();
                    dog.Action();
                    LineOfCharacters.Add("Dog");
                }
                else
                {
                    Console.WriteLine("Жучка уже тянет");
                    return;
                }
            }
            else if (p == "Cat")
            {
                if (CheckQueue(LineOfCharacters, p))
                {
                    Cat cat = new Cat();
                    cat.Action();
                    LineOfCharacters.Add("Cat");
                }
                else
                {
                    Console.WriteLine("Кошка уже тянет");
                    return;
                }
            }
            else if (p == "Mouse")
            {
                if (CheckQueue(LineOfCharacters, p))
                {
                    Mouse mouse = new Mouse();
                    mouse.Action();
                    LineOfCharacters.Add("Mouse");
                }
                else
                {
                    Console.WriteLine("Мышка уже тянет");
                    return;
                }

            }
            else
            {
                Console.WriteLine("Точно не поможет");
                return;
            }

        }

        //Проверка можем ли мы вытащить репку
        static void CheckStateTurnip(List<string> GetDataFromEnum, List<string> LineOfCharacters, Turnip turnip)
        {

            foreach (string character in GetDataFromEnum)
                if (LineOfCharacters.Contains(character)) continue;
                else return; 
            turnip.State = true;
            turnip.GetStatus();
            Console.WriteLine("Ура");

        }
        //Проверка на то что такого элемента еще нет
        static bool CheckQueue(List<string> LineOfCharacters, string hero)
        {
            int counter = LineOfCharacters.Where(p => p== hero).Count();
            if (counter != 0)
            {
                return false;
            }
            else return true;
        }
    }
}



    
    