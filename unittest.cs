using Xunit;

    public class FizzBuzzTest 
{
    [Fact]
    public void FizzBuzz()
    {

        Assert.Equal("FizzBuzz", fizzbuzz.Program.unit(15));
    }
}