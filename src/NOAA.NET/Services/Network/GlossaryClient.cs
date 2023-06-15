// <copyright file="GlossaryClient.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Glossary;

namespace NOAA.NET.Services.Network;

/// <summary>
/// Http client for the Glossary endpoint of the API.
/// </summary>
public class GlossaryClient : NOAAClient<GlossaryResponse>
{
    /// <inheritdoc/>
    public override string BaseURL { get; set; } = @"https://api.weather.gov/glossary";
}
