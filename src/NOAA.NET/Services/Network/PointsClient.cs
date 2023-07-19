// <copyright file="PointsClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Points;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Points endpoint of the API.
/// </summary>
internal sealed class PointsClient : NOAAClient<PointsResponse>
{
    /// <inheritdoc/>
    protected override string BaseURL { get; } = @"https://api.weather.gov/points";

    /// <inheritdoc/>
    protected override string EndpointType { get; } = "Points";
}
