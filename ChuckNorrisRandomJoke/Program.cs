using System;
using System.IO;
namespace ChuckNorrisRandomJoke
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filePath = @"C:\Users\opilane\samples\Chuck.txt";
            //string[] JokesAboutChuck = File.ReadAllLines(filePath);

            //Random rnd = new Random();
            //int randomIndex = rnd.Next(0, JokesAboutChuck.Length);
            //Console.WriteLine(JokesAboutChuck[randomIndex]);
            Console.WriteLine(GetRandomJoke());
        }

        public static string GetRandomJoke()
        {
            string filePath = @"C:\Users\opilane\samples\Chuck.txt";
            string[] JokesAboutChuck = File.ReadAllLines(filePath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, JokesAboutChuck.Length);


            return JokesAboutChuck[randomIndex];
        }
    }
}
