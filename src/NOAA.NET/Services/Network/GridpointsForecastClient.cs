// <copyright file="GridpointsForecastClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Gridpoints.Forecast;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Gridpoints Forecast endpoint
/// of the API.
/// </summary>
internal sealed class GridpointsForecastClient : NOAAClient<GridpointsForecastResponse>
{
    /// <inheritdoc/>
    protected override string BaseURL { get; } = @"https://api.weather.gov/gridpoints";

    /// <inheritdoc/>
    protected override string EndpointType { get; } = "Gridpoints Forecast";
}
