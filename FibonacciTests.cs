using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_NegativeInput()
    {
        // Arrange
        int n = -1;

        // Act & Assert
        Assert.That(() => Fibonacci.CalculateFibonacci(n), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        int input = 0;
        int actualResult = Fibonacci.CalculateFibonacci(input);
        Assert.That(actualResult, Is.Zero);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        int input = 7;
        int actualResult = Fibonacci.CalculateFibonacci(input);

        Assert.That(13, Is.EqualTo(actualResult));
    }
}