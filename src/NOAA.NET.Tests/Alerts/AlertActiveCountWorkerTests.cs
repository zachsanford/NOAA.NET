using NOAA.NET.Alerts;

namespace NOAA.NET.Tests.Alerts;

public class AlertActiveCountWorkerTests
{
    [Fact]
    public void Worker_Working_Constructor()
    {
        // Arrange
        AlertActiveCountWorker? worker = null;

        // Act
        worker = new();

        // Assert
        Assert.NotNull(worker);
    }

    [Fact]
    public async void Worker_Working()
    {
        // Arrange
        AlertActiveCountWorker worker = null;
        AlertActiveCountResponse response = null;

        // Act
        worker = new();
        response = await worker.CallEndpointAsync();

        // Assert
        Assert.NotNull(response);
    }
}
