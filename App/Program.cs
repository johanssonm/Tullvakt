using System;

namespace Tullvakt
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var car = new Car();
            car.enviromentFriendly = true;
            car.weight = 1001;

            var datetime = new DateTime(2018, 05, 26, 18, 11, 12);


            Console.WriteLine(Toll.CalculateFee(car, datetime));


            Console.ReadKey();
        }
    }
}
