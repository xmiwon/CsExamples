using System;
using System.Collections.Generic;
using System.Text;

namespace C6_GettersAndSetters
{
    class Person
    {
        public string Name { get; private set; }
        public int Age => CalculateAge();
        public string City { get; private set; }
        public DateTime DateOfBirth { get; private set; }


        public void AskForName()
        {
            Console.Write("Welcome Dude! What's your name? ");
            Name = Console.ReadLine();

            Console.Write($"{Name} sweeet :) ");
        }

        public void NameContains()
        {
            Console.WriteLine($"Dude your name contains {Name.Length} characters.");
        }

        public void AskForCity()
        {
            Console.Write($"{Name} where do you live? ");
            City = Console.ReadLine();

            Console.WriteLine($"Sweet! My brother lives in {City}");
        }

        public void AskForDateOfBirth()
        {
            Console.Write("When were you born? ");

            try
            {
                DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                Console.Write("Sorry dude, I mean when, like 1999-01-01. So when were you born? ");
                try
                {
                    DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("You are so stupid man.");
                }
            }

            Console.WriteLine($"Oh cool man! We are the same age. I am also {Age}");
        }

        private int CalculateAge()
        {
            int _age = DateTime.Now.Year - DateOfBirth.Year;

            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
                _age = _age - 1;

            return _age;
        }
    }
}