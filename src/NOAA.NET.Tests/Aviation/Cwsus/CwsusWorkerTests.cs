using NOAA.NET.Aviation.Cwsus;
using NOAA.NET.Types;

namespace NOAA.NET.Tests.Aviation.Cwsus;

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