using NOAA.NET.Alerts;
using NOAA.NET.Types;

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
        response = await worker.CallEndpointAsync();

        // Assert
        Assert.NotNull(response);
    }

    [Theory]
    [InlineData(Status.Actual, null, null, null, null, null, null, null, 50)]
    [InlineData(Status.Test, MessageType.Alert, null, null, null, null, null, null, 13)]
    [InlineData(Status.System, MessageType.Update, Areas.OR, null, null, null, null, null, 100)]
    [InlineData(Status.Exercise, MessageType.Cancel, Areas.OR, Region.AT, null, null, null, null, 75)]
    [InlineData(Status.Draft, MessageType.Alert, Areas.OR, Region.AT, Urgency.Immediate, null, null, null, 1)]
    [InlineData(Status.Actual, MessageType.Alert, Areas.OR, Region.AT, Urgency.Immediate, Severity.Minor, null, null, 1)]
    [InlineData(Status.Actual, MessageType.Alert, Areas.OR, Region.AT, Urgency.Immediate, Severity.Minor, Certainty.Possible, null, 1)]
    [InlineData(Status.Actual, MessageType.Alert, Areas.OR, Region.AT, Urgency.Immediate, Severity.Minor, Certainty.Possible, "ORZ023", 1)]
    public async void Worker_Builder_Working(Status? statusParameter, MessageType? messageTypeParameter,
        Areas? areaParameter, Region? regionParameter, Urgency? urgencyParameter, Severity? severityParameter,
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
            Area = areaParameter,
            Region = regionParameter,
            Urgency = urgencyParameter,
            Severity = severityParameter,
            Certainty = certaintyParameter,
            Zone = zoneParameter,
            Limit = limitParameter
        };

        worker = new(builder);
        response = await worker.CallEndpointAsync();

        // Assert
        Assert.True(response.Features != null);
    }

    [Theory]
    [InlineData(Areas.OR, null, null)]
    [InlineData(Areas.OR, Region.PA, null)]
    [InlineData(Areas.OR, Region.PA, "TXZ211")]
    [InlineData(Areas.OR, null, "TXZ211")]
    [InlineData(null, Region.PA, null)]
    [InlineData(null, Region.PA, "TXZ211")]
    [InlineData(null, null, "TXZ211")]
    public async void Worker_Region_Area_Zone_Working(Areas? areaParameter, Region? regionParameter, string? zoneParameter)
    {
        // Arrange
        AlertBuilder? builder = null;
        AlertWorker? worker = null;
        AlertResponse? response = null;

        // Act
        builder = new()
        {
            Area = areaParameter,
            Region = regionParameter,
            Zone = zoneParameter
        };

        worker = new(builder);
        response = await worker.CallEndpointAsync();

        // Assert
        Assert.NotNull(response.Features);
    }
}
