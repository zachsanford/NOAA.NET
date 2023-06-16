using NOAA.NET.Alerts;
using NOAA.NET.Extensions;
using NOAA.NET.Alerts.Types;

namespace NOAA.NET.Tests.Alerts;

public class BuilderTests
{
    [Fact]
    public void Test()
    {
        Builder builder = new()
        {
            Status = Status.Actual,
            Limit = 12
        };

        Assert.Equal(Status.Actual, builder.Status);
        Assert.Equal(12, builder.Limit);
        Assert.Equal("actual", builder.Status.GetStringValue());
    }
}
