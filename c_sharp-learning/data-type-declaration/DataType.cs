namespace DataType;

internal class DataType {
    // string s = "Hasan"; 
    // int i = 98; 
    // float f = 64.2332F; 

    // constant :- Used to declare fixed value that cannot be changed
    // const data-type identifier = value;
    // Mostly const declare at global level = class level
    // const float PI = 3.142F;
    const int Y = 200;
    static int x = 100;

    internal static void Func(){
        int x = 10;
        x = 20;
        x = 30;

        Console.WriteLine("The value of x is {0}", x);
        Console.WriteLine("The value of Y is {0}", Y);
        Console.WriteLine("The value of Global x is {0}", DataType.x);

        object a = 3;
    }
}

// Primitive Data Type :- int, char, float, string, double, bool, byte. 

// Non Primitive Data Type :- 
// 1. Pre-defined data type
// Int16, Int32, Int64, Double, String, Object(A type which is used to contain any kind of data-type)
// 2. User-defined data type
// Class, Array, Structs, Interface, Enums(set of named integer constant), Delegate.

// 3. Object :- object is a super class data-type or object is a parent class of all the data-types.