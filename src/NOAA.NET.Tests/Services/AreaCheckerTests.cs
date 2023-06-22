using NOAA.NET.Services;

namespace NOAA.NET.Tests.Services;

public class AreaCheckerTests
{
    [Theory]
    [InlineData("OR")]
    [InlineData("TX")]
    [InlineData("OH")]
    public void Checker_Working_Constructor(string constructorParameter)
    {
        // Arrange
        AreaChecker? checker = null;

        // Act
        checker = new(constructorParameter);

        // Assert
        Assert.NotNull(checker);
    }

    [Theory]
    [InlineData("OR")]
    [InlineData("oR")]
    [InlineData("tx")]
    [InlineData("Ut")]
    [InlineData("TX")]
    [InlineData("NV")]
    public void Checker_Working(string constructorParameter)
    {
        // Arrange
        bool expectedOutput = true;
        bool? actualOutput = null;
        AreaChecker? checker = null;

        // Act
        checker = new(constructorParameter);
        actualOutput = checker.TestArea();

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
    }

    [Theory]
    [InlineData("34mm")]
    [InlineData("orG923")]
    [InlineData("orz00vee")]
    public void Checker_NotWorking(string constructorParameter)
    {
        // Arrange
        bool expectedOutput = false;
        bool? actualOutput = null;
        AreaChecker? checker = null;

        // Act
        checker = new(constructorParameter);
        actualOutput = checker.TestArea();

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
    }
}
