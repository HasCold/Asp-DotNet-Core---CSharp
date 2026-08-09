namespace CSharp;

using System;
using ArrayTyp;
using MultiDiemensional;
using Student;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, C# Programming");

        // CmdLineInput.ReadInput();
        // SICalc.SIFunc();
        // DataType.Func();
        // ASCIIORUNICODE.Implementation();
        // ArrayTyp.ArrImplementation();
        // MultiDiemensional.MultiArray();
        Student s = new Student();
        s.AcceptStudent(12219, "Engineering", "M Hasan Ali", 5600);
        s.DisplayStudent();
        // Another way of calling; Anonymous Object
        // new Student().DisplayStudent();
    }
}
