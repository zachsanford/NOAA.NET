using NOAA.NET.Gridpoints.Forecast;
using NOAA.NET.Gridpoints.Types;

namespace NOAA.NET.Tests.Gridpoints.Forecast;

public class GridpointsForecastBuilderTests
{
    [Fact]
    public void Builder_Working_Constructor()
    {
        // Arrange
        GridpointsForecastBuilder? builder = null;
        Units expectedUnits = Units.SI;
        WFO expectedWFO = WFO.MFR;
        byte expectedX = 100;
        byte expectedY = 200;

        // Act
        builder = new()
        {
            Units = Units.SI,
            Wfo = WFO.MFR,
            XCoordinate = 100,
            YCoordinate = 200
        };

        // Assert
        Assert.Equal(expectedUnits, builder.Units);
        Assert.Equal(expectedWFO, builder.Wfo);
        Assert.Equal(expectedX, builder.XCoordinate);
        Assert.Equal(expectedY, builder.YCoordinate);
    }
}
