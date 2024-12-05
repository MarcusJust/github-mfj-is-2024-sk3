string again = "a";
        while(again == "a") {

            Console.Clear();
            razitko();

            ulong a = ziskatCislo("Zadejte přirozené číslo a:");
            ulong b = ziskatCislo("Zadejte přirozené číslo b:");

            ulong nsd = vypocitatNsd(a, b);
            
            ulong nsn = vypocitatNsn(a, b, nsd);

            vypsatVysledky(a, b, nsd, nsn);
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine();    

        }

static void razitko(){
    Console.WriteLine("****************************");
    Console.WriteLine("**** Výpis číselné řady ****");
    Console.WriteLine("******* Marcus Just ********");
    Console.WriteLine("****************************");
    Console.WriteLine();
    Console.WriteLine();
};

static ulong ziskatCislo(string zprava){
    Console.Write(zprava);
    ulong cislo;
    while(!ulong.TryParse(Console.ReadLine(), out cislo)) {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo (celé číslo): ");
    }
    return cislo;
};

static ulong vypocitatNsd(ulong a, ulong b){
    while( a != b){
        if(a>b){
            a = a - b;
        }else{
            b = b - a; 
        };
    }
    return a;
};

static ulong vypocitatNsn(ulong a, ulong b, ulong nsd){
    return a * b / nsd;
}

static void vypsatVysledky(ulong a, ulong b, ulong nsd, ulong nsn){
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"NSD čísel {a} a {b} je {nsd}:");
    Console.WriteLine($"NSN čísel {a} a {b} je {nsn}:");
}