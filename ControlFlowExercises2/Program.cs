using System;

namespace ControlFlowExercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program which takes two numbers from the console and displays the maximum of the two.
            string input1, input2;
            int num1, num2;
            while (true)
            {
                try
                {
                    Console.Write("Ingrese el primer numero:");
                    input1 = Console.ReadLine();
                    num1 = Convert.ToInt32(input1);

                    Console.Write("Ingrese el segundo numero:");
                    input2 = Console.ReadLine();
                    num2 = Convert.ToInt32(input2);
                    break;
                }
                catch(SystemException e)
                {
                    Console.WriteLine("No ingreso un numero valido");
                }

            }
            
            if(num1 > num2)
            {
                Console.WriteLine(num1);
            } else if(num2 > num1){
                Console.WriteLine(num2);

            } else
            {
                Console.WriteLine("Son iguales");
            }
        }
    }
}
