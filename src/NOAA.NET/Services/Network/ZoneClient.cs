// <copyright file="ZoneClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Zones;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Zones endpoint of the API.
/// </summary>
public sealed class ZoneClient : NOAAClient<ZoneResponse>
{
    /// <inheritdoc/>
    protected override string BaseURL { get; } = @"https://api.weather.gov/zones";

    /// <inheritdoc/>
    protected override string EndpointType { get; } = "Zones";
}
