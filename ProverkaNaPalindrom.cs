using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Variant4EmVlad
{
    public class ProverkaNaPalindrom
    {
        public static void proverka()
        {
            Console.WriteLine("Vvedite proizvolniy tekst:  ");
            string a = Console.ReadLine();
            a = a.Replace(" ", "").ToLower();
            Console.WriteLine(a);
            var b = new string(a.Reverse().ToArray());
            if (a == b)
            {
                Console.WriteLine("Eto palindrom!");
            }
            else
            {
                Console.WriteLine("Eto ne palindrom!");
            }
            Console.ReadLine();
        }
        public static void matrica()
        {
            Console.WriteLine("Vvedite razmer kvadratnoi matricq:");
            int r = int.Parse(Console.ReadLine());
            int[,] matrica = new int[r, r];
            Random randomiser = new Random();
            int x;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    x = randomiser.Next(0, 100);
                    matrica[i, j] = x;
                }
            }
                for (int e = 0; e < r; e++)
                {
                    for (int j = 0; j < r; j++)
                    {
                        Console.Write(matrica[e, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.ReadKey();
        }
    }
}
  

