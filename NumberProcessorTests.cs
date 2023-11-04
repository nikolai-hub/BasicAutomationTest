using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        // Act
        List<double> actualResult = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actualResult);
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        List<int> inputWithOddNumbers = new() { 9, 49, 25 };
        List<double> expectedResult = new() { 3, 7, 5 };

        // Act
        List<double> actualResult = NumberProcessor.ProcessNumbers(inputWithOddNumbers);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        // Arrange
        List<int> inputWithZero = new() { 0 };
        List<int> expectedResult = new() { 0 };

        List<double> actualResult = NumberProcessor.ProcessNumbers(inputWithZero);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_ProcessNumbers_HandleNegativeNumbers()
    {
        List<int> inputWithNegativeNumbers = new() { -1, -2, 3 };

        // Assert
        Assert.That(() => NumberProcessor.ProcessNumbers(inputWithNegativeNumbers), Throws.ArgumentException);
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        List<int> inputEmty = new();
        
        List<double> actualResult = NumberProcessor.ProcessNumbers(inputEmty);

        // Assert
        CollectionAssert.IsEmpty(actualResult);
    }
}
