namespace ASCII;

// Conversion usually happens like this:- when we type A so the character default ASCII or UNICODE value will be converted into the binary number then it will further goes to the Operating System. 
// Character A  <<--->> Mapping (ASCII / UNICODE) <<--->> Binary Numbers


// ASCII Or UNICODE :- A mathematical representation of any character.

internal class ASCIIORUNICODE
{
    internal static void Implementation()
    {
        // char ch;
        // Console.WriteLine("Plesae, Enter the one character");
        // string? input = Console.ReadLine();
        // if (string.IsNullOrEmpty(input))
        // {
        //     Console.WriteLine("No character entered");
        //     return;
        // }
        // ch = Convert.ToChar(input);
        // int ascii = ch;
        // Console.WriteLine($"The unicode value is {ascii}");

        // switch (ch)
        // {
        //     case 'a':
        //     case 'e':
        //     case 'i':
        //     case 'o':
        //     case 'u':
        //         Console.WriteLine("It is a vowel");
        //         break;

        //     default:
        //         Console.WriteLine("It is a consonent");
        //         break;
        // }

        // int i;
        // for(i = 1; i <= 10; i++);{
        //     Console.WriteLine(i);
        // }

        // int ch = 'A';
        // Console.WriteLine((char)ch + 32);

        // 1 2 3 4 5
        //   1 2 3 4 
        //     1 2 3  
        //       1 2   
        //         1   

        for (int i = 5; i >= 1; i--)
        {
            for (int s = 5; s > i; s--)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }

        char ch;
        bool flag = true;

        while (flag)
        {
            Console.WriteLine("Press C for continue \n Press E for exit");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'C':
                    Console.WriteLine("Loop will Continue");
                    break;

                case 'E':
                    flag = false;
                    break;

                default:
                    Console.WriteLine("Wrong choice Try Again !!");
                    break;
            }
        }

        bool flag2 = false;
        char ch2;
        do
        {
            Console.WriteLine("Press C for continue \n Press E for exit");
            ch2 = Convert.ToChar(Console.ReadLine());

            switch (ch2)
            {
                case 'C':
                    Console.WriteLine("Loop will Continue");
                    break;

                case 'E':
                    flag2 = false;
                    break;

                default:
                    Console.WriteLine("Wrong choice Try Again !!");
                    break;
            }
        } while (flag2);

    }
}