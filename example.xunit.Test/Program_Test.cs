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
}


