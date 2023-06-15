// <copyright file="Geometry.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Alerts;

/// <summary>
/// Represents a GeoJSON geometry object. Please refer
/// to IETF RFC 7946 for more information.
/// </summary>
public class Geometry
{
    /// <summary>
    /// Gets or sets the type of geometry.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the coordinates of the geometry.
    /// </summary>
    public float[][][]? Coordinates { get; set; }
}
