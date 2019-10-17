using System;

namespace les4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            // Factulteit.
            Console.WriteLine("Geef een getal in:");
            int getal = Convert.ToInt32(Console.ReadLine());
            program.Faculteit(getal);
            
            // Fibonacci.
            Console.WriteLine("Geef een eindgetal in:");
            int eindfib = Convert.ToInt32(Console.ReadLine());
            program.Fibonacci(eindfib);
        }

        void Fibonacci(int getal) {
            int g0 = 0;
            int g1 = 1;
            int next = 0;

            for(int i = 0; i < getal; i++) {
                if(i == 0) {
                    next = 0;
                } else if(i == 1) {
                    next = 1;
                } else {
                    next = g0 + g1;
                    g0 = g1;
                    g1 = next;
                }
                Console.WriteLine(next);
            }
        }

        void Faculteit(int getal) {
            int fac = getal;

            while(getal > 2) {
                getal--;
                fac *= getal;
            }

            Console.WriteLine(fac);
        }
    }
}
