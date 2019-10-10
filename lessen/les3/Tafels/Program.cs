using System;

namespace Tafels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je getal in:");
            int getal1;
            getal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geef het 2de getal in:");
            int getal2;
            getal2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < getal2+1; i++)
            {
                Console.WriteLine(getal1 + " * " + i + " = " + getal1*i);
            }

        }
    }
}
