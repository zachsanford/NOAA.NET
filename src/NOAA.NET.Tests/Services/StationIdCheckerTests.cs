using NOAA.NET.Services;
using NOAA.NET.Stations;

namespace NOAA.NET.Tests.Services;

public class StationIdCheckerTests
{
    [Theory]
    [InlineData("KRBG")]
    [InlineData("0002W")]
    [InlineData("3N69")]
    public void Working_Constructor(string constructorParameter)
    {
        // Arrange
        StationIdChecker? checker = null;

        // Act
        checker = new(constructorParameter);

        // Assert
        Assert.NotNull(checker);
    }

    [Theory]
    [InlineData("KRBG")]
    [InlineData("0002W")]
    [InlineData("3N69")]
    [InlineData("kRbG")]
    [InlineData("0002w")]
    [InlineData("3n69")]
    public async void Working(string constructorParameter)
    {
        // Arrange
        bool expectedOutput = true;
        bool? actualOutput = null;
        StationIdChecker? checker = null;

        // Act
        checker = new(constructorParameter);
        actualOutput = await checker.TestStationId();

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
    }

    [Theory]
    [InlineData("bkdfk")]
    [InlineData("3838884383848")]
    [InlineData("this is a test.")]
    public async void BadRequest_NotWorking(string constructorParameter)
    {
        // Arrange
        bool expectedOutput = false;
        bool? actualOutput = null;
        StationIdChecker? checker = null;

        // Act
        checker = new(constructorParameter);
        actualOutput = await checker.TestStationId();

        // Assert
        Assert.Equal(expectedOutput, actualOutput);
    }
}
