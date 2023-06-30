// <copyright file="HeatIndex.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Gridpoints;

/// <summary>
/// A representation of a HeatIndex object.
/// </summary>
public class HeatIndex
{
    /// <summary>
    /// Gets or sets the Unit of Measurment
    /// Property.
    /// </summary>
    public string? Uom { get; set; }

    /// <summary>
    /// Gets or sets an array of <see cref="Values"/>.
    /// </summary>
    public Values[]? Values { get; set; }
}