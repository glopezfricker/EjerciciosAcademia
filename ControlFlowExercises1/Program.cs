using System;
using System.Runtime.InteropServices.ComTypes;

namespace ControlFlowExercises1
{
    class Program
    {
        static void Main(string[] args)
        {
        //- Write a program and ask the user to enter a number. The number should be between 1 to 10.If the user enters a valid number, display "Valid" on the console.Otherwise, display 
        //"Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
        Console.Write("Ingrese un numero:");
        string Input;
        int num = 0;

        while (true)
        {
            try
            {
                    Input = Console.ReadLine();
                    num = Convert.ToInt32(Input);
                break;
            }
            catch (SystemException e)
            {
                Console.WriteLine("El valor ingresado no es un numero");
                Console.Write("Ingrese un numero:");
            }
        }
        var Msg = ((num < 1) || (num > 10)) ? "Invalid" : "Valid";
        Console.WriteLine(Msg);

            
        }
    }
}
