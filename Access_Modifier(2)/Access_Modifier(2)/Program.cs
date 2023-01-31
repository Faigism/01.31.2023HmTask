using System;

namespace Access_Modifier_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student()
            {
                Age = 14,
                Fullname = "Faiq Ismayilov",
            };
            Console.WriteLine(st1.Age);
            
        }
    }
}
