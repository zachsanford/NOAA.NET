using NOAA.NET.Gridpoints;
using NOAA.NET.Gridpoints.Types;

namespace NOAA.NET.Tests.Gridpoints;

public class GridpointsWorkerTests
{
    [Fact]
    public async void Worker_Working_Constructor()
    {
        // Arrange
        GridpointsBuilder? builder = null;
        GridpointsWorker? worker = null;
        GridpointsResponse? response = null;

        // Act
        builder = new()
        {
            Wfo = WFO.MFR,
            XCoordinate = 100,
            YCoordinate = 100
        };

        worker = new(builder);
        response = await worker.CallEndpointAsync();

        // Assert
        Assert.NotNull(response.Properties);
    }
}
