// <copyright file="Weather.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace NOAA.NET.Gridpoints.Base;

/// <summary>
/// A representation of a Weather object.
/// </summary>
public class Weather
{
    /// <summary>
    /// Gets or sets the Values property.
    /// </summary>
    [JsonPropertyName("values")]
    public WeatherValues[]? Values { get; set; }
}
