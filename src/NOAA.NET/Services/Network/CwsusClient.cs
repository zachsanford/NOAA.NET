// <copyright file="CwsusClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Aviation.Cwsus;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Aviation CWSUS endpoint of the API.
/// </summary>
internal sealed class CwsusClient : NOAAClient<CwsusResponse>
{
    /// <inheritdoc/>
    protected override string BaseURL { get; } = @"https://api.weather.gov/aviation/cwsus";

    /// <inheritdoc/>
    protected override string EndpointType { get; } = "Aviation CWSUS";
}
