using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        long longInt = 2;
        long actualResult = PrimeFactor.FindLargestPrimeFactor(longInt);
        long expectedResult = 2;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        long longInt = 7;
        long actualResult = PrimeFactor.FindLargestPrimeFactor(longInt);
        long expectedResult = 7;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        long longInt = 123456789123456789;
        long actualResult = PrimeFactor.FindLargestPrimeFactor(longInt);
        long expectedResult = 52579;
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}
