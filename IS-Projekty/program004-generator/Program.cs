using System;
using System.Security.Cryptography;
class Program{
    static void Main(string[] args){
﻿      string again = "a";
        while(again == "a") {

            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine("**** Generátor pseudonáhodných čísel ****");
            Console.WriteLine("*************** Marcus Just *************");
            Console.WriteLine("*****************************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu (celé číslo): ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu (celé číslo): ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu (celé číslo): ");
            }



            
            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("========================================================\n\n");
            
            int[] myArray = new int[n];

            Random randomNumber = new Random();

            for(int i=0; i<n; i++){
              myArray[i] = randomNumber.Next(dm, hm+1);
              Console.Write("{0}; ", myArray[i]);  
            }

            int nulove = 0;
            int zaporne = 0;
            int kladne = 0;
            int sude = 0;
            int liche = 0;

            foreach(int number in myArray){
                if(number > 0){
                    kladne++;
                }
                 else if(number < 0){
                    zaporne++;
                }
                else{
                    nulove++;
                }
                if(number % 2 == 0){
                    sude++;
                }else{
                    liche++;
                }
            };

            Console.WriteLine();
            Console.WriteLine("Počet kladných čísel: {0}", kladne);
            Console.WriteLine("Počet záporných čísel: {0}", zaporne);
            Console.WriteLine("Počet nul: {0}", nulove);
            Console.WriteLine();
            Console.WriteLine("Počet sudých čísel: {0}", sude);
            Console.WriteLine("Počet lichých čísel: {0}", liche);

            


           
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }
    }
}