namespace example.xunit.Test;

using example;
public class UnitTest1
{

    [Theory]
    [InlineData(4.0, 'A')]
    [InlineData(3.8, 'A')]
    [InlineData(3.7, 'A')]
    [InlineData(3.6, 'B')]
    [InlineData(3.0, 'B')]
    [InlineData(2.7, 'B')]
    [InlineData(2.6, 'C')]
    [InlineData(2.0, 'C')]
    [InlineData(1.7, 'C')]
    [InlineData(1.6, 'D')]
    [InlineData(1.3, 'D')]
    [InlineData(1.0, 'D')]
    [InlineData(0.9, 'F')]
    [InlineData(0, 'F')]
    public void GetGradeLetter_ReturnsExpected(double input, char expected_result)
    {
        // Arrange 
        // N/A

        // Act
        char result = Program.GetGradeLetter(input);

        // Assert
        Assert.Equal(expected_result, result);
    }

    [Theory]
    [InlineData(4.0)]
    [InlineData(2.0)]
    [InlineData(0)]
    public void ValidateGrade_Valid(double gpa)
    {
        // Act
        Program.ValidateGrade(gpa);
    }

    [Theory]
    [InlineData(4.1)]
    [InlineData(-0.1)]
    [InlineData(-4.1)]
    public void ValidateGrade_ThrowsException(double gpa)
    {
        // Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => Program.ValidateGrade(gpa));
    }
}


