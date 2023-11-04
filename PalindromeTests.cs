using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> inputValidWords = new() { "aha", "ana" };
        // Act
        bool actualResult = Palindrome.IsPalindrome(inputValidWords);
        // Assert
        Assert.IsTrue(actualResult);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> emtyList = new();

        // Act
        bool actualResult = Palindrome.IsPalindrome(emtyList);
        // Assert
        Assert.IsTrue(actualResult);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        List<string> inputValidWords = new() { "aha" };
        // Act
        bool actualResult = Palindrome.IsPalindrome(inputValidWords);
        // Assert
        Assert.IsTrue(actualResult);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        List<string> inputValidWords = new() { "ahan" };
        // Act
        bool actualResult = Palindrome.IsPalindrome(inputValidWords);
        // Assert
        Assert.IsFalse(actualResult);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        List<string> inputValidWords = new() { "Aha", "ANA" };
        // Act
        bool actualResult = Palindrome.IsPalindrome(inputValidWords);
        // Assert
        Assert.IsTrue(actualResult);
    }
}
