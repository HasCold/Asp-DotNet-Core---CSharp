namespace DataEncapsulation;

class DataEncapsulation
{
    // Data Encapsulation :- To hide internal data member of the class, it should be encapsulated with member function then can be accessed. (OOP Concept)

    // Data Abstraction :- To hide the essential actual implementation of the class. (Design Pattern Concept)
    // Both has the same purpose is to provide security.

    // Data Encapsulation ; Apko kisi bhi class ke data-member ko write access nahi krna ha; Or agr access krna ha tu uske liye property ya method banao just like below 
    private int a = 100;
    // Property :-
    public int A { get { return a; } set { a = value; } }

    // Method or Function :-
    internal int DisplayA()
    {
        return a;
    }


    // Data Abstraction; to hide actual implementation of the code
    // we will create abstract class and interface concept to implement data abstraction
}