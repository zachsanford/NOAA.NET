using NOAA.NET.Products;
using NOAA.NET.Types;

namespace NOAA.NET.Tests.Products;

public class ProductsBuilderTests
{
    [Fact]
    public void Builder_Working_Constructor()
    {
        // Arrange
        ProductsBuilder? builder = null;
        WFO expectedLocation = WFO.MFR;
        ProductCode expectedType = ProductCode.CWA;

        // Act
        builder = new()
        {
            Location = WFO.MFR,
            Type = ProductCode.CWA,
            Limit = 10
        };

        // Assert
        Assert.Equal(expectedLocation, builder.Location);
        Assert.Equal(expectedType, builder.Type);
    }
}
