using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3Library;


namespace ConsoleApplicationTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            do
            {
                Console.WriteLine("Введите число a:");
            }
            while (!Int64.TryParse(Console.ReadLine(), out a));

            long b;
            do
            {
                Console.WriteLine("Введите число b:");
            }
            while (!Int64.TryParse(Console.ReadLine(), out b));
            long time;
            Console.WriteLine(Evklid.Gcd(a, b, out time));
            Console.WriteLine("Затраченное время на Gcd - " + time.ToString());
            Console.WriteLine(Evklid.BinaryGcd(a, b, out time));
            Console.WriteLine("Затраченное время на GcdBinary - " + time.ToString());
            Console.WriteLine(Evklid.GcdMany(out time, 150586, 4548595, 90012522, 7525482, -5, 1055842554, 15025485));
            Console.WriteLine("Затраченное время на GcdMany - " + time.ToString());
            Console.ReadLine();
        }
    }
}
