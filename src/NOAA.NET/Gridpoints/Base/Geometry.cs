// <copyright file="Geometry.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Gridpoints.Base;

/// <summary>
/// A GeoJSON geometry object. Please refer to IETF RFC 7946
/// for information on the GeoJSON format.
/// </summary>
public class Geometry
{
    /// <summary>
    /// Gets or sets the Type property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the Coordinates collection property.
    /// </summary>
    public float[][][]? Coordinates { get; set; }
}
