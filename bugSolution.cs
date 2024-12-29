public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public ExampleClass()
    {
        // Initialize member in the constructor
        _value = 10;
    }

    public void DoSomething()
    {
        // Accessing a member of the class after the constructor has completed
        Console.WriteLine(Value); 
    }
}