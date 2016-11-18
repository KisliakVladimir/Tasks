using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4;

namespace ConsoleTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle T1 = new Triangle(0, 0, 1, 1, 0, 1);
            
            Console.WriteLine(T1.IsAlive());
            Console.WriteLine(T1.Square());
            Console.WriteLine(T1.Perimetr());
            T1.X1 = 10;
            Console.WriteLine(T1.IsAlive());
            Console.WriteLine(T1.Square());
            Console.WriteLine(T1.Perimetr());
            Console.ReadLine();
        }
    }
}
