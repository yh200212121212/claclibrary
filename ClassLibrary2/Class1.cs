using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public struct MyStruct
    {
        double _a;
        double _b;
        double _degree;
        public double a { set { _a = value; } }
        public double b { set { _b = value; } }
        public double degree { set { _degree = value; } }
    }
    public class Class1
    {
        double _a, _b, _degree;
        public Class1(double a, double b, double degree)
        {
            _a = a;
            _b = b;
            _degree = degree;
        }
        public MyStruct Get()
        {
            MyStruct m = new MyStruct();
            m.a = _a;
            m.b = _b;
            m.degree = _degree;
            return m;
        }
        public double clac()
        {
            return (_a * _b * Math.Sin(ConvertDegreesToRadians(_degree)))/2;
        }
        public T clac<T>() where T : struct
        {
            try
            {
                return (T)Convert.ChangeType(clac(), typeof(T));
            }
            catch
            {
                return default(T);
            }
        }
        private static double ConvertDegreesToRadians(double degrees)
        {
            double radians = (Math.PI / 180) * degrees;
            return (radians);
        }

    }
}
