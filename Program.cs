using System;
using System.Linq;

namespace Variant4EmVlad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - proverka na palindrom");
            string valik = Console.ReadLine();
            if (int.Parse(valik)==1)
            {
                ProverkaNaPalindrom.proverka();
            }

        }
    }
}
