using NOAA.NET.Products;
using NOAA.NET.Types;

namespace NOAA.NET.Tests.Products;

public class ProductsWorkerTests
{
    [Theory]
    [InlineData(null, null, null)]
    [InlineData(WFO.MFR, null, null)]
    [InlineData(WFO.MRX, ProductCode.SFP, null)]
    [InlineData(WFO.EKA, null, 15)]
    [InlineData(null, ProductCode.SFT, 10)]
    public async void Worker_Working_Constructor(WFO? locationParameter,
        ProductCode? typeParameter, ushort? limitParameter)
    {
        // Arrange
        ProductsBuilder? builder = null;
        ProductsWorker? worker = null;
        ProductsResponse? response = null;

        // Act
        builder = new()
        {
            Location = locationParameter,
            Type = typeParameter,
            Limit = limitParameter
        };

        worker = new(builder);
        response = await worker.CallEndpointAsync();

        // Assert
        Assert.NotNull(response.Context);
    }
}
