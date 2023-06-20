// <copyright file="AlertClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Alerts;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Alert endpoint of the API.
/// </summary>
public sealed class AlertClient : NOAAClient<AlertResponse>
{
    /// <inheritdoc/>
    protected override string BaseURL { get; } = @"https://api.weather.gov/alerts";

    /// <inheritdoc/>
    protected override string EndpointType { get; } = "Alert";
}