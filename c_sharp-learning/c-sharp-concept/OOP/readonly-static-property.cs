namespace ReadOnlyAndStatic;

class ReadOnlyAndStaticClass
{
    internal int a;
    public int DisplayUser
    {
        set
        {
            this.a = 10;
        }
        get
        {
            return a;
        }
    }
}