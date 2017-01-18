using System;

namespace _04.SoftUniCamp
{
    class SoftUniCamp
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            double allCrew = 0;
            double crew5 = 0;
            double crew612 = 0;
            double crew1325 = 0;
            double crew2640 = 0;
            double crew41 = 0;
            double percent = 0;

            for (int i = 1; i <= n; i++)
            {
                var crew = double.Parse(Console.ReadLine());
                allCrew += crew;
                percent = allCrew / 100;

                if (crew <= 5)
                {
                    crew5 = crew5 + crew;
                }

                if (crew >=6 && crew <= 12)
                {
                    crew612 = crew612 + crew;
                }

                if (crew >= 13 && crew <= 25)
                {
                    crew1325 = crew1325 + crew;
                }

                if (crew >= 26 && crew <= 40)
                {
                    crew2640 = crew2640 + crew;
                }
                if (crew >= 41)
                {
                    crew41 = crew41 + crew;
                }
            }
            Console.WriteLine("{0:f2}%", Math.Round(crew5 / percent, 2));
            Console.WriteLine("{0:f2}%", Math.Round(crew612 / percent, 2));
            Console.WriteLine("{0:f2}%", Math.Round(crew1325 / percent, 2));
            Console.WriteLine("{0:f2}%", Math.Round(crew2640 / percent, 2));
            Console.WriteLine("{0:f2}%", Math.Round(crew41 / percent, 2));
        }
    }
}
