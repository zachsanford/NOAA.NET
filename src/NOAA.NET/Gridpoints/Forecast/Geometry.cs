// <copyright file="Geometry.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Gridpoints.Forecast;

/// <summary>
/// A representation of a GeoJSON geometry object.
/// Please refer to IETF RFC 7946 for information
/// on the GeoJSON format.
/// </summary>
public class Geometry
{
    /// <summary>
    /// Gets or sets the Type Property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the array of Coordinates.
    /// </summary>
    public float[][][]? Coordinates { get; set; }
}
