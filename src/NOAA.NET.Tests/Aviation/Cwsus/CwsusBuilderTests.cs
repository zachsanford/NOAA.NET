using NOAA.NET.Aviation.Cwsus;
using NOAA.NET.Types;

namespace NOAA.NET.Tests.Aviation.Cwsus;

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
