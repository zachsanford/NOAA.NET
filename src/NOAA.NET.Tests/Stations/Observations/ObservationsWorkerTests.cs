using NOAA.NET.Stations.Observations;

namespace NOAA.NET.Tests.Stations.Observations;

public class ObservationsWorkerTests
{
    public static IEnumerable<object[]> GetWorkerWorkingConstructorData()
    {
        yield return new object[] { null, null, null, "krbg" };
        yield return new object[] { null, null, (ushort)3, "KrBg" };
        yield return new object[] { DateTime.Now.AddDays(-1).AddHours(-2), null, (ushort)5, "KRBG" };
        yield return new object[] { DateTime.Now.AddDays(-2).AddHours(-3), DateTime.Now.AddDays(-2).AddHours(-1), (ushort)10, "krBG" };
    }

    [Theory]
    [MemberData(nameof(GetWorkerWorkingConstructorData))]
    public async void Worker_Working_Constructor(DateTime? startParameter, DateTime? endParameter,
        ushort? limitParameter, string stationIdParamter)
    {
        // Arrange
        ObservationsBuilder? builder = null;
        ObservationsWorker? worker = null;
        ObservationsResponse? response = null;

        // Act
        builder = new()
        {
            Start = startParameter,
            End = endParameter,
            Limit = limitParameter,
            StationId = stationIdParamter
        };

        worker = new(builder);
        response = await worker.CallEndpointAsync();

        // Assert
        Assert.NotNull(response.Features);
    }
}
