using NOAA.NET.Stations.Observations;

namespace NOAA.NET.Tests.Stations.Observations;

public class ObservationsBuilderTests
{
    [Fact]
    public void Builder_Working_Constructor()
    {
        // Arrange
        ObservationsBuilder? builder = null;

        // Act
        builder = new()
        {
            StationId = "KRBG"
        };

        // Assert
        Assert.NotNull(builder);
    }
}
