using System;

namespace ControlFlowExercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait.
            int ancho, largo;
            string input1, input2;
            while (true)
            {
                try
                {
                    Console.Write("Ingrese el largo de la imagen:");
                    input1 = Console.ReadLine();
                    largo = Convert.ToInt32(input1);

                    Console.Write("Ingrese el ancho de la imagen:");
                    input2 = Console.ReadLine();
                    ancho = Convert.ToInt32(input2);
                    break;
                }
                catch (SystemException e)
                {
                    Console.WriteLine("No ingreso un numero valido");
                }

            }

            if (largo > ancho)
            {
                Console.WriteLine("Es portrait");
            }
            else if (ancho > largo)
            {
                Console.WriteLine("Es landscape");

            }
            else
            {
                Console.WriteLine("Son iguales");
            }
        }
    }
}

