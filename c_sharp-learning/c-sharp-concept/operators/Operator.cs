namespace Operator;

internal class Operator {
    // Post and Pre Operator
    // int x = 10;
    // int y = x++; // Post increment :- Here the value of x, first assigned to y then increment to x. x = 11 and y = 10 
    // First use the current value. 
    // Then increase it.

    // int z = ++x; // Pre increment :- Here the value of incremented x, first assigned to z. x = 11 and z = 11
    // First increase the value.
    // Then use it.
    
    int x = 2;
    int y = x++ + ++x + x-- + --x + x++;
    // 2 + 4 + 4 + 2 + 2
    // = 14

    Console.WriteLine(x);   
    Console.WriteLine(y);
}