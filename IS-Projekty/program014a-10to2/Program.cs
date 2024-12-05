﻿using System;
using System.Security.Cryptography;
class Program{
    static void Main(string[] args){
﻿      string again = "a";
        while(again == "a") {

            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine("**** Převod čísel mezi soustavami ****");
            Console.WriteLine("*************** Marcus Just *************");
            Console.WriteLine("*****************************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Zadejte číslo v desítkové soustavě pro převod: ");
            uint cislo;
            while(!int.TryParse(Console.ReadLine(), out cislo)) {
                Console.Write("Špatná vstup. Zadejte číslo v desítkové soustavě pro převod: ");
            }

            Console.WriteLine();
            Console.WriteLine("================================================");
            Console.WriteLine("==============Zadané číslo je: {0}==============", cislo);
            Console.WriteLine("================================================");

            uint[] myArray = new uint[32];
            uint zaloha = cislo;
            uint zbytek;

            uint i = 0;
            while(cislo > 0){
                zbytek = cislo % 2;
                cislo = (cislo - zbytek) / 2;
                myArray[i] = zbytek;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Celá čáast = {0}, zbytek = {1}", cislo, myArray[i]); 
                i++;
            };

            Console.WriteLine("\n \nPoslední použitá buňka pole: {0}", i-1);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n Číslo {0} převedené do binární sozustavy: ", zaloha);
            for(uint j = i-1; j > 0 ; j--){
                Console.Write("{0}", myArray[1]);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }
    }
}