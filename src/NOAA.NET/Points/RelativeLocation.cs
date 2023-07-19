// <copyright file="RelativeLocation.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System.Text.Json.Serialization;

namespace NOAA.NET.Points;

/// <summary>
/// A representation of a RelativeLocationGeoJson
/// object.
/// </summary>
public class RelativeLocation
{
    /// <summary>
    /// Gets or sets the Type property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Points.Geometry"/>
    /// property.
    /// </summary>
    public Geometry? Geometry { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Points.RelativeLocationProperties"/>
    /// property. Represents the Properties.
    /// </summary>
    [JsonPropertyName("properties")]
    public RelativeLocationProperties? Properties { get; set; }
}
