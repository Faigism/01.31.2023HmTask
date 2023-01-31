using System;

namespace Task2Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vh = new Vehicle();
            vh.Drive(30);
            vh.Drive(10);
            vh.Drive(21);
            vh.Drive(25);
            vh.Drive(50);
            
            Console.WriteLine(vh.Mileage);

            Car car1= new Car(60);
            //car1.FuelCapacity= 50;
            car1.FuelFor1Km = 1;
            car1.AddFuel(20);
            car1.AddFuel(10);
            car1.FuelCapacity = 30;
            car1.Drive(3);
            car1.Drive(5);
            Console.WriteLine("Capacity: "+car1.FuelCapacity);
            Console.WriteLine("Current: "+car1.CurrentFuel);
            Console.WriteLine("Mileage: "+car1.Mileage);
        }
    }
}
