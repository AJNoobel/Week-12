using System;
using System.IO;
namespace ChuckNorrisJokeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of jokes");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            GetJokes(userNumber);
        }

        public static void GetJokes(int jokesNumber)
        {
            string filePath = @"C:\Users\opilane\samples\Chuck.txt";
            string[] JokesAboutChuck = File.ReadAllLines(filePath);
            if( jokesNumber > JokesAboutChuck.Length)
            {
                jokesNumber = JokesAboutChuck.Length;
            }




            for(int i = 0; i < jokesNumber; i++)
            {
                Console.WriteLine(JokesAboutChuck[i]);
            }




        }






    }
}
