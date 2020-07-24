using System;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace ArrayListExercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string.
             * Display the reversed name on the console.
             */
            Console.WriteLine("Ingrese su nombre:");
            String nombre = Console.ReadLine();
            String nombreReves = Reverse(nombre);

            Console.WriteLine(nombreReves);

        }

        public static string Reverse(string cadena)
        {
            if (cadena.Length > 0)
            {
                char[] nombreArray = cadena.ToCharArray();
                Array.Reverse(nombreArray);
                return new string(nombreArray);
            } else {
                return "";
              };
        }
    }
}
