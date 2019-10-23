using System;

namespace opdracht4
{
    class Program
    {
        static public void Main() 
        {
            // double nummer1= 8; 
            // double nummer2 = 3;

            double rekenmachine(double nummer1, double nummer2) 
            {

                // double optellen;
                // double aftrekken;
                // double delen;
                // double vermenigvuldigen;

                double optellen = nummer1 + nummer2;
                double aftrekken = nummer1 - nummer2;
                double delen = nummer1 / nummer2;
                double vermenigvuldigen = nummer1 * nummer2;

                Console.WriteLine(nummer1 + " * " + nummer2 + " = " + vermenigvuldigen);
                Console.WriteLine(nummer1 + " / " + nummer2 + " = " + delen);
                Console.WriteLine(nummer1 + " + " + nummer2 + " = " + optellen);
                Console.WriteLine(nummer1 + " - " + nummer2 + " = " + aftrekken);

                return optellen + aftrekken + delen + vermenigvuldigen;
            }
                rekenmachine(8, 3);        
        }
    }
}