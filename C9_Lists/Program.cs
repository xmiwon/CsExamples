using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace C9_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            bool _hasSiblings;

            Console.Write("Do you have any siblings (yes/no)");
            var _siblingResponse = Console.ReadLine();

            switch(_siblingResponse.ToLower())
            {
                case "yes":
                    _hasSiblings = true;
                    break;
                case "no":
                    _hasSiblings = false;
                    break;
                default:
                    _hasSiblings = false;
                    break;
            }
            //om det är false
            if (!_hasSiblings)
                Console.WriteLine("Okay, that's cool man.");
            else
            {
                Console.Write("Sweet. How many siblings do you have? ");
                int _numberOfSibling = Convert.ToInt32(Console.ReadLine());

                var siblings = new List<string>();

                if (_numberOfSibling == 1)
                {
                    Console.Write("What is your siblings' name? ");
                    siblings.Add(Console.ReadLine());

                    Console.WriteLine($"Okay, so your siblings name is {siblings[0]}");
                }
                else
                {
                    Console.Write("What's your siblings names? Separate by comma(,)");
                    var _response = Console.ReadLine();

                    var names = _response.Replace(" ", "").Split(",");

                    foreach (var name in names)
                    {
                        siblings.Add(name);
                    }

                    Console.Write("Which of your siblings is the oldest one?");
                    var _oldest = Console.ReadLine();

                    var index = siblings.FindIndex(x => x.Contains(_oldest));
                    siblings.RemoveAt(index);
                    siblings.Insert(0, _oldest);

                    Console.Write($"Okay, so your siblings names are ");
                    foreach(var sibling in siblings)
                    {
                        Console.Write($"{sibling} ");

                    }
                }
                    
                

            }
        }
    }
}
// öva på metoder, klasser, skriva get/set, array, listor
// försök bygg en egen app
