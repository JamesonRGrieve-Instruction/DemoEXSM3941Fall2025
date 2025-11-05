namespace example.xunit.Test;

using example;
public class UnitTest1
{

    [Theory]
    [InlineData(1, true)]
    [InlineData(10, true)]
    [InlineData(0, false)]
    [InlineData(-1, false)]
    [InlineData(-100, false)]
    public void IsPositiveInteger_ReturnsExpected(int input, bool expected_result)
    {
        // Arrange 
        // N/A

        // Act
        bool result = Program.IsPositiveInteger(input);

        // Assert
        Assert.Equal(expected_result, result);
    }

    [Theory]
    [InlineData(95, 'A')]
    [InlineData(90, 'A')]
    [InlineData(89, 'B')]
    [InlineData(80, 'B')]
    [InlineData(79, 'C')]
    [InlineData(70, 'C')]
    [InlineData(69, 'D')]
    [InlineData(60, 'D')]
    [InlineData(59, 'F')]
    [InlineData(0, 'F')]
    public void CalculateGrade_ReturnsCorrectLetter(int score, char expected)
    {
        // Act
        char result = Program.CalculateGrade(score);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(int.MinValue)]
    [InlineData(101)]
    [InlineData(int.MaxValue)]
    public void CalculateGrade_ThrowsException(int score)
    {
        // Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => Program.CalculateGrade(score));
    }
}


