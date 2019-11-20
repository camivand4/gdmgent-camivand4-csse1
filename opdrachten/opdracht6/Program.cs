using System;

namespace opdracht6
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon p1 = new Persoon("Bolle", "Jeauninne", 'v');
            p1.LogOutput();
            Gebruiker g1 = new Gebruiker("Van Leemhuyzen", "Eugène", 'm');
            g1.LogOutput();
            Student s1 = new Student("Verhulst", "Gert", 'm');
            s1.LogOutput();
            Docent d1 = new Docent("Ongeweten", "Samson", 'u');
            d1.LogOutput();
        }
    }
}
