using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Library
{
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

        public NewTon (double a, double n)
        {
            this.A = a;
            this.N = n;
            this.Eps = 0.0001;
        }
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
