namespace CmdLineInput;

// Methods must have a different name than the class

// 1. Convert.ToInt32();  -> for int
// 2. Convert.ToSingle(); -> for float; small 4 byte data
// 3. Convert.ToDouble(); -> for double; large byte data

internal class CmdLineInput {
    internal static void ReadInput() {
        int a, b, c;

        // Console.Readline() returns string
        Console.WriteLine("Enter first number");
        a = Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Enter second number");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter third number");
        c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The total sum of a: {a}, b: {b} and c: {c} is {a+b+c}");

    }
}