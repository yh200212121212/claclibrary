using System;

namespace ConsoleApp1
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
            ClassLibrary1.Class1 cclass = new ClassLibrary1.Class1(a, b, c);
            Console.WriteLine(cclass.clac().ToString());
            Console.ReadKey();
        }
    }
}