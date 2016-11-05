using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Triangle
    {
        //событие
      
        //координата X вершины А
        private double x1;

        public double X1
        {
            get { return x1; }
            set
            {
                x1 = value;
                SideALength();
                SideBLength();
            }
        }
        //координата Y вершины А
        private double y1;

        public double Y1
        {
            get { return y1; }
            set {
                    y1 = value;
                SideALength();
                SideBLength();
            }
        }

        //координата X вершины B
        private double x2;

        public double X2
        {
            get { return x2; }
            set {
                    x2 = value;
                SideALength();
                SideCLength();
            }
        }

        //координата Y вершины B
        private double y2;

        public double Y2
        {
            get { return y2; }
            set {
                    y2 = value;
                SideALength();
                SideCLength();
            }
        }
        //координата X вершины С
        private double x3;

        public double X3
        {
            get { return x3; }
            set {
                    x3 = value;
                SideBLength();
                SideCLength();
            }
        }

        private double y3;

        public double Y3
        {
            get { return y3; }
            set {
                    y3 = value;
                SideBLength();
                SideCLength();
            }
        }

        //длина стороны А
        public double A { get; set; }
        //длина стороны B
        public double B { get; set; }
        //длина стороны C
        public double C { get; set; }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
            this.X3 = x3;
            this.Y3 = y3;
           SideALength();
           SideBLength();
           SideCLength();
        }
        public void SideALength()
        {
            checked
            {
                this.A = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            }
            
        }
        private void SideBLength()
        {
            this.B = Math.Sqrt(Math.Pow(X3 - X1, 2) + Math.Pow(Y3 - Y1, 2));
        }
        private void SideCLength()
        {
            this.C = Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));
        }
        //проверка существования треугольника
        public bool IsAlive()
        {
            checked
            {
                if (((A + B) > C && (A + C) > B && (B + C) > A))
                return true;
                    return false;
            }
        }
        //площадь треугольника
        public double Square()
        {
            checked
            {
                return 0.5 * Math.Abs((X2 - X1) * (Y3 - Y1) - (X3 - X1) * (Y2 - Y1));
            }
            
        }
        //периметр треугольника
        public double Perimetr()
        {
            checked
            {
                return A + B + C;
            }
            
        }
    }
}
