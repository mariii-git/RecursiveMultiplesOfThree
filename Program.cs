using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3
{
    internal class Program
    {
        static void PrintMultiplesOf3(int n)
        {
            if (n <= 0)
                return;
            PrintMultiplesOf3(n - 1);
            if (n % 3 == 0)
                Console.WriteLine(n);
            
        }
        static void Main(string[] args)
        {
            Console.Write("enter : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"مضرب های سه  کوچکتر از {n} : ");
            PrintMultiplesOf3(n - 1);
            
        }
    }
}
