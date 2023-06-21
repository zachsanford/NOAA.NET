using NOAA.NET.Services;

namespace NOAA.NET.Tests.Services;

public class ZoneCheckerTests
{
    [Theory]
    [InlineData("ORZ023")]
    [InlineData("AKC013")]
    [InlineData("AKC016")]
    public void ZoneChecker_Working_Constructor(string constructorParameter)
    {
        // Arrange
        ZoneChecker? checker = null;

        // Act
        checker = new(constructorParameter);

        // Assert
        Assert.NotNull(checker);
    }

    [Theory]
    [InlineData("ORZ023")]
    [InlineData("orz023")]
    [InlineData("AKC013")]
    [InlineData("akc016")]
    public async void ZoneChecker_Working(string constructorParameter)
    {
        // Arrange
        bool expectedOutput = true;
        bool? actualOutput = null;
        ZoneChecker? checker = null;

        // Act
        checker = new(constructorParameter);
        actualOutput = await checker.TestZone();

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
    }

    [Theory]
    [InlineData("kejf39848")]
    [InlineData("orG923")]
    [InlineData("orz0000000")]
    public async void ZoneChecker_Regex_NotWorking(string constructorParameter)
    {
        // Arrange
        Exception expectedException = new Exception(message: $"INCORRECT INPUT: {constructorParameter} does not match the correct pattern.");
        Exception? actualException = null;
        ZoneChecker? checker = null;

        // Act
        try
        {
            checker = new(constructorParameter);
        }
        catch (Exception ex)
        {
            actualException = ex;
        }

        // Assert
        Assert.NotNull(actualException);
        Assert.Equal(expectedException.Message, actualException.Message);
    }

    [Theory]
    [InlineData("ORZ923")]
    [InlineData("orz923")]
    [InlineData("AKC913")]
    [InlineData("akc916")]
    public async void ZoneChecker_BadRequest_NotWorking(string constructorParameter)
    {
        // Arrange
        bool expectedOutput = false;
        bool? actualOutput = null;
        ZoneChecker? checker = null;

        // Act
        checker = new(constructorParameter);
        actualOutput = await checker.TestZone();

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
    }
}
