using NOAA.NET.Points;

namespace NOAA.NET.Tests.Points;

public class PointsWorkerTests
{
    [Fact]
    public async void Worker_Working_Constructor()
    {
        // Arrange
        PointsBuilder? builder = null;
        PointsWorker? worker = null;
        PointsResponse? response = null;

        // Act
        builder = new()
        {
            Point = "43.216503,-123.341736"
        };

        worker = new(builder);
        response = await worker.CallEndpointAsync();

        // Assert
        Assert.NotNull(response.Geometry);
    }
}
