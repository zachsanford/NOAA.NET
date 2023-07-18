using NOAA.NET.Offices;
using NOAA.NET.Types;

namespace NOAA.NET.Tests.Offices;

public class OfficesBuilderTests
{
    [Fact]
    public void Builder_Working_Constructor()
    {
        // Arrange
        OfficesBuilder? builder = null;
        WFO expectedOfficeId = WFO.MFR;

        // Act
        builder = new()
        {
            OfficeId = WFO.MFR
        };

        // Assert
        Assert.Equal(expectedOfficeId, builder.OfficeId);
    }
}
