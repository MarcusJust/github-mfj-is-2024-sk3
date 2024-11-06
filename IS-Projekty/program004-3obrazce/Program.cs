﻿string again = "a";
        while(again == "a") {

            Console.Clear();
            Console.WriteLine("**************************");
            Console.WriteLine("****** Kreslení obrazců **");
            Console.WriteLine("****** Marcus Just *******");
            Console.WriteLine("**************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Vyberte obrazec pro vykreslení (výběr provedete zapsáním čísla): 1 - 'Z'; 2 - Přesýpací hodiny; 3 - '#'");


            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Neplatná volba. Zadejte číslo mezi 1 a 3.");
            }
            Console.WriteLine("Nyní se vás zeptám na šířku a výšku. Zadejte vždy celé kladné číslo které je větší než 3. Zároveň nejlepšího vykreslení dosáhnete zadáním dvakrát stejného čísla.");
            Console.Write("Zadejte šířku obrazce: ");
            uint width;
            while (!uint.TryParse(Console.ReadLine(), out width) || width < 3)
            {
                Console.Write("Nezadali jste kladné celé číslo nebo je šířka příliš malá. Zadejte šířku znovu: ");
            }

            Console.Write("Zadejte výšku obrazce: ");
            uint height;
            while (!uint.TryParse(Console.ReadLine(), out height) || height < 3)
            {
                Console.Write("Nezadali jste kladné celé číslo nebo je výška příliš malá. Zadejte výšku znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("========================================================");
            Console.WriteLine("Zadané hodnoty: ");
            Console.WriteLine("Šířka: {0}", width);
            Console.WriteLine("Výška: {0}", height);
            Console.WriteLine("========================================================");

            switch (choice)
            {
                case 1:
                    DrawZ(width, height);
                    break;
                case 2:
                    DrawHourglass(width, height);
                    break;
                case 3:
                    DrawHashtag(width, height);
                    break;
                default:
                    Console.WriteLine("Neplatná volba.");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Program můžete opakovat stiskem klávesy 'a'");
            again = Console.ReadLine(); 
        }

        static void DrawZ(uint width, uint height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1 || j == width - i - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }

        static void DrawHourglass(uint width, uint height)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i <= height / 2)
                    {
                        if (j >= i && j < width - i)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                    else
                    {
                        if (j >= height - i - 1 && j <= i)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void DrawHashtag(uint width, uint height)
        {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (i == height / 3 || i == (2 * height) / 3 || j == width / 3 || j == (2 * width) / 3)
                    Console.Write("* ");
                else
                    Console.Write("  ");
            }
            Console.WriteLine();
        }
    }  