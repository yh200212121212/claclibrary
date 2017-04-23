// ConsoleApplication1.cpp: 主项目文件。

#include "stdafx.h"
using namespace System;
int main(array<System::String ^> ^args)
{
	double a, b, c;
    Console::WriteLine(L"请输入三角形第一条边长度");
	a =System::Convert::ToDouble(Console::ReadLine());
	Console::WriteLine(L"请输入三角形第二条边长度");
	b = System::Convert::ToDouble(Console::ReadLine());
	Console::WriteLine(L"请输入三角形夹角角度（角度制）");
	c = System::Convert::ToDouble(Console::ReadLine());
	ClassLibrary2::Class1^ cc = gcnew ClassLibrary2::Class1(a,b,c);
	Console::Write("结果为");
	//System::Diagnostics::Debugger::Break();
	Console::WriteLine(cc->clac());
	double d, e, f;
	Console::WriteLine(L"请输入三角形第一条边长度");
	d = System::Convert::ToDouble(Console::ReadLine());
	Console::WriteLine(L"请输入三角形第二条边长度");
	e = System::Convert::ToDouble(Console::ReadLine());
	Console::WriteLine(L"请输入三角形第三条边长度");
	f = System::Convert::ToDouble(Console::ReadLine());
	ClassLibrary3::Class1^ ccc = gcnew ClassLibrary3::Class1(d,e,f);
	Console::Write("结果为");
	//System::Diagnostics::Debugger::Break();
	Console::Write(ccc->clac());
	Console::ReadKey();
    return 0;
}
