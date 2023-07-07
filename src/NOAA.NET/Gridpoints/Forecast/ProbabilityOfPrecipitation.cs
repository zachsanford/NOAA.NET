// <copyright file="ProbabilityOfPrecipitation.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Gridpoints.Forecast;

/// <summary>
/// A representation of a Probability of
/// Precipitation object.
/// </summary>
public class ProbabilityOfPrecipitation
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
