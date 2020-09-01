using System;
using System.Collections.Generic;
using System.Text;

namespace C5_WithAgeCalculation
{
    class Person
    {
        public string Name { get; private set; }

        //Samma sak som att ta bort set delen, men get stannar
        public int Age => CalculateAge();
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

        // utan void så ska metoden returneras värde
        private  int CalculateAge()
        {
            //Använder en privat variable i just den här kodblocket. Lokalt variabel
            // _variabel indikera att det är privat - best practice!
            int _age = DateTime.Now.Year - DateOfBirth.Year;
            //No curly braacket if there is only one line of code - short form
            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
                _age = _age - 1;
            return _age;

        }
    }
}
