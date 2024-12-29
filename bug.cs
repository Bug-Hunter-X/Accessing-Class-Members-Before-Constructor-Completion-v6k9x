public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void DoSomething()
    {
        // Accessing a member of the class before the constructor has completed.
        // This can lead to unexpected behavior or exceptions.
        Console.WriteLine(Value); 
    }
}