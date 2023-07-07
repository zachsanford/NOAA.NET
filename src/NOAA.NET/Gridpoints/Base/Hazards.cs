// <copyright file="Hazards.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Gridpoints.Base;

/// <summary>
/// A representation of a Hazards object.
/// </summary>
public class Hazards
{
    /// <summary>
    /// Gets or sets the Unit of Measurment
    /// property.
    /// </summary>
    public string? Uom { get; set; }

    /// <summary>
    /// Gets or sets an array of <see cref="HazardValues"/>.
    /// </summary>
    public HazardValues[]? Values { get; set; }
}