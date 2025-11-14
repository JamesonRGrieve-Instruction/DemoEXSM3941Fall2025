namespace example.xunit.Test;

using example;
public class UnitTest1
{

    [Theory]
    [InlineData(-1, false)]
    [InlineData(int.MinValue, false)]
    [InlineData(0, false)]
    [InlineData(1, true)]
    [InlineData(5, true)]
    [InlineData(10, true)]
    [InlineData(11, false)]
    [InlineData(int.MaxValue, false)]
    public void ValidateRangedInput_ReturnsExpected(int value, bool expected)
    {
        // Act
        bool result = Program.ValidateRangedInput(1, 10, value);

        // Assert
        Assert.Equal(expected, result);
    }


}


