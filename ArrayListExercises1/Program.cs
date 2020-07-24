using System;
using System.Collections.Generic;
using System.Transactions;

namespace ArrayListExercises1
{
    class Program
    {
        static void Main(string[] args)
        {
           //Write a program and continuosly ask the user to enter different names, until the user presses
           //Enter...
            
            List<string> friends = new List<string>();
            string input = "";
            
            Console.WriteLine("Ingrese nombre:");
            input = Console.ReadLine();
            
            while (!String.IsNullOrWhiteSpace(input)){
                friends.Add(input);
                Console.WriteLine("Ingrese nombre:");
                input = Console.ReadLine();
            };

            int cantidad = friends.Count;

            if(cantidad > 0)
            {
                //Aprovechamos y ejercitamos switch.Evitamos asi anidar tantos if...
                switch(cantidad)
                {
                    case 1:
                        {
                            Console.WriteLine("{0} likes your post.", friends[0]);
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("{0} and {1} likes your post.", friends[0], friends[1]);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("{0},{1} and {2} others likes your post.", friends[0], friends[1], cantidad - 2);
                            break;
                        }

                }
            }

            
        }
    }
}
