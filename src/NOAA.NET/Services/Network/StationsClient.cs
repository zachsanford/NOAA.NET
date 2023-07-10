// <copyright file="StationsClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Stations;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Stations endpoint of the API.
/// </summary>
internal sealed class StationsClient : NOAAClient<StationsResponse>
{
    /// <inheritdoc/>
    protected override string BaseURL { get; } = @"https://api.weather.gov/stations";

    /// <inheritdoc/>
    protected override string EndpointType { get; } = "Stations";
}
