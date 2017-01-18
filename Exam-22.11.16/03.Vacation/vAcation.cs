using System;

namespace _03.Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            var oldPeople = int.Parse(Console.ReadLine());
            var youngPeople = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();
            double totalPriceTransport = 0;
            double hotelTotal = nights * 82.99;
            double commision = 0;
            double total = 0;

            if (transport == "train" && youngPeople + oldPeople >=1 && youngPeople + oldPeople <= 49)
            {
                totalPriceTransport = (((oldPeople * 24.99) + (youngPeople * 14.99)) * 2);
                commision = (totalPriceTransport + hotelTotal) * 0.1;
                total = totalPriceTransport + hotelTotal + commision;
            }

            if (transport == "train" && youngPeople + oldPeople >= 50)
            {
                totalPriceTransport = (((oldPeople * 24.99) + (youngPeople * 14.99)) * 2) / 2;
                commision = (totalPriceTransport + hotelTotal) * 0.1;
                total = totalPriceTransport + hotelTotal + commision;
            }

            if (transport == "bus")
            {
                totalPriceTransport = (((oldPeople * 32.50) + (youngPeople * 28.50)) * 2);
                commision = (totalPriceTransport + hotelTotal) * 0.1;
                total = totalPriceTransport + hotelTotal + commision;
            }

            if (transport == "boat")
            {
                totalPriceTransport = (((oldPeople * 42.99) + (youngPeople * 39.99)) * 2);
                commision = (totalPriceTransport + hotelTotal) * 0.1;
                total = totalPriceTransport + hotelTotal + commision;
            }

            if (transport == "airplane")
            {
                totalPriceTransport = (((oldPeople * 70.00) + (youngPeople * 50.00)) * 2);
                commision = (totalPriceTransport + hotelTotal) * 0.1;
                total = totalPriceTransport + hotelTotal + commision;
            }

            Console.WriteLine(Math.Round(total, 2));
        }
    }
}
