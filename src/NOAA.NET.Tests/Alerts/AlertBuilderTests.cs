using NOAA.NET.Alerts;
using NOAA.NET.Extensions;
using NOAA.NET.Types;

namespace NOAA.NET.Tests.Alerts;

public class AlertBuilderTests
{
    [Fact]
    public void Builder_Working_Constructor()
    {
        // Arrange
        AlertBuilder? builder = null;

        // Act
        builder = new()
        {
            Status = Status.Actual,
            Limit = 12
        };

        // Assert
        Assert.Equal(Status.Actual, builder.Status);
        Assert.Equal(12, builder.Limit);
        Assert.Equal("actual", builder.Status.GetStringValue());
    }
}
