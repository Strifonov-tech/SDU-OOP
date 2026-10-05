int Divide(int a, int b)
{
    return a/b;
}

System.Console.WriteLine("Program has started");

try
{
int result = Divide(20, 0);
System.Console.WriteLine($"Result: {result}");
}
catch(DivideByZeroException ex)
{
    System.Console.WriteLine("Cannot divide by zero.");
}
finally
{
    System.Console.WriteLine("Program has ended");
}


