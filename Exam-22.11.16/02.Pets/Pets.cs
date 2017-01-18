using System;

namespace _02.Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var food = int.Parse(Console.ReadLine());
            var dogFood = double.Parse(Console.ReadLine());
            var catFood = double.Parse(Console.ReadLine());
            var turtleFood = double.Parse(Console.ReadLine());

            var dogNeed = days * dogFood;
            var catNeed = days * catFood;
            var turtleNeed = (days * turtleFood) / 1000;
            var totalFood = dogNeed + catNeed + turtleNeed;

            if (totalFood <= food)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(food - totalFood));
            }

            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(totalFood - food));
            }
        }
    }
}
