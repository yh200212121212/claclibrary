using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Class1
    {
        double  _a, _b, _c;
        public Class1(double a,double b,double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public double a { get { return _a; } }
        public double b { get { return _b; } }
        public double c { get { return _c; } }
        public double clac()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * Math.Abs(p - a) * Math.Abs(p - b) * Math.Abs(p - c));
        }
    }
}
