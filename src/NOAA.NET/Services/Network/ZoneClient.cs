// <copyright file="ZoneClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Zones.Base;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Zones endpoint of the API.
/// </summary>
internal sealed class ZoneClient : NOAAClient<ZonesBaseResponse>
{
    /// <inheritdoc/>
    protected override string BaseURL { get; } = @"https://api.weather.gov/zones";

    /// <inheritdoc/>
    protected override string EndpointType { get; } = "Zones";
}
