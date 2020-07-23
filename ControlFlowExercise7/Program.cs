using System;
using System.Threading.Tasks.Dataflow;

namespace ControlFlowExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            //3- Write program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
            int number = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Ingrese un numero:");
                    number = Convert.ToInt32(Console.ReadLine());

                    if (number >= 0) {
                        int Result = Factorial(number);
                        Console.WriteLine("Resultado: {0}", Result);
                        break;
                    } else
                    {
                        Console.WriteLine("Solo valores mayores o iguales a cero.");
                        continue;
                    }
                }

                catch (SystemException e)
                {
                    Console.WriteLine("Valor Incorrecto. Solo ingrese numeros.");
                    continue;
                }
            }
        }

        public static int Factorial(int Number = 0)
        {
            int Aux = Number;
            int Result = Aux;
            while (Aux > 1)
            {
                Aux--;
                Result *= Aux;
            };

            return Result;
        }
    }
}
