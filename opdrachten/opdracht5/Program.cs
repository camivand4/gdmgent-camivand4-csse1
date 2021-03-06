﻿using System;
using System.Threading;

namespace les5
{
    class Program
    {
        static void Main(string[] args)
        {
            SchrijfLog("Som: " + Som(3,3));
            SchrijfLog("Verschil: " + Verschil(3,3));
            SchrijfLog("Quotiënt: " + Quotient(3,3));
            SchrijfLog("Product: " + Product(3,3));

            SchrijfLog("Modulo: " + Modulo(3,3));

            SchrijfLog("Verhogen: " + Verhogen(3));
            SchrijfLog("Verlagen: " + Verlagen(3));

            SchrijfLog("GenereerWillekeurigGetal: " + GenereerWillekeurigGetal());
            SchrijfLog("GenereerWillekeurigGetalTussenWaarden" + GenereerWillekeurigGetalTussenWaarden(0, 80));

            Lotto();
            Euromillions();
            Usermail();
            faculteit();
            fibonacci();
        }

        // product
        static int Product(int getal1, int getal2){
            return getal1 * getal2;
        }

        // som
        static int Som(int getal1, int getal2){
            return getal1 * getal2;
        }

        // verschil
        static int Verschil(int getal1, int getal2){
            return getal1 * getal2;
        }

        // modulo
        static int Modulo(int getal1, int getal2){
            return getal1 % getal2;
        }

        // quotient
        static int Quotient(int getal1, int getal2){
            return getal1 * getal2;
        }

        // verhogen
        static int Verhogen(int getal1){
            // SchrijfLog("verhogen...");
            return ++getal1;
        }
        
        // verlagen
        static int Verlagen(int getal1){
            return getal1++;
        }

        static void SchrijfLog(int output) => Console.WriteLine(output.ToString());

        static void SchrijfLog(string output) => Console.WriteLine(output);

        // genereer willekeurig getal
        static int GenereerWillekeurigGetal(){
            Random r = new Random();
            return r.Next();
        }

        // genereer willekeurig getal met opgegeven bereik
        static int GenereerWillekeurigGetalTussenWaarden(int min, int max){
            Random r = new Random();
            return r.Next(min,max);
        }

        static void Lotto() {
            SchrijfLog("lottotrekking");
            for (int i = 0; i < 6; i++)
            {
                SchrijfLog(GenereerWillekeurigGetalTussenWaarden(1,45));
                //thread zorgt voor de vertraging
                Thread.Sleep(2000);
            }
        }

        static void Euromillions() {
            SchrijfLog("Euromillions");
            for (int i = 0; i < 5; i++)
            {
                SchrijfLog(GenereerWillekeurigGetalTussenWaarden(1,50));
                //thread zorgt voor de vertraging
                Thread.Sleep(5000);
            }
            SchrijfLog("sterren");

            for (int i = 0; i < 2; i++)
            {
                SchrijfLog(GenereerWillekeurigGetalTussenWaarden(1,12));
                //thread zorgt voor de vertraging
                Thread.Sleep(2000);
            }
        }

        static void Usermail() {
            Console.WriteLine("student of docent?");
			string docentOfStudent = Console.ReadLine().Replace(" ", "");
			Console.WriteLine("geef je voornaam in");
			string voornaamInput = Console.ReadLine().Replace(" ", "");
			Console.WriteLine("geef je achternaam in");
			string achternaamInput = Console.ReadLine().Replace(" ", "");
			// string[] naam = {voornaamInput, achternaamInput};
			string mailStudent = "@student.arteveldehs.be";
			string mailDocent = "@arteveldehs.be";

			//This will give you first 4 characters.
			string subVoornaam = voornaamInput.Substring(0, 4);
			string subAchternaamStudent = achternaamInput.Substring(0, 4);
			string subAchternaamDocent = achternaamInput.Substring(0, 2);

			// .ToLower()
			if (docentOfStudent == "student")
			{
			string naam = subVoornaam+subAchternaamStudent+mailStudent;
			Console.WriteLine(naam.ToLower());
			} else {
			string naam = subVoornaam+subAchternaamDocent+mailDocent;
			Console.WriteLine(naam.ToLower());
			}
        }

        static void faculteit() {
            Console.WriteLine("Faculteit: Geef een getal in:");
            int getal = Convert.ToInt32(Console.ReadLine());

            int fac = getal;

            while(getal > 2) {
                getal--;
                fac *= getal;
            }

            Console.WriteLine(fac);
        }

        static void fibonacci() {
            Console.WriteLine("Fibonacci: Geef het aantal keer in:");
            int aantalKeer;
            aantalKeer = Convert.ToInt32(Console.ReadLine());
            // int aantalKeer = 5;
            int getal1 = 0;
            int getal2 = 1;
            int getal3;

                Console.WriteLine('\n');
            for (int i = 0; i < aantalKeer; i++)
            {
                getal3 = getal1 + getal2;
                Console.WriteLine(getal3+" ");
                getal1 = getal2;
                getal2 = getal3;
            }

        }
    }
}
