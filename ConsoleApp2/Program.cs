using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("请输入三角形一边边长");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入三角形第二边边长");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入三角形夹角角度（角度制）");
            c = Convert.ToDouble(Console.ReadLine());
            ClassLibrary2.Class1 cclass = new ClassLibrary2.Class1(a, b, c);
            Console.WriteLine(cclass.clac().ToString());
            double d,e,f;
            Console.WriteLine("请输入三角形一边边长");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入三角形第二边边长");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入三角形第三边边长");
            f = Convert.ToDouble(Console.ReadLine());
            ClassLibrary3.Class1 cc = new ClassLibrary3.Class1(d, e, f);
            Console.WriteLine(cc.clac().ToString());
            Console.ReadKey();
        }
    }
}
