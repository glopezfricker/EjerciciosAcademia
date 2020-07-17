using System;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace Ejercicio4_1
{
    class Program
    {
     
        static void Main(string[] args)
        {
            

            //4 - Your job is to write a program for a speed camera.For simplicity, ignore the details such as camera, sensors, 
            //    etc and focus purely on the logic.Write a program that asks the user to enter the speed limit.Once set, the program asks for the speed of a car.
            //        If the user enters a value less than the speed limit, program should display Ok on the console.If the value is above the speed limit, the program should calculate the number of demerit points.
            //        For every 5km / hr above the speed limit, 1 demerit points should be incurred and displayed on the console.If the number of demerit points is above 12, the program should display License Suspended.

            string inputLimite, inputVelocidad;
            int speedLimit = 0;
            int velocidad = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Ingrese limite de velocidad:");
                    inputLimite = Console.ReadLine();
                    speedLimit = Convert.ToInt32(inputLimite);
                    if(speedLimit > 120 || speedLimit < 30)
                    {
                        Console.WriteLine("Error.Solo se permiten valores entre 30 y 120");
                        continue;
                    } else {
                        break;
                    }
                }
                catch (SystemException e)
                {
                    Console.WriteLine("No ha ingresado un numero");
                }

            }

            while(true)
            {
                try 
                { 
                    Console.WriteLine("Ingrese Velocidad");
                    inputVelocidad = Console.ReadLine();
                    velocidad = Convert.ToInt32(inputVelocidad);
                    if (velocidad < 20 || velocidad > 240)
                    {
                        Console.WriteLine("Error.Solo se permiten velocidades entre 20 y 240");
                        continue;
                    } else
                    {

                        int res = CalcularDemeritos(speedLimit, velocidad);
                        Console.WriteLine(MensajeDemerito(res));
                        break;
                    }
                }
                catch (SystemException e)
                {
                    Console.WriteLine("No ha ingresado un numero");
                }

                {

                }
            }
        }

        public static int CalcularDemeritos(int limite, int velocidad)
        {
            int aux = velocidad - limite;

            if (aux <= 0)
            {
                return 0;
            }
            else
            {
                aux /= 5;
                return aux;
            }
        }

        public static string MensajeDemerito(int demerito)
        {
            if(demerito == 0)
            {
                return "OK";
            } else if( demerito > 12)
            {
                return "SUSPENDIDO";
            } else
            {
                return Convert.ToString(demerito);
            }
        }

    }
}
