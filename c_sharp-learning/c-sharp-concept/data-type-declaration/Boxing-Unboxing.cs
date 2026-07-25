namespace BoxingUnboxing;

using System;

class BoxingAndUnboxing {
    // Boxing and Unboxing are implicit and explicit conversion

    // 1. Boxing means to convert value data type to reference data type.
    // int, float, bool, char -->> object 
    // It is an implicit (automatic) type conversion process.
    // e.g. :- 
    // int a = 10;
    // object b;
    // b = a;  // value to reference implicit type conversion


    // 2. UnBoxing means to convert value reference type to value data type.
    // It is explicit manual conversion process
    // e.g. :-    
    // internal void Testing(){
    //     object a = 25;
    //     int b;
    //     b = Convert.ToInt32(a);  // Manual process
    //     b = (int)a;  // Manual process
    // }

    // internal void NumericString(){
    //     object num = "123";
    //     int b;
    //     b = Convert.ToInt32(num);  // Manual process
    
    //     int num2 = Convert.ToInt32(Console.ReadLine());
    //     Console.WriteLine("Number :- ", num2);
    // }
}