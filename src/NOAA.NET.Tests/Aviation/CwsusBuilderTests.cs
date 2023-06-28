using NOAA.NET.Aviation;
using NOAA.NET.Extensions;
using NOAA.NET.Aviation.Types;

namespace NOAA.NET.Tests.Aviation;

public class CwsusBuilderTests
{
    [Fact]
    public void Builder_Working_Constructor()
    {
        // Arrange
        CwsusBuilder? builder = null;
        CwsuId expectedId = CwsuId.ZSE;

        // Act
        builder = new()
        {
            CwsuId = CwsuId.ZSE
        };

        // Assert
        Assert.Equal(expectedId, builder.CwsuId);
    }
}
