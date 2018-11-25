using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Console.WriteLine(car1.Getinfo());
            Console.WriteLine("\n=========speed input=================");
            Console.WriteLine("please enter speed:");
            car1.CarSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"your current speed is:{car1.CarSpeed}kph");
            Console.WriteLine("\n==============car deaccelaration========================");
            car1.CarSpeed = car1.CarSpeed - 2;
            Console.WriteLine($"your current speed after deaccelaration is:{car1.CarSpeed}kph");

            Console.WriteLine("\n==================car stopped=====================================");
            car1.Stop = true;
            Console.WriteLine($"car has come to a stop!");
            car1.CarSpeed = 0;
            car1.Deacceleration = 0;
            Console.WriteLine("car info after stop:\n");
            Console.WriteLine(car1.Getinfo());


        }
    }
}
