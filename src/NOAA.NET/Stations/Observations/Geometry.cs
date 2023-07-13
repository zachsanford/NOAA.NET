// <copyright file="Geometry.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Stations.Observations;

/// <summary>
/// A representation of a GeoJsonGeometry
/// object.
/// </summary>
public class Geometry
{
    /// <summary>
    /// Gets or sets the Type property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the Coordinates collection
    /// property.
    /// </summary>
    public float[]? Coordinates { get; set; }
}
