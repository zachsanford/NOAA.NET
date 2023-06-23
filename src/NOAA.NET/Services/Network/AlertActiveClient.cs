// <copyright file="AlertActiveClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Alerts;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Alert Active endpoint of the API.
/// </summary>
internal sealed class AlertActiveClient : NOAAClient<AlertResponse>
{
    /// <inheritdoc/>
    protected override string BaseURL { get; } = @"https://api.weather.gov/alerts/active";

    /// <inheritdoc/>
    protected override string EndpointType { get; } = "Alert Active";
}
