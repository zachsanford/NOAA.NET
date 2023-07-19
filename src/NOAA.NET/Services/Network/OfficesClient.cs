// <copyright file="OfficesClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Offices;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Offices endpoint of the API.
/// </summary>
internal sealed class OfficesClient : NOAAClient<OfficesResponse>
{
    /// <inheritdoc/>
    protected override string BaseURL { get; } = @"https://api.weather.gov/offices";

    /// <inheritdoc/>
    protected override string EndpointType { get; } = "Offices";
}
