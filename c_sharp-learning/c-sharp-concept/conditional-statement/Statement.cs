namespace ConditionalStatement;

internal class ConditionalStatement
{
    internal void IfElseExpression()
    {
        string result;
        int num = 100;

        for (int i = 1; i < num; i++)
        {
            bool isEven = i % 2 == 0;

            if (isEven)
            {
                result = $"{i} Number is Even";
            }
            else
            {
                result = $"{i} Number is odd";
            }

            Console.WriteLine(
                isEven ?
                $"Incoming Response -->> {result}" :
                $"Incoming Response -->> {result}"
            );
        }
    }

    internal void SwitchExpression()
    {
        string result;
        int num = 100;

        for (int i = 1; i < num; i++)
        {
            bool isEven = i % 2 == 0;

            switch (isEven)
            {
                case true:
                    result = $"{i} Number is Even";
                    break;

                case false:
                    result = $"{i} Number is Odd";
                    break;

                default:
                    result = "Unknown";
                    break;
            }

            Console.WriteLine($"Incoming Response -->> {result}");
        }
    }
}