using System;
using System.Linq;

namespace Variant4EmVlad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - proverka na palindrom\n2 - matrica\n3 - sortirovka stroki");
            string valik = Console.ReadLine();
            if (int.Parse(valik)==1)
            {
                ProverkaNaPalindrom.proverka();
            }
            else if (int.Parse(valik)==2)
            {
                ProverkaNaPalindrom.matrica();

            }
            else if (int.Parse(valik)==3)
            {
                ProverkaNaPalindrom.strinsort();
            }

        }
    }
}
