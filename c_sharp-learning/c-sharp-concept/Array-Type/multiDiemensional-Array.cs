namespace MultiDiemensional;

internal class MultiDiemensional
{
    internal static void MultiArray()
    {
        // Single Diemensional Array
        // Elements type can be of different data-type
        object[] student = { 1001, "Hasan", true };
        foreach (object o in student)
        {
            Console.WriteLine("Element Objects: {0}", o);
        }

        // Multi Diemensional Array
        int[][] a = new int[3][];
        a[0] = new int[3] { 1, 22, 33 };
        a[1] = new int[1] { 91 };
        a[2] = new int[4] { 9, 22, 0, 76 };

        int[,] arrD = { { 12, 33, 4 }, { 22, 9, 1 } };
        for (int i = 0; i < arrD.Length; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Multi Diemensonal Array: {0}", arrD[i, j]);
            }
            Console.WriteLine();
        }


        string x = "Hello";
        char[] arr = x.ToCharArray();
        int countVowel = 0;
        int countConsonant = 0;

        foreach (char ch in arr)
        {
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    countVowel++;
                    break;

                default:
                    countConsonant++;
                    break;
            }
        }

        Console.WriteLine("Vowel :- {0}", countVowel);
        Console.WriteLine("Consonent :- {0}", countConsonant);
        Console.WriteLine($"Array: {new string(arr)}");
    }

}