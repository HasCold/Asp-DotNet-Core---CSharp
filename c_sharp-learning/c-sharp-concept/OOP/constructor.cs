namespace constructorPrac;

class StudentConstructor
{
    string Name;
    int Age;

    static StudentConstructor()
    {
        Console.WriteLine("Hello, Static Constructor");
    }

    public StudentConstructor(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

// Constructor looks like a method, but...
// There are a few important differences:
// 1. It has the same name as the class
// 2. It has no return type — not even void
// 3. It runs automatically when you use new (A constructor is the setup code that runs when an object is born.)
// e.g. Student student = new Student();
// Mainly constructor used for the initialization purpose.
// 4. Constructor calls implicitly.

// Types of Constructor
// 1. System Define Constructor
// 2. User Define Constructor
// One is Default/non-paramterized and Second is paramterized. 
// 3. Static Constructor
// 4. Data member can be initialized by constructor or whther from property
// Property :- It is used to provide dynamic behaviour to data member of the class.

class Database
{
    Database() { }

    internal static Database Create()
    {
        return new Database();
    }

    private int width;
    public int Height
    {
        get { return width; }
        set { width = value; }
    }
}