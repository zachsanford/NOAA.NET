// <copyright file="GridpointsClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Gridpoints;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Gridpoints endpoint of the API.
/// </summary>
internal sealed class GridpointsClient : NOAAClient<GridpointsResponse>
{
    /// <inheritdoc/>
    protected override string BaseURL { get; } = @"https://api.weather.gov/gridpoints";

    /// <inheritdoc/>
    protected override string EndpointType { get; } = "Gridpoints";
}
