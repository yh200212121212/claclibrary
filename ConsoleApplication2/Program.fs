// 在 http://fsharp.org 上了解有关 F# 的详细信息
// 请参阅“F# 教程”项目以获取更多帮助。
open ClassLibrary2
open ClassLibrary3
open System

[<EntryPoint>]
let main argv = 
    Console.WriteLine("请输入三角形一边边长")
    let a = Convert.ToDouble(Console.ReadLine())
    Console.WriteLine("请输入三角形第二边边长")
    let b = Convert.ToDouble(Console.ReadLine())
    Console.WriteLine("请输入三角形夹角角度（角度制）")
    let c = Convert.ToDouble(Console.ReadLine())
    let cc1=new ClassLibrary2.Class1(a,b,c)
    Console.WriteLine(cc1.clac())
    Console.WriteLine("请输入三角形一边边长")
    let d = Convert.ToDouble(Console.ReadLine())
    Console.WriteLine("请输入三角形第二边边长")
    let e = Convert.ToDouble(Console.ReadLine())
    Console.WriteLine("请输入三角形第三边边长")
    let f = Convert.ToDouble(Console.ReadLine())
    let cc2=new Class1(d,e,f)
    Console.WriteLine(cc2.clac())
    System.Console.ReadKey() |>ignore
    1 // 返回整数退出代码
