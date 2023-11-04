using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool actualResult = Email.IsValidEmail(validEmail);
       

        Assert.That(actualResult, Is.True);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        string inValidEmail = "test.example.com";

        // Act
        bool actualResult = Email.IsValidEmail(inValidEmail);


        Assert.That(actualResult, Is.False);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        string? inValidEmail = null;

        // Act
        bool actualResult = Email.IsValidEmail(inValidEmail);


        Assert.That(actualResult, Is.False);
    }
    [Test]
    public void Test_IsValidEmail_InvalidEmailWithWhitespaces()
    {
        string inValidEmail = "       ";

        // Act
        bool actualResult = Email.IsValidEmail(inValidEmail);


        Assert.That(actualResult, Is.False);
    }
}
