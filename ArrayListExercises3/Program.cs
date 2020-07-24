using System;
using System.Linq.Expressions;

namespace ArrayListExercises3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //3-Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an
            //error message and ask the user to re-try. Once the user succesfully enters 5 unique numbers, sort them and display the result on the console.
             
            int[] arrayNumber = new int[5];
            int num = 0;
            int i = 0;
            int j = 5;
            
            do
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Ingrese un numero(quedan {0} ingresos):", j);
                        num = Convert.ToInt32(Console.ReadLine());
                        
                        if((Array.IndexOf(arrayNumber, num)) == -1)
                        {
                            arrayNumber[i] = num;
                            i++;
                            j--;
                            break;
                        }
                    }
                    catch( SystemException e)
                    {
                        Console.WriteLine("Ha ingresado un valor incorrecto:");
                        continue;
                    }
                    
                }
                
            }
            while (i < 5);

            if(arrayNumber.Length > 0)
            {
                Array.Sort(arrayNumber);
                foreach(int Element in arrayNumber)
                {
                    Console.Write("[{0}]", Element);
                }
            }

        }
    }


}
