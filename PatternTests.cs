using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish test
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        // Arrange
        int[]? inputArray = null;

        Assert.That(() => Pattern.SortInPattern(inputArray), Throws.ArgumentException);
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        int[] arrayFromInts = new int[] { 2, 6, 4, 100 };
        int[] actualResult = Pattern.SortInPattern(arrayFromInts);
        int[] expectedResult = new int[] { 2, 100, 4, 6 };
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        int[] emptyArray = new int[] { };
        int[] actualResult = Pattern.SortInPattern(emptyArray);
        
        CollectionAssert.IsEmpty(actualResult);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        int[] arrayWithOneElement = new int[] {42};
        int[] actualResult = Pattern.SortInPattern(arrayWithOneElement);
        int[] expectedResult = new int[] { 42 };

        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}
