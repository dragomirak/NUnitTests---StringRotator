using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string result = StringRotator.RotateRight(input, 3);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "Hello!";

        // Act
        string result = StringRotator.RotateRight(input, 0);

        // Assert
        Assert.That(result, Is.EqualTo("Hello!"));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "Hello!";

        // Act
        string result = StringRotator.RotateRight(input, 3);

        // Assert
        Assert.That(result, Is.EqualTo("lo!Hel"));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "Hello!";

        // Act
        string result = StringRotator.RotateRight(input, -3);

        // Assert
        Assert.That(result, Is.EqualTo("lo!Hel"));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "Hello!";

        // Act
        string result = StringRotator.RotateRight(input, 7);

        // Assert
        Assert.That(result, Is.EqualTo("!Hello"));
    }
}
