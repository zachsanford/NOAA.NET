using NOAA.NET.Health;

namespace NOAA.NET.Tests.Health;

public class HealthWorkerTests
{
    [Fact]
    public void Worker_Working_Constructor()
    {
        // Arrange
        HealthWorker? worker = null;

        // Act
        worker = new();

        // Assert
        Assert.NotNull(worker);
    }

    [Fact]
    public async void Worker_Working()
    {
        // Arrange
        HealthWorker? worker = null;
        HealthResponse? response = null;

        // Act
        worker = new();
        response = await worker.CallEndpoint();

        // Assert
        Assert.NotNull(response.Status);
    }
}
