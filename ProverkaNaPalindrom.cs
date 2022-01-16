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
            int counterplus = 0;
            int counterminus = 0;
            int counterzero = 0;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    x = randomiser.Next(-100, 100);
                    matrica[i, j] = x;
                    if (x<0)
                    {
                        counterminus++;
                    }
                    else if (x>0)
                    {
                        counterplus++;
                    }
                    else if (x==0)
                    {
                        counterzero++;
                    }
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
                Console.WriteLine("Koli4estvo otricatelnqh elementov v matrice: "+counterminus);
                Console.WriteLine("Koli4estvo polozhitelnqh elemntov v matrice: "+counterplus);
                Console.WriteLine("Koli4estvo nulevqh elemntov v matrice: " + counterzero);
                Console.ReadKey();
        }
        public static void strinsort()
        {
            Console.WriteLine("Vvedit proizvolnyjy stroky:   ");
            var a = Console.ReadLine();
            char[] ar = a.ToCharArray();
            Console.WriteLine("Vvedennaja stroka:   ");
            Console.WriteLine(ar);
            Array.Sort(ar);
            Console.WriteLine("Vvedennaja stroka otsortirovannaja po kody:   ");
            Console.WriteLine(ar);
            Array.Reverse(ar);
            Console.WriteLine("Otsortirovannaja i razvernytaja stroka:   ");
            Console.WriteLine(ar);
        }
    }
}
  

