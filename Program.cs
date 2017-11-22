using System;

namespace TryCatchFinallyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Test 1 result: {Test1.Test()}");    //catch
            Console.WriteLine($"Test 2 result: {Test2.Test()}");    //catch
            Console.WriteLine($"Test 3 result: {Test3.Test()}");    //Start -> Outer try -> Inner try (throw exception) -> Inner catch -> Inner finally -> Outer finally -> End
            Console.WriteLine($"Test 4 result: {Test4.Test()}");    //Start -> Outer try -> Inner try (throw exception) -> Inner catch (try return) -> Inner finally (throw exception) -> Outer catch -> Return from outer catch
        }
    }
}
