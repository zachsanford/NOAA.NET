using NOAA.NET.Points;

namespace NOAA.NET.Tests.Points;

public class PointsBuilderTests
{
    [Fact]
    public void Builder_Working_Constructor()
    {
        // Arrange
        PointsBuilder? builder = null;
        string expectedPoint = "43.216503,-123.341736";

        // Act
        builder = new()
        {
            Point = "43.216503,-123.341736"
        };

        // Assert
        Assert.Equal(expectedPoint, builder.Point);
    }
}
