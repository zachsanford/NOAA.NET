// <copyright file="Value.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace NOAA.NET.Gridpoints.Base;

/// <summary>
/// A representation of a Weather Value object.
/// </summary>
public class Value
{
    /// <summary>
    /// Gets or sets the Coverage Property.
    /// </summary>
    public string? Coverage { get; set; }

    /// <summary>
    /// Gets or sets the Weather Property.
    /// </summary>
    public string? Weather { get; set; }

    /// <summary>
    /// Gets or sets the Intensity Property.
    /// </summary>
    public object? Intensity { get; set; }

    /// <summary>
    /// Gets or sets the Visibility Property.
    /// </summary>
    [JsonPropertyName("visibility")]
    public WeatherVisibility? Visibility { get; set; }

    /// <summary>
    /// Gets or sets the array of Attributes Property.
    /// </summary>
    public object[]? Attributes { get; set; }
}
