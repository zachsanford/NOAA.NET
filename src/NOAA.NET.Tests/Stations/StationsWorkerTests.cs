using NOAA.NET.Stations;
using NOAA.NET.Types;

namespace NOAA.NET.Tests.Stations;

public class StationsWorkerTests
{
    [Fact]
    public void Worker_Working_Constructor()
    {
        // Arrange
        StationsBuilder? builder = null;
        StationsWorker? worker = null;

        // Act
        builder = new()
        {
            Id = "KRBG",
            State = Areas.OR,
            Limit = 1
        };

        worker = new(builder);

        // Assert
        Assert.NotNull(worker);
    }

    [Fact]
    public async void Worker_Working()
    {
        // Arrange
        StationsBuilder? builder = null;
        StationsWorker? worker = null;
        StationsResponse? response = null;

        // Act
        builder = new()
        {
            Id = "KRBG",
            State = Areas.OR,
            Limit = 1
        };

        worker = new(builder);
        response = await worker.CallEndpointAsync();

        // Assert
        Assert.NotNull(response.ObservationStations);
    }
}
