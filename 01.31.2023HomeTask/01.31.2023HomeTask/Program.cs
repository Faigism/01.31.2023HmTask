using System;

namespace _01._31._2023HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drink dr1= new Drink();
            dr1.Name = "Gaudio";
            dr1.Price = 100;
            dr1.AlcoholPercent = 12;

            Console.WriteLine("Drink: "+dr1.Price,dr1.AlcoholPercent);
        }
    }
}
