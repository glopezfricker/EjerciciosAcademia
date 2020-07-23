using System;
using System.IO;

namespace FilesExercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-Write a program that reads a text file and displays the number of words.
            //Lo unico que no me gusta es que si hay una coma no cuenta como 2 palabras sino como 1 sola.
            var currentDir = Directory.GetCurrentDirectory();
            var textFile = currentDir + @"/texto.txt";
            int Total = ContarPalabras(textFile);

            if(Total < 0)
            {
                Console.WriteLine("El archivo no existe.");
            } else
            {
                Console.WriteLine("El total es: {0}", Total);
            }


        }

        public static int ContarPalabras(string FilePath = "") {
            
            if (!File.Exists(FilePath))
            {
                return -1;
            }
            else
            {
                var TextoCompleto = File.ReadAllText(FilePath);
                var ArregloTexto = TextoCompleto.Split(" ");
                return ArregloTexto.Length;
            }

        }
    }
}
