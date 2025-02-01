public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that is not initialized before use.
        int value = MyProperty * 2; // Bug: Potential NullReferenceException if MyProperty is not set.
    }
}