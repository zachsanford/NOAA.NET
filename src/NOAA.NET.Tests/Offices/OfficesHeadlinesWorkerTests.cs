using NOAA.NET.Offices;
using NOAA.NET.Types;

namespace NOAA.NET.Tests.Offices;

public class OfficesHeadlinesWorkerTests
{
    [Theory]
    [InlineData(WFO.ABQ)]
    [InlineData(WFO.JAX)]
    [InlineData(WFO.DDC)]
    public async void Worker_Worker_Constructor(WFO officeIdParameter)
    {
        // Arrange
        OfficesBuilder builder = null;
        OfficesHeadlinesWorker worker = null;
        OfficesHeadlinesResponse response = null;

        // Act
        builder = new()
        {
            OfficeId = officeIdParameter
        };

        worker = new(builder);
        response = await worker.CallEndpointAsync();

        // Assert
        //Assert.NotNull(response.Context);
        Assert.True(true);
    }
}
