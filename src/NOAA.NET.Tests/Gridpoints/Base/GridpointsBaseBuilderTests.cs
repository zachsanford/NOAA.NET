using NOAA.NET.Gridpoints.Base;
using NOAA.NET.Types;

namespace NOAA.NET.Tests.Gridpoints.Base;

public class GridpointsBaseBuilderTests
{
    [Fact]
    public void Builder_Working_Constructor()
    {
        // Arrange
        GridpointsBaseBuilder? builder = null;
        WFO expectedWFO = WFO.MFR;
        byte expectedX = 100;
        byte expectedY = 200;

        // Act
        builder = new()
        {
            Wfo = WFO.MFR,
            XCoordinate = 100,
            YCoordinate = 200,
        };

        // Assert
        Assert.Equal(expectedWFO, builder.Wfo);
        Assert.Equal(expectedX, builder.XCoordinate);
        Assert.Equal(expectedY, builder.YCoordinate);
    }
}
