// <copyright file="WeatherVisibility.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Gridpoints.Base;

/// <summary>
/// A representation of a <see cref="Weather"/>
/// object's Visibility object.
/// </summary>
public class WeatherVisibility
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
