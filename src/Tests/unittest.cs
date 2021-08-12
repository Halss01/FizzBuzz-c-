using Xunit;
using System;

    public class FizzBuzzTest 
{
    [Fact]
    public void FizzBuzz()
    {
        String input1 = Console.ReadLine();
        
        Assert.Equal(input1, fizzbuzz.Program.unit(15));
    }
}