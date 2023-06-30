// <copyright file="SigmetsClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Aviation.Sigmets;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Aviation SIGMETs endpoint of the API.
/// </summary>
internal sealed class SigmetsClient : NOAAClient<SigmetsResponse>
{
    /// <inheritdoc/>
    protected override string BaseURL { get; } = @"https://api.weather.gov/aviation/sigmets";

    /// <inheritdoc/>
    protected override string EndpointType { get; } = "Aviation SIGMETs";
}
