// <copyright file="AlertActiveCountClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Alerts;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Alert Active Count endpoint
/// of the API.
/// </summary>
internal sealed class AlertActiveCountClient : NOAAClient<AlertActiveCountResponse>
{
    /// <inheritdoc/>
    protected override string BaseURL { get; } = @"https://api.weather.gov/alerts/active/count";

    /// <inheritdoc/>
    protected override string EndpointType { get; } = "Alert Active Count";
}
