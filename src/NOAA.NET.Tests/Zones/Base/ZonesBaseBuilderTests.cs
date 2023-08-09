using NOAA.NET.Zones.Base;

namespace NOAA.NET.Tests.Zones.Base;

public class ZonesBaseBuilderTests
{
    [Fact]
    public void Builder_Working_Constructor()
    {
        // Arrange
        ZonesBaseBuilder? builder = null;
        string expectedPoint = "43.2165,-123.34174";

        // Act
        builder = new()
        {
            Point = "43.2165,-123.34174"
        };

        // Assert
        Assert.Equal(expectedPoint, builder.Point);
    }
}
