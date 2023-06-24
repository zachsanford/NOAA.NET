using NOAA.NET.Glossary;
using NOAA.NET.Services.Network;

namespace NOAA.NET.Tests.Glossary;

public class GlossaryWorkerTests
{
    [Fact]
    public void Worker_Working_Constructor()
    {
        // Arrange
        GlossaryWorker? worker = null;

        // Act
        worker = new();

        // Assert
        Assert.NotNull(worker);
    }

    [Fact]
    public async void Worker_Working_()
    {
        // Arrange
        GlossaryWorker? worker = null;
        GlossaryResponse? response = null;

        // Act
        worker = new();
        response = await worker.CallEndpointAsync();

        // Assert
        Assert.NotNull(response.Glossary);
    }
}
