using System;

namespace ControlFlowExercises6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and continuously ask the user to enter a number or "ok" to exit. 
            //Calculate the sum of all the previously entered numbers and display it on the console.
            Console.WriteLine("Ingrese un numero (ok para terminar):");
            string input = Console.ReadLine();
            int sum = 0;
            while(input.ToLower() != "ok")
            {
                try
                {
                    sum += Convert.ToInt32(input);
                    Console.WriteLine("Ingrese un numero (ok para terminar):");
                    input = Console.ReadLine();
                }
                catch(SystemException e)
                {
                    Console.WriteLine("Valor incorrecto.Ingrese un numero (ok para terminar):");
                    input =Console.ReadLine();
                    continue;
                }
            }
            Console.WriteLine("Total:{0}", sum);
        }
    }
}
