using System;

namespace C2_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarera variabler så nära som där du ska använda annars tar det upp ram minnet i onödan
            string name = String.Empty;
            int age = 0;

            Console.WriteLine("Welcome dude! what's your name?");
            name = Console.ReadLine();

            Console.Write($"{name} Sweet :) How old are you man?");
            


            try
            {
                age = Convert.ToInt32(Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("Sorry dude! Your age must be in digits. Try again");
                Console.Write("How old are you man?");
                
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Dude you are dumb");
                }
            }
            finally
            {
                Console.WriteLine($"Oh cool man! We are the same age. I am also {age}.");
            }
            
            Console.Write($"Dude your name contains{name.Length} characters.");
            Console.Write($"{name} where do you live?");
            var city = Console.ReadLine();

            Console.WriteLine($"Sweet! My brother lives in {city}");
        }
    }
}
