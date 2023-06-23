// <copyright file="StatusClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Status endpoint of the API.
/// </summary>
public sealed class StatusClient : NOAAClient<StatusResponse>
{
    /// <inheritdoc/>
    protected override string BaseURL { get; } = @"https://api.weather.gov/";

    /// <inheritdoc/>
    protected override string EndpointType { get; } = "Status";
}
