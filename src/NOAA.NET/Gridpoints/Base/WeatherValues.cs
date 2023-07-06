// <copyright file="WeatherValues.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Gridpoints.Base;

/// <summary>
/// A representation of a Value object in the
/// <see cref="Weather"/> object.
/// </summary>
public class WeatherValues
{
    /// <summary>
    /// Gets or sets the Valid Time Property.
    /// </summary>
    public string? ValidTime { get; set; }

    /// <summary>
    /// Gets or sets the array of <see cref="Value"/> Property.
    /// </summary>
    public Value[]? Value { get; set; }
}
