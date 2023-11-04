using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        CollectionAssert.IsEmpty(result);
    }

    // TODO: finish test
    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange
        string[] inputArray = new string[] { "Hello"};
        // Act
        string[] actualResult = Reverser.ReverseStrings(inputArray);
        // Assert
        Assert.That(actualResult, Is.EqualTo(new[] { "olleH" }));
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        string[] inputArray = new string[] { "Hello", "World" };
        // Act
        string[] actualResult = Reverser.ReverseStrings(inputArray);
        // Assert
        Assert.That(actualResult, Is.EqualTo(new[] { "olleH", "dlroW" }));
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        string[] inputArray = new string[] { "Hello!", "World$" };
        // Act
        string[] actualResult = Reverser.ReverseStrings(inputArray);
        // Assert
        Assert.That(actualResult, Is.EqualTo(new[] { "!olleH", "$dlroW" }));
    }
}
