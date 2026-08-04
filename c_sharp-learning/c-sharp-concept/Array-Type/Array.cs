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
        Console.WriteLine("Enter the size of array");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] s = new int[size];

        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine($"Enter element for {i} index");
            s[i] = Convert.ToInt32(Console.ReadLine());
        }

        int mx = 0;
        foreach (int item in s)
        {
            if (mx < item)
            {
                mx = item;
            }
        }
        Console.WriteLine("Max Element is {mx}");

        // int[] x = { 10, 20, 30, 40 };

        // for (int i = 0; i < s.Length; i++)
        // {
        //     Console.WriteLine();
        //     Console.WriteLine("Display with For Loop");
        //     Console.WriteLine("Int : {0}: {0}", i, s[i]);
        // }

        // Console.Write("For Each Loop");
        // Console.Write("\n");
        // foreach (int item in x)
        // {
        //     Console.WriteLine(x);
        // }
    }
}