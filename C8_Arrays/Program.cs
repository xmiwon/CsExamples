using System;

namespace C8_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many siblings do you have?");
            var _numbersOfSiblings = Convert.ToInt32(Console.ReadLine());

            if (_numbersOfSiblings < 1)
            {
                Console.WriteLine("Okay, That's cool man.");               
            }
            else
                {
                    string[] siblings = new string[_numbersOfSiblings];

                    if (_numbersOfSiblings == 1)
                    {
                        Console.Write("What's your siblings' names? ");
                        siblings[0] = Console.ReadLine();
                    }
                    else
                    {
                        for (var i=0; i<_numbersOfSiblings; i++)
                        {
                            if (i == 0)
                                Console.Write("What's your first sibling's name? ");
                            else
                                Console.Write("And your next sibling's name? ");

                            siblings[i] = Console.ReadLine();

                        }
                    }
                

            if (_numbersOfSiblings == 1)
                Console.Write("So correct me if I am wrong. Your sibling is ");
            else
                Console.Write("So correct me if I am wrong. Your siblings are ");

            foreach (var sibling in siblings)
            {
                Console.Write($"{sibling} ");

            }
          }


        }
    }
}
