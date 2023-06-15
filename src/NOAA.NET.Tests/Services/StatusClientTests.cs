using NOAA.NET.Services;
using NOAA.NET.Services.Network;

namespace NOAA.NET.Tests.Services;

public class StatusClientTests
{
    [Fact]
    public void StatusClient_Working_Constructor()
    {
        // Arrange
        StatusClient? client = null;

        // Act
        client = new();

        // Assert
        Assert.NotNull(client);
    }

    [Fact]
    public async void StatusClient_Working_CallAPI()
    {
        // Arrange
        StatusClient? client = null;
        StatusResponse? response = null;

        // Act
        client = new();
        response = await client.CallAPI();

        // Assert
        Assert.NotNull(response);
    }
}
