Option Infer On
Option Explicit Off
Module Module1
    Sub Main()
        On Error Resume Next

        Console.WriteLine("请输入三角形一边边长")
        a = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("请输入三角形第二边边长")
        b = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("请输入三角形夹角角度（角度制）")
        c = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("请输入三角形一边边长")
        d = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("请输入三角形第二边边长")
        e = Convert.ToDouble(Console.ReadLine())
        Console.WriteLine("请输入三角形第三边边长")
        f = Convert.ToDouble(Console.ReadLine())
        Dim mm As M = DDO(a, b, c, d, e, f)
        Console.WriteLine("结果是" + mm.a)
        Console.WriteLine("结果是" + mm.b)
        Console.ReadKey()
    End Sub
    Structure M
        Sub New(ByVal a As Double, ByVal b As Double)
            Me.a = a
            Me.b = b
        End Sub
        Public ReadOnly Property a() As Double
        Public ReadOnly Property b() As Double
    End Structure
    Function DDO(ByVal a As Double, ByVal b As Double, ByVal c As Double, ByVal d As Double, ByVal e As Double, ByVal f As Double) As M
        Dim cc1 As ClassLibrary2.Class1 = New ClassLibrary2.Class1(a, b, c)
        result1 = cc1.clac()
        Dim cc2 As ClassLibrary3.Class1 = New ClassLibrary3.Class1(d, e, f)
        result2 = cc2.clac()
        mm = New M(result1, result2)
        Return mm
    End Function
End Module
