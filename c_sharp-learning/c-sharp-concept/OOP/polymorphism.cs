namespace Poly;

// Poly means many and morphism means forms, using this we will create same name method with multiple forms.

// Types:-
// 1. Static Polymorphism 
// - Function Overloading is the example of static polymorphism; Using this we will create same name methods with different parameters.
// - Constructor is the best example of function overloading because constructor name is same only parameters are different.

// 2. Dynamic Polymorphism - 
// - Function Over-Riding and Function Over-Hiding.
// - Function Overriding means there is an existing class we have and we will create some other class with the upgradation of that particular class.
// - Dynamic/runtime polymorphism is the behavior you get from runtime dispatch.
// - Inheritance generally worked with these concept Dynamic Polymorphism and Interface
class Poly
{
    // Static Poly :- Function Overloading
    internal void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    internal void Add(float a, float b)
    {
        Console.WriteLine(a + b);
    }

}

// Dynamic Polymorphism
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

// Inheritance :- It means code reuseability, using this we can acquire the features of parent class to child class.
// Type of Inheritance
// 1. Single: base class to derived class (Admin --->> Employee)
// 2. Multi Level: base class to derived class to sub-derived class (Admin --->> Employee --->> Otherstaff)
// 3. Hierarchical: single base class, extend to multiple derived class.
// (Admin --->> Employee and Otherstaff)


// class A {}
// class B : A{}

// B obj = new B() ==>> it points B class as well as A
// A obj1 = new A() ==>> it points only A class
// B obj2 = new A() ==>> not possible

// A obj3 = new B() ==>> it is possible loose couple; we can create reference of parent class and instantiate with the sub-class B.