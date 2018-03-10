using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCalculator
{
    class ModelCalculator
    {
        double Add(double x, double y)
        {
            return (x + y);
        }
        double Sub(double x, double y)
        {
            return x - y;
        }
        double Div(double x, double y)
        {
            return x / y;
        }
        double Mult(double x, double y)
        {
            return x * y;
        }
        public double Pow2(double x)
        {
            return Math.Pow(x, 2);
        }
        public double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }
        public double Equals(double x, double y, string sign)
        {
            switch (sign)
            {
                case "+":
                    return Add(x,y);
                case "-":
                    return Sub(x,y);
                case "*":
                    return Mult(x,y);
                case "/":
                    return Div(x,y);
                default:
                    return 0;
            }   
        }

    }
}
