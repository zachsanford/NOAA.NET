// <copyright file="OfficesHeadlinesClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Offices;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Offices/Headlines endpoint of the
/// API.
/// </summary>
internal sealed class OfficesHeadlinesClient : NOAAClient<OfficesHeadlinesResponse>
{
    /// <inheritdoc/>
    protected override string BaseURL { get; } = @"https://api.weather.gov/offices";

    /// <inheritdoc/>
    protected override string EndpointType { get; } = "Offices Headlines";
}
