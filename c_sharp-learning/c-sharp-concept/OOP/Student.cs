namespace Student;

internal class Student
{
    // We should follow the data encapsulation means 
    int Rno;
    string Name;
    string Branch;
    int Fee;

    internal void AcceptStudent(int roll_no, string branch, string name, int fee)
    {
        this.Rno = roll_no;
        this.Branch = branch;
        this.Name = name;
        this.Fee = fee;
    }

    public void DisplayStudent()
    {
        Console.WriteLine(
            $"The student name is {Name}, their roll no. is {Rno} and branch is {Branch} and their school fee is {Fee}"
        );
    }
}