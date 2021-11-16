using System;
using System.IO;
namespace FruitAnd_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitPath = @"C:\Users\opilane\samples\fruit.txt";
            string[] veggieData = File.ReadAllLines(fruitPath);

            string veggiePath = @"C:\Users\opilane\samples\veggie.txt";
            string[] fruitData = File.ReadAllLines(veggiePath);

            File.WriteAllLines(fruitPath, fruitData);
            File.WriteAllLines(veggiePath, veggieData);
        }
    }
}
