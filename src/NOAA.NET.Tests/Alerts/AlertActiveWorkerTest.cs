using NOAA.NET.Alerts;

namespace NOAA.NET.Tests.Alerts;

public class AlertActiveWorkerTest
{
    [Fact]
    public void Worker_Working_Constructor()
    {
        // Arrange
        AlertBuilder? builder = null;
        AlertActiveWorker? worker = null;

        // Act
        builder = new()
        {
            Zone = "TXZ211",
            Limit = 15
        };

        worker = new AlertActiveWorker(builder);

        // Assert
        Assert.NotNull(worker);
    }

    [Fact]
    public async void Worker_Working()
    {
        // Arrange
        AlertBuilder? builder = null;
        AlertActiveWorker? worker = null;
        AlertResponse? response = null;

        // Act
        builder = new()
        {
            Zone = "TXZ211",
            Limit = 15
        };

        worker = new AlertActiveWorker(builder);
        response = await worker.CallEndpoint();

        // Assert
        Assert.NotNull(response);
    }
}
