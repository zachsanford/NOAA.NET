// <copyright file="StatusClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Status endpoint of the API.
/// </summary>
public class StatusClient : NOAAClient<StatusResponse>
{
    /// <inheritdoc/>
    public override string BaseURL { get; set; } = @"https://api.weather.gov/";
}
