using System;

namespace _05.Fox
{
    class Fox
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var star = 1;
            var underscore = n * 2 - 1;
            var starMiddle = n;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('*', star));
                Console.Write("\\");
                Console.Write(new string('-', underscore));
                Console.Write("/");
                Console.WriteLine(new string('*', star));

                star++;
                underscore -= 2;
            }

            star = n / 2;

            for (int i = 1; i <= n / 3; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', star));
                Console.Write("\\");
                Console.Write(new string('*', starMiddle));
                Console.Write("/");
                Console.Write(new string('*', star));
                Console.WriteLine("|");

                star++;
                starMiddle-= 2;
            }

            underscore = 1;
            star = n * 2 - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', underscore));
                Console.Write("\\");
                Console.Write(new string('*', star));
                Console.Write("/");
                Console.WriteLine(new string('-', underscore));

                underscore++;
                star -= 2;
            }
        }
    }
}
