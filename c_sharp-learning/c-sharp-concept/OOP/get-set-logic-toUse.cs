// Yes — **you absolutely can** do this in C#:

// ```csharp
// public int Height;
// ```

// and then from another class:

// ```csharp
// person.Height = 180;
// ```

// That is valid C#.

// The difference is that:

// ```csharp
// public int Height;
// ```
// is a **field**, while:

// ```csharp
// public int Height { get; set; }
// ```
// is a **property**.

// ### Why does C# prefer properties?

// Because properties give you more control over access.

// With a field:
// ```csharp
// public int Height;
// ```

// you're directly exposing the variable.

// With a property:

// ```csharp
// public int Height { get; set; }
// ```

// you're exposing an **access mechanism**.

// For example, later you can change:

// ```csharp
// public int Height
// {
//     get { return _height; }
//     set
//     {
//         if (value < 0)
//             throw new ArgumentException("Height cannot be negative");

//         _height = value;
//     }
// }

// private int _height;
// ```

// Now:

// ```csharp
// person.Height = -10;
// ```

// can be rejected.

// You couldn't easily put that kind of logic around a plain public field.

// ### Another important advantage

// You can make:

// ```csharp
// public int Height { get; private set; }
// ```

// which means:

// ```csharp
// person.Height = 180; // ❌ outside class
// ```

// but inside the class:

// ```csharp
// Height = 180; // ✅
// ```

// So the general C# convention is:

// ```csharp
// public int Height { get; set; }  // ✅ public property
// private int _height;             // private field
// ```

// rather than:

// ```csharp
// public int Height;               // valid, but usually avoided for public data
// ```

// **So your understanding is correct:** `public int Height;` can absolutely be accessed as `person.Height`. The `{ get; set; }` version exists because **properties provide controlled access and flexibility beyond a raw field**.

// NOTE :- And we cannot put only setter in the property alone we need to declare along with the getter as well. 