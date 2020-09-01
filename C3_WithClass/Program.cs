using System;

namespace C3_WithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            
                //deklarera variabler så nära som där du ska använda annars tar det upp ram minnet i onödan
               
               

                Console.WriteLine("Welcome dude! what's your name?");
                person.Name = Console.ReadLine();

                Console.Write($"{person.Name} Sweet :) How old are you man?");



                try
                {
                    person.Age = Convert.ToInt32(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine("Sorry dude! Your age must be in digits. Try again");
                    Console.Write("How old are you man?");

                    try
                    {
                        person.Age = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Dude you are dumb");
                    }
                }
                finally
                {
                    Console.WriteLine($"Oh cool man! We are the same age. I am also {person.Age}.");
                }

                Console.Write($"Dude your name contains {person.Name.Length} characters.");
                Console.Write($"{person.Name} where do you live?");
                person.City = Console.ReadLine();

                Console.WriteLine($"Sweet! My brother lives in {person.City}");
            
        }
    }
}
