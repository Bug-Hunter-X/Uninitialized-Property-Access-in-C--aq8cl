public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize MyProperty with a default value

    public void MyMethod()
    {
        // Accessing a property that is now initialized.
        int value = MyProperty * 2;
    }
}