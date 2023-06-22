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
    public async void Worker_EmptyBuilder_Working()
    {
        // Arrange
        AlertBuilder? builder = null;
        AlertWorker? worker = null;
        AlertResponse? response = null;

        // Act
        builder = new();

        worker = new AlertWorker(builder);
        response = await worker.CallEndpoint();

        // Assert
        Assert.NotNull(response);
    }

    [Theory]
    //[InlineData(Status.Actual, null, null, null, null, null, null, 50)]
    //[InlineData(Status.Test, MessageType.Alert, null, null, null, null, null, 13)]
    //[InlineData(Status.System, MessageType.Update, Region.PI, null, null, null, null, 100)]
    //[InlineData(Status.Exercise, MessageType.Cancel, Region.GM, Urgency.Past, null, null, null, 75)]
    //[InlineData(Status.Draft, MessageType.Alert, Region.GL, Urgency.Unknown, Severity.Moderate, null, null, 1)]
    //[InlineData(Status.Actual, MessageType.Alert, Region.GL, Urgency.Unknown, Severity.Moderate, Certainty.Likely, null, 1)]
    //[InlineData(Status.Actual, MessageType.Alert, Region.PI, Urgency.Immediate, Severity.Moderate, Certainty.Likely, "ORZ023", 1)]
    [InlineData(null, null, null, null, null, null, null, 2)]
    public async void Worker_Builder_Working(Status? statusParameter, MessageType? messageTypeParameter,
        Region? regionParameter, Urgency? urgencyParameter, Severity? severityParameter,
        Certainty? certaintyParameter, string? zoneParameter, int? limitParameter)
    {
        // Arrange
        AlertBuilder? builder = null;
        AlertWorker? worker = null;
        AlertResponse? response = null;

        // Act
        builder = new()
        {
            Status = statusParameter,
            MessageType = messageTypeParameter,
            Region = regionParameter,
            Urgency = urgencyParameter,
            Severity = severityParameter,
            Certainty = certaintyParameter,
            Zone = zoneParameter,
            Limit = limitParameter
        };

        worker = new(builder);
        response = await worker.CallEndpoint();

        Console.WriteLine("DELETE THIS LINE");

        // Assert
        Assert.True(response.Features.Length == 2);
    }
}
