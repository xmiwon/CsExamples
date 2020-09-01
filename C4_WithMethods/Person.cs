using System;
using System.Collections.Generic;
using System.Text;

namespace C4_WithMethods
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }


        //Methods / functions
        public void AskForName()
        {
            Console.WriteLine("Welcome dude! what's your name?");
            //vissa behöver skrivas this.Name för att referera till classen
            Name = Console.ReadLine();

            Console.Write($"{Name} Sweet :) How old are you?");
        }

        public void AskForAge()
        {
            try
            {
                Age = Convert.ToInt32(Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("Sorry dude! Your age must be in digits. Try again");
                Console.Write("How old are you man?");

                try
                {
                    Age = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Dude you are dumb");
                }
            }
            finally
            {
                Console.WriteLine($"Oh cool man! We are the same age. I am also {Age}.");
            }
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
    }
}
