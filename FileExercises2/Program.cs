using System;
using System.IO;

namespace FileExercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2-Write a program that reads a text file and displays the longest word in the file.
            //Podria haber hecho una clase para manejo de texto y utilizar dos metodos de la misma para el ejercicio1.
            //Pero me gusta tener cada ejercicio separado en mi repo.
            var currentDir = Directory.GetCurrentDirectory();
            var textFile = currentDir + @"/texto.txt";
            string palabraMasLarga = DevolverMaximaPalabra(textFile);
            Console.WriteLine("La palabra mas larga es: {0}. Su cantidad de caracteres es: {1}", palabraMasLarga, palabraMasLarga.Length);
        }

        public static string DevolverMaximaPalabra(string FilePath = "")
        {

            if (!File.Exists(FilePath))
            {
                return "ERROR:EL ARCHIVO NO EXISTE";
            }
            else
            {
                var TextoCompleto = File.ReadAllText(FilePath);
                var ArregloTexto = TextoCompleto.Split(" ");
                int max = ArregloTexto[0].Length;
                int index = 0;
                for(int i = 1; i < ArregloTexto.Length; i++)
                {
                    if (ArregloTexto[i].Length > max)
                    {
                        max = ArregloTexto[i].Length;
                        index = i;
                    }
                }
                return ArregloTexto[index];
            }

        }
    }
}
