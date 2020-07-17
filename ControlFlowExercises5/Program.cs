using System;

namespace ControlFlowExercises5
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.
            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    res++;
                }
            }
            Console.WriteLine(res);
        }
    }
}
