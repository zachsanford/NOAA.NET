// <copyright file="HealthClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Health;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Health endpoint of the API.
/// </summary>
internal sealed class HealthClient : NOAAClient<HealthResponse>
{
    /// <inheritdoc/>
    protected override string BaseURL { get; } = @"https://api.weather.gov/";

    /// <inheritdoc/>
    protected override string EndpointType { get; } = "Status";
}
