using NOAA.NET.Gridpoints.Forecast;
using NOAA.NET.Gridpoints.Types;

namespace NOAA.NET.Tests.Gridpoints.Forecast;

public class GridpointsForecastWorkerTests
{
    [Theory]
    [InlineData(null, WFO.MFR, 98, 116)]
    [InlineData(Units.SI, WFO.MFR, 98, 116)]
    public async void Worker_Working_Constructor(Units? unitsParameter,
        WFO wfoParameter, byte xParameter, byte yParameter)
    {
        // Arrange
        GridpointsForecastBuilder? builder = null;
        GridpointsForecastWorker? worker = null;
        GridpointsForecastResponse? response = null;

        // Act
        builder = new()
        {
            Wfo = wfoParameter,
            XCoordinate = xParameter,
            YCoordinate = yParameter
        };

        if (unitsParameter != null)
        {
            builder.Units = unitsParameter;
        }

        worker = new(builder);
        response = await worker.CallEndpointAsync();

        // Assert
        Assert.NotNull(response.Geometry);
    }

    [Theory]
    [InlineData(null, true, WFO.MFR, 98, 116)]
    [InlineData(Units.SI, true, WFO.MFR, 98, 116)]
    [InlineData(Units.US, false, WFO.MFR, 98, 116)]
    public async void Worker_Working_Constructor_Hourly(Units? unitsParameter,
        bool isHourlyParameter, WFO wfoParameter, byte xParameter, byte yParameter)
    {
        // Arrange
        GridpointsForecastBuilder? builder = null;
        GridpointsForecastWorker? worker = null;
        GridpointsForecastResponse? response = null;

        // Act
        builder = new()
        {
            IsHourly = isHourlyParameter,
            Wfo = wfoParameter,
            XCoordinate = xParameter,
            YCoordinate = yParameter
        };

        if (unitsParameter != null)
        {
            builder.Units = unitsParameter;
        }

        worker = new(builder);
        response = await worker.CallEndpointAsync();

        // Assert
        Assert.NotNull(response.Geometry);
    }
}
