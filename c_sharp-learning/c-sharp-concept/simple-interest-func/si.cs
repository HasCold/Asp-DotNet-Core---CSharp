namespace SI;

// Methods must have a different name than the class

// Formula :-  Simple Interest = (p * r * t)/100
internal class SICalc {
    internal static void SIFunc(){
        int p = 120000;
        float r = 12.3F;
        int t = 5;

        float si = (p * r * t)/100;
        Console.WriteLine($"The result is {si}");
    }
}