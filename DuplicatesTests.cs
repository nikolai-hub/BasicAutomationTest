using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] actualResult = Duplicates.RemoveDuplicates(numbers);
        int[] expectedResult = Array.Empty<int>();

        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        int[] numbers = new int[]  { 2, 4, 6 };

        // Act
        int[] actualResult = Duplicates.RemoveDuplicates(numbers);
        int[] expectedResult = new int[] { 2, 4, 6 };

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        int[] numbers = new int[] { 2, 4, 6, 6 };

        // Act
        int[] actualResult = Duplicates.RemoveDuplicates(numbers);
        int[] expectedResult = new int[] { 2, 4, 6 };

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        int[] numbers = new int[] { 6, 6, 6 };

        // Act
        int[] actualResult = Duplicates.RemoveDuplicates(numbers);
        int[] expectedResult = new int[] { 6 };

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}
