namespace CSharp;

using System;
using Student;
using Poly;

class Program
{
    // This static constructor program will be run before the Main func execution
    // Constructor func memory allocation within the Class memory
    static Program()
    {
        Console.WriteLine("Main Static Constructor");
    }

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
        // Student s = new Student();
        // s.AcceptStudent(12219, "Engineering", "M Hasan Ali", 5600);
        // s.DisplayStudent();
        // Another way of calling; Anonymous Object
        // new Student().DisplayStudent();

        Poly p = new Poly();
        p.Add(1, 5);
        p.Add(2.1F, 9.6F);
    }
}
