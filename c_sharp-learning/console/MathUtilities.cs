namespace MathUtilities;

internal class MathUtilities {
    internal static int Addition(int arg1, int arg2) {
        var res = arg1 + arg2;
        // {0} -> called placeholder
        Console.WriteLine("1. The Addtion result is {0}", res); 
        Console.WriteLine("2. The Addtion result is " + res);
        // String interpolation
        Console.WriteLine($"3. The Addtion result is {res}"); 
        return res;
    }
}