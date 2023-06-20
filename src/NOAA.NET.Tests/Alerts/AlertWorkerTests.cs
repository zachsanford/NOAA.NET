using NOAA.NET.Alerts;
using NOAA.NET.Alerts.Types;

namespace NOAA.NET.Tests.Alerts;

public class AlertWorkerTests
{
    [Fact]
    public void Worker_Working_Constructor()
    {
        // Arrange
        AlertBuilder? builder = null;
        AlertWorker? worker = null;

        // Act
        builder = new()
        {
            Status = Status.Actual,
            Limit = 12
        };

        worker = new AlertWorker(builder);

        // Assert
        Assert.NotNull(worker);
    }

    [Fact]
    public async void Worker_Working()
    {
        // Arrange
        AlertBuilder? builder = null;
        AlertWorker? worker = null;
        AlertResponse? response = null;

        // Act
        builder = new()
        {
            Status = Status.Actual,
            Severity = Severity.Extreme,
            Limit = 5
        };

        worker = new AlertWorker(builder);
        response = await worker.CallEndpoint();

        // Assert
        Assert.NotNull(response);
    }
}
