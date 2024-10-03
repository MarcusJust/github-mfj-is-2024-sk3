using System;
using System.Security.Cryptography.X509Certificates;

class Program {
    static void Main() {
        Console.Clear();
        Console.WriteLine("**************************");
        Console.WriteLine("****Výpis číselné řady****");
        Console.WriteLine("************Just**********");
        Console.WriteLine("**************************");
        //Vstup od uživatele
        // Console.Write("Zadejte první číslo: ");
        // int first = int.Parse(Console.ReadLine());
        // Console.Write("Zadejte poslední číslo: ");
        // int last = int.Parse(Console.ReadLine());
        // Console.Write("Zadejte po kolika chcete skákat: ");
        // int step = int.Parse(Console.ReadLine());

        //Vstup od uživatele lépe řešený
        Console.Write("Zadejte první číslo: ");
        int first;
        while(!int.TryParse(Console.ReadLine(), out first)){
            Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
        };
        Console.Write("Zadejte poslední číslo: ");
        int last;
        while(!int.TryParse(Console.ReadLine(), out last)){
            Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
        };
        Console.Write("Zadejte po kolika chcete skákat: ");
        int step;
        while(!int.TryParse(Console.ReadLine(), out step)){
            Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
        };
        
        while(first < last){
            first = first + step;
            Console.WriteLine(first);
        }

        Console.ReadKey();
    }
};