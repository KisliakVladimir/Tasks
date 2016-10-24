using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2Library;


namespace ConsoleTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите чило A возводимое, которое нужно возвести в степень:");
            double A;
            if (!Double.TryParse(Console.ReadLine(), out A))
            {
                do
                {
                    Console.WriteLine("Введите корректное значение doble для A");
                }
                while (!Double.TryParse(Console.ReadLine(), out A));
             
            }
            double N;
            Console.WriteLine("Введите чило n (степень):");
            if (!Double.TryParse(Console.ReadLine(), out N))
            {
                do
                {
                    Console.WriteLine("Введите корректное значение doble для n");
                }
                while (!Double.TryParse(Console.ReadLine(), out N));

            }
            NewTon k = new NewTon(A, N);
            try
            {
                Console.WriteLine("А в степени n по методу Ньютона с погрешностью 0,0001 равно: " + k.SqrtN());
                Console.WriteLine("A в степени n по методу Pow библиотеки NET равно: " + k.Pow());
            }
            catch (OverflowException)
            {
                Console.WriteLine("Переменная переполнилась. Значение посчитано неверно. Обратитесь к администратору");
            }

           
            Console.WriteLine(k.CompairNewtonandPow(k.SqrtN(), k.Pow()));
            Console.WriteLine("Введите неотрицательное целое число:");


            try
            {
                Console.WriteLine(k.ToBinary(Console.ReadLine()));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
