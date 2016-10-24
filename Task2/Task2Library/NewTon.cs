using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Library
{
    public class NewTon
    {

        public double A { get; set; }
        public double N { get; set; }
        public double Eps { get; set; }


        public NewTon (double a, double n)
        {
            this.A = a;
            this.N = n;
            this.Eps = 0.0001;
        }
        public double SqrtN()
        {
            var x0 = A / N;
            var x1 = (1 / N) * ((N - 1) * x0 + A / Math.Pow(x0, (int)N - 1));

            while (Math.Abs(x1 - x0) > Eps)
            {
                x0 = x1;
                x1 = (1 / N) * ((N - 1) * x0 + A / Math.Pow(x0, (int)N - 1));
            }

            return x1;
        }

        public double Pow()
        {
            return Math.Pow(A, N);
        }


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
    }
}
