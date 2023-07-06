using NOAA.NET.Aviation.Sigmets;

namespace NOAA.NET.Tests.Aviation.Sigmets;

public class SigmetsWorkerTests
{
    public static IEnumerable<object[]> GetWorkerWorkingConstructorData()
    {
        yield return new object[] { DateTime.Now.AddDays(-1), null, null, null, null };
        yield return new object[] { DateTime.Now.AddDays(-1).AddHours(-2), DateTime.Now, null, null, null };
        yield return new object[] { DateTime.Now.AddDays(-2).AddHours(-2), DateTime.Now.AddDays(-1), DateTime.Now, null, null };
        yield return new object[] { DateTime.Now.AddDays(-2).AddHours(-2), DateTime.Now.AddDays(-1), DateTime.Now, "MMMM", null };
        yield return new object[] { DateTime.Now.AddDays(-2).AddHours(-2), DateTime.Now.AddDays(-1), DateTime.Now, "MMMM", "33333" };
    }

    [Fact]
    public void Worker_Working_Constructor_No_Parameter()
    {
        // Arrange
        SigmetsWorker? worker = null;

        // Act
        worker = new();

        // Assert
        Assert.NotNull(worker);
    }

    [Theory]
    [MemberData(nameof(GetWorkerWorkingConstructorData))]
    public async void Worker_Working_Constructor(DateTime? startParameter, DateTime? endParameter,
        DateTime? dateParameter, string? atsuParameter, string? sequenceParameter)
    {
        // Arrange
        SigmetsBuilder? builder = null;
        SigmetsWorker? worker = null;
        SigmetsResponse? response = null;

        // Act
        builder = new()
        {
            Start = startParameter,
            End = endParameter,
            Date = dateParameter,
            Atsu = atsuParameter,
            Sequence = sequenceParameter
        };

        worker = new(builder);
        response = await worker.CallEndpointAsync();

        // Assert
        Assert.NotNull(response.Features);
    }
}
