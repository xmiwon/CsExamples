using System;

namespace C1__WriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //läsa allt som text eftersom \ är ett tecken. @ tar bara hand om \
            var path = @"c:\users\Gori\Documents\doc.txt";
            //ignorera citattecken för json
            var json = "{\"firstName\": \"Gori\", \"lastName\":\"Mori\"}";
            //fungerar men inte vid alla tillfällen.
            var json2 = "{'firstName': 'Gori', 'lastName':'Mori'}";
            

            string name = "Gori";
            int age = 20;
            var city = "Stockholm";
            

            var text1 = "Welcome Gori";
            var text2 = "Welcome " + name + ". You are " + age + " years old, right?";
            var text3 = String.Format("Welcome {0}. You are {1} years old, right? {0} do you live in {2}", name, age, city);
            var text4 = $"Welcome {name}. You are {age} years old. Do you live in {city}?";
            Console.WriteLine(text1);
            Console.WriteLine(text3); 

        }
    }
}