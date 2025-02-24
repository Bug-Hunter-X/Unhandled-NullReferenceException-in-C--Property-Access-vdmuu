public class MyClass
{
    public int? MyProperty { get; set; }

    public void MyMethod()
    {
        // Check for null before accessing the property.
        Console.WriteLine(MyProperty.HasValue ? MyProperty.ToString() : "MyProperty is null");
    }
}