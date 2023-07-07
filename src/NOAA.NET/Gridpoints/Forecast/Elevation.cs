// <copyright file="Elevation.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Gridpoints.Forecast;

/// <summary>
/// A representation of an Elevation object.
/// </summary>
public class Elevation
{
    /// <summary>
    /// Gets or sets the Unit Code property.
    /// </summary>
    public string? UnitCode { get; set; }

    /// <summary>
    /// Gets or sets the Value property.
    /// </summary>
    public float? Value { get; set; }
}
