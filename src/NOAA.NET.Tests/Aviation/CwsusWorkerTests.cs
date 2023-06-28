using NOAA.NET.Aviation;
using NOAA.NET.Aviation.Types;

namespace NOAA.NET.Tests.Aviation;

public class CwsusWorkerTests
{
    [Fact]
    public void Worker_Working_Constructor()
    {
        // Arrange
        CwsusBuilder? builder = null;
        CwsusWorker? worker = null;

        // Act
        builder = new()
        {
            CwsuId = CwsuId.ZDC
        };

        worker = new(builder);

        // Assert
        Assert.NotNull(worker);
    }

    [Fact]
    public async void Worker_Working()
    {
        // Arrange
        CwsusBuilder? builder = null;
        CwsusWorker? worker = null;
        CwsusResponse? response = null;

        // Act
        builder = new()
        {
            CwsuId = CwsuId.ZDC
        };

        worker = new(builder);
        response = await worker.CallEndpointAsync();

        // Assert
        Assert.NotNull(response.Features);
    }
}