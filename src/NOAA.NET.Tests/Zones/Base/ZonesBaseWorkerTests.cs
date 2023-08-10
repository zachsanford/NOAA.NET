using NOAA.NET.Types;
using NOAA.NET.Zones.Base;

namespace NOAA.NET.Tests.Zones.Base;

public class ZonesBaseWorkerTests
{
    [Fact]
    public void Worker_Working_Constructor()
    {
        // Arrange
        ZonesBaseBuilder? builder = null;
        ZonesBaseWorker? worker = null;

        // Act
        builder = new()
        {
            ZoneId = "ORZ023",
            Limit = 100
        };

        worker = new(builder);

        // Assert
        Assert.NotNull(worker);
    }

    [Theory]
    [InlineData("ORZ023", null, null, null, (ushort)10)]
    [InlineData("ORZ023", Zone.Marine, null, null, (ushort)15)]
    [InlineData("ORZ023", null, "43.0000,-123.2222", null, (ushort)12)]
    [InlineData(null, Zone.Public, "43.216503,-123.341736", true, (ushort)13)]
    [InlineData(null, null, "43.216503,-123.341736", true, (ushort)16)]
    [InlineData(null, Zone.Public, null, false, (ushort)13)]
    [InlineData(null, null, null, null, (ushort)5)]
    public async void Worker_Working(string? zoneIdParameter, Zone? typeParameter,
        string? pointParameter, bool? includeGeometryParameter, ushort? limitParameter)
    {
        // Arrange
        ZonesBaseBuilder? builder = null;
        ZonesBaseWorker? worker = null;
        ZonesBaseResponse? response = null;

        // Act
        builder = new()
        {
            ZoneId = zoneIdParameter,
            Type = typeParameter,
            Point = pointParameter,
            IncludeGeometry = includeGeometryParameter,
            Limit = limitParameter
        };

        worker = new(builder);
        response = await worker.CallEndpointAsync();

        // Assert
        Assert.NotNull(response.Features);
    }
}
