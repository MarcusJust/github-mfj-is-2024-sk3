using System;
using System.Security.Cryptography;
class Program{
    static void Main(string[] args){
﻿      string again = "a";
        while(again == "a") {

            Console.WriteLine("\n\nZadejte text pro analýtu: ");
            string myText = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(myText);
            Console.WriteLine(myText[0]);
            Console.WriteLine(myText.Length);
            Console.WriteLine(myText[myText.Length-1]);

            string samohlasky = "aáeéěiíoóuůúyý";
            string souhlasky = "qwrtzpsdfghjklxcvbnmřžčďť";
            string cislice = "0123456789";
            int pocetSouhlasek = 0;
            int pocetSamohlasek = 0;
            int pocetCislic = 0;
            int pocetOStatni = 0;

            foreach(char znak in myText){
                if(souhlasky.Contains(znak)){
                    pocetSouhlasek++;
                }else if(samohlasky.Contains(znak)){
                    pocetSamohlasek++;
                }else if(cislice.Contains(znak)) {
                    pocetCislic++;
                }else{
                    pocetOStatni++;
                }
            }
            Console.WriteLine("\n\nPocet samohlasek: {0}", pocetSamohlasek);
            Console.WriteLine("Pocet souhlasek: {0}", pocetSouhlasek);
            Console.WriteLine("Pocet číslic: {0}", pocetCislic);
            Console.WriteLine("Pocet ostatních znaků: {0}", pocetOStatni);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }
    }
}