// <copyright file="RelativeHumidity.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Gridpoints.Forecast;

/// <summary>
/// A representation of a Relative Humidity object.
/// </summary>
public class RelativeHumidity
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
