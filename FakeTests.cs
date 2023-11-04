using NUnit.Framework;

using System;
using System.Linq;
using System.Runtime.Serialization;

namespace TestApp.UnitTests;

public class FakeTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

       Assert.Throws<ArgumentException>(() => Fake.RemoveStringNumbers(input));
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        char[] inputWithDigits = new char[] { '0', '1', 'a', 'b' };
        char[] actualResult = Fake.RemoveStringNumbers(inputWithDigits);
        char[] expectedResult = new char[] { 'a', 'b'}; 
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        char[] inputWithDigits = new char[] { 'n', 'f', 'a', 'b' };
        char[] actualResult = Fake.RemoveStringNumbers(inputWithDigits);
        char[] expectedResult = new char[] { 'n', 'f', 'a', 'b' };
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        char[] inputWithDigits = new char[] { '0', '4', '2', '4' };
        char[] actualResult = Fake.RemoveStringNumbers(inputWithDigits);
        
        CollectionAssert.IsEmpty(actualResult);
    }
}
