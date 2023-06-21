// <copyright file="GlossaryClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Glossary;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Glossary endpoint of the API.
/// </summary>
public sealed class GlossaryClient : NOAAClient<GlossaryResponse>
{
    /// <inheritdoc/>
    protected override string BaseURL { get; } = @"https://api.weather.gov/glossary";

    /// <inheritdoc/>
    protected override string EndpointType { get; } = "Glossary";
}
