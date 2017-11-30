# TryCatchFinallyTest

Code:
```cs
Console.WriteLine("Test method begin");

try
{
    Console.WriteLine("\tOuter try");

    try
    {
        Console.WriteLine("\t\tInner try (exception incoming)");

        throw new Exception();
    }
    catch
    {
        Console.WriteLine("\t\tInner catch (exception incoming)");

        throw new Exception("inner catch exception");
    }
    finally
    {
        Console.WriteLine("\t\tInner finally (exception incoming)");

        throw new Exception("inner finally exception");

        //return;   //Error CS0157  Control cannot leave the body of a finally clause 
    }
}
catch (Exception e)
{
    Console.WriteLine($"\tOuter catch (exception from: {e.Message})");
}
finally
{

    Console.WriteLine("\tOuter finally");
}

Console.WriteLine("Test method end");
```

Output:
```
Test method begin
        Outer try
                Inner try (exception incoming)
                Inner catch (exception incoming)
                Inner finally (exception incoming)
        Outer catch (exception from: inner finally exception)
        Outer finally
Test method end
```
