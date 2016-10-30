using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Library
{/// <summary>
/// Класс позволяющий рассчитать корень n-ой степени из числа методом Ньютона с заданной точностью. В классе есть свойства
/// double A - само число, double N - степень, Eps - точность.
/// </summary>
    public class NewTon
    {
        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        private double n;

        public double N
        {
            get { return n; }
            set { n = value; }
        }
        private double eps;

        public double Eps
        {
            get { return eps; }
            set { eps = value; }
        }
        public uint Number { get; set; }
        /// <summary>
        /// Конструктор инициилизирующий поля a - число, n - степень, eps - задается по умолчанию в конструкторе 0,0001
        /// </summary>
        /// <param name="a">передается в параметре конструктора для указания числа</param>
        /// <param name="n">передается в параметре конструктора для указания степени</param>
        public NewTon (double a, double n)
        {
            this.A = a;
            this.N = n;
            this.Eps = 0.0001;
        }
        /// <summary>
        /// Метод Ньютона, который возвращает значение double
        /// </summary>
        /// <returns>возвращает double x1 </returns>
        public double SqrtN()
        {
            double x1=0;
            try
            {
                checked
                {
                    var x0 = A / N;
                    x1 = (1 / N) * ((N - 1) * x0 + A / Math.Pow(x0, (int)N - 1));

                    while (Math.Abs(x1 - x0) > Eps)
                    {
                        x0 = x1;
                        x1 = (1 / N) * ((N - 1) * x0 + A / Math.Pow(x0, (int)N - 1));
                    }
                    return x1;
                }
            }
            catch(OverflowException)
            {
               
            }
            return x1;
        }
/// <summary>
/// Альтернативный метод Pow
/// </summary>
/// <returns></returns>
        public double Pow()
        {
            return Math.Pow(A, N);
        }
        /// <summary>
        /// Сравниваем значение полученное методом Ньютона и методом Pow и возвращаем string "newton > pow" или return "newton < pow"
        /// </summary>
        /// <param name="newton">значение полученное методом Ньютона</param>
        /// <param name="pow">значение полученное методом Pow</param>
        /// <returns></returns>
        public string CompairNewtonandPow(double newton, double pow)
        {
            
            if (newton.CompareTo(pow)>0)
            {
                return "newton > pow";
            }
            if (newton.CompareTo(pow) < 0)
            {
                return "newton < pow";
            }
            return "равны";
        }
        /// <summary>
        /// Метод, который преобразует неотрицательное число в двоичное представление с проверкой возможности конвертирования в uint
        /// Если преобразование невозможно то возвращаем ошибку FormatException
        /// </summary>
        /// <param name="number">десятичное неотрицательное число, которое нужно представить в двоичный вид.</param>
        /// <returns></returns>
        public string ToBinary(string number)
        {
            uint gooduint;
            if (!uint.TryParse(number, out gooduint))
            {
                throw new FormatException("не удается конвертировать в тип uint");
            }
            string binary = Convert.ToString(gooduint, 2);
            return binary;
        }
    }
 

   
  
}
