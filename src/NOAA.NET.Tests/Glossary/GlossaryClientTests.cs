using NOAA.NET.Glossary;
using NOAA.NET.Services.Network;

namespace NOAA.NET.Tests.Glossary;

public class GlossaryClientTests
{
    [Fact]
    public void GlossaryClient_Working_Constructor()
    {
        // Arrange
        GlossaryClient? client = null;

        // Act
        client = new();

        // Assert
        Assert.NotNull(client);
    }

    [Fact]
    public async void GlosarryClient_Working_CallAPI()
    {
        // Arrange
        GlossaryClient? client = null;
        GlossaryResponse? response = null;

        // Act
        client = new();
        response = await client.CallAPI();

        // Assert
        Assert.NotNull(response);
    }
}
