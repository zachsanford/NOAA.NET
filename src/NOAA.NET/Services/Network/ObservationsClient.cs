// <copyright file="ObservationsClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Stations.Observations;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Stations/Observation endpoint of the API.
/// </summary>
internal sealed class ObservationsClient : NOAAClient<ObservationsResponse>
{
    /// <inheritdoc/>
    protected override string BaseURL { get; } = @"https://api.weather.gov/stations/";

    /// <inheritdoc/>
    protected override string EndpointType { get; } = "Stations Observations";
}
