using NOAA.NET.Aviation.Sigmets;

namespace NOAA.NET.Tests.Aviation.Sigmets;

public class SigmetsBuilderTests
{
    [Fact]
    public void Builder_Working_Constructor()
    {
        // Arrange
        SigmetsBuilder? builder = null;
        string expectedAtsu = "MMMM";

        // Act
        builder = new()
        {
            Atsu = "MMMM"
        };

        // Assert
        Assert.Equal(expectedAtsu, builder.Atsu);
    }
}
