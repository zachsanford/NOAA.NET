// <copyright file="WeatherVisibility.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Gridpoints;

/// <summary>
/// A representation of a <see cref="Weather"/>
/// object's Visibility object.
/// </summary>
public class WeatherVisibility
{
    /// <summary>
    /// Gets or sets the Unit Code Property.
    /// </summary>
    public string? UnitCode { get; set; }

    /// <summary>
    /// Gets or sets the Value Property.
    /// </summary>
    public float? Value { get; set; }
}
