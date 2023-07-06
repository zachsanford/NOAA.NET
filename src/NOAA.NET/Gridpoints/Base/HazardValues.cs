// <copyright file="HazardValues.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Gridpoints.Base;

/// <summary>
/// A representation of a Hazard Values object.
/// </summary>
public class HazardValues
{
    /// <summary>
    /// Gets or sets the Valid Times Property.
    /// </summary>
    public string? ValidTimes { get; set; }

    /// <summary>
    /// Gets or sets an array of <see cref="HazardSubvalues"/>.
    /// </summary>
    public HazardSubvalues[]? Values { get; set; }
}
