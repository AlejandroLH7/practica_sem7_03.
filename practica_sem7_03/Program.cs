using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_sem7_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Años bisiestos desde 1900:");
            for (int i = 1900; i <= 2023; i++)
            {
                if (i % 4 == 0 && i % 100 != 0) 
                {
                    Console.WriteLine(i);
                }
                if (i % 400 == 0) 
                {
                    Console.WriteLine(i);
                    Console.ReadKey();
                }
            }
        }
    }
}
