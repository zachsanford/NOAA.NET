using NOAA.NET.Offices;
using NOAA.NET.Types;

namespace NOAA.NET.Tests.Offices;

public class OfficesWorkerTests
{
    [Theory]
    [InlineData(WFO.MFR)]
    [InlineData(WFO.PHI)]
    [InlineData(WFO.PDT)]
    public async void Worker_Working_Constructor(WFO officeIdParameter)
    {
        // Arrange
        OfficesBuilder? builder = null;
        OfficesWorker? worker = null;
        OfficesResponse? response = null;

        // Act
        builder = new()
        {
            OfficeId = officeIdParameter
        };

        worker = new(builder);
        response = await worker.CallEndpointAsync();

        // Assert
        Assert.NotNull(response.Id);
    }
}
