using System;
using System.Collections.Generic;
using System.Text;

namespace C7_GettersAndSettersV2
{
    class Person
    {
        public string Name { get; private set; }
        public int Age
        {
            get 
            {
                int _age = DateTime.Now.Year - DateOfBirth.Year;

                if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
                    _age = _age - 1;
                return _age;
            } 
            
        }
        public string City { get; private set; }
        public DateTime DateOfBirth { get; private set; }



        //Methods / functions
        public void AskForName()
        {
            Console.WriteLine("Welcome dude! what's your name?");
            //vissa behöver skrivas this.Name för att referera till classen
            Name = Console.ReadLine();

            Console.Write($"{Name} Sweet :) How old are you?");
        }

        public void NameContains()
        {
            Console.Write($"Dude your name contains {Name.Length} characters.");
        }

        public void AskForCity()
        {
            Console.Write($"{Name} where do you live?");
            City = Console.ReadLine();
            Console.WriteLine($"Sweet! My brother lives in {City}");
        }

        public void AskForDateOfBirth()
        {
            Console.Write("When were you born?");

            try
            {
                DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                Console.Write("Sorry dude, I mean when, like 1999-01-01. So when were you born?");

                try
                {
                    DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("You are so stupid");

                }
            }
            Console.WriteLine($"Oh Cool! We are the same age. I am also {CalculateAge()}");
        }

     
       
    }
}
