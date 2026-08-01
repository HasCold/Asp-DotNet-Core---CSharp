// The limitation of array has been solved by collection objects.

// How mant types of Array
// 1.Single Diemensional Array :- Store elements based on rows
// 2. Multi Diemensional Array :- Store elements based on rows and columns. e.g. Matrix, DB Table Storage
// 3. Jagged Diemensional Array :- Store elements using collection of hetrogenous row elements.

namespace ArrayTyp;

internal class ArrayTyp
{
    internal static void ArrImplementation()
    {
        int[] x = { 10, 20, 30, 40 };

        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine("Int : {0}: {0}", i, x[i]);
        }

        Console.Write("For Each Loop");
        Console.Write("\n");
        foreach (int item in x)
        {
            Console.WriteLine(x);
        }
    }
}