using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var skumriaPrice = double.Parse(Console.ReadLine());
            var cacaPrice = double.Parse(Console.ReadLine());
            var palamudKg = double.Parse(Console.ReadLine());
            var safridKg = double.Parse(Console.ReadLine());
            var midiPrice = int.Parse(Console.ReadLine());

            var palamudPrice = skumriaPrice + (skumriaPrice * 0.6);
            var palamudFinal = palamudPrice * palamudKg;
            var safridPrice = cacaPrice + (cacaPrice * 0.8);
            var safridFinal = safridPrice * safridKg;
            var MidiFinal = midiPrice * 7.5;
            var moneyFinal = palamudFinal + safridFinal + MidiFinal;

            Console.WriteLine("{0:f2}", moneyFinal);
        }
    }
}
