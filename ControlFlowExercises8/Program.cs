using System;
using System.Threading.Tasks.Dataflow;

namespace ControlFlowExercises8
{
    class Program
    {
        static void Main(string[] args)
        {
            //4-WriteOnceBlock as Program that pickls a random number between 1 and 10. Give the user 4 chances the number. If the user
            //guesses the number, display "You won"; otherwise, display " You Lost".
            int guess = 0;
            int number = GenerarNumeroRandom();
            int cont = 4;
            do
            {
                while (true)
                {


                    try
                    {
                        Console.WriteLine("Adivine el numero:{0}", number);
                        guess = Convert.ToInt32(Console.ReadLine());
                        if ((guess > 0) && (guess <= 10))
                        {
                            if (number == guess)
                            {
                                Console.WriteLine("Felicitaciones!!!! Acerto el valor!!!");
                                cont = 0;
                                break;
                            }
                            else
                            {                                
                                Console.WriteLine("No es el valor. Le quedan {0} intentos.", cont - 1);
                            }
                            break;                            
                        }
                        else
                        {
                            Console.WriteLine("Debe ingresar un numero entre 1 y 10.");
                            continue;
                        }

                    }
                    catch
                    {
                        Console.WriteLine("No ingreso un valor correcto.");
                    }

                }
                cont--;
            }
            while ( cont > 0 );
        }

        public static int GenerarNumeroRandom()
        {
            var randomNumber = new Random(10);
            return randomNumber.Next(1, 10);
        }
    }
}
