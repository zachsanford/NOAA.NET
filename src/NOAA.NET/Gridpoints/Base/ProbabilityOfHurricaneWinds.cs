// <copyright file="ProbabilityOfHurricaneWinds.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Gridpoints.Base;

/// <summary>
/// A representation of a ProbabilityOfHurricaneWinds object.
/// </summary>
public class ProbabilityOfHurricaneWinds
{
    /// <summary>
    /// Gets or sets the Unit of Measurment
    /// property.
    /// </summary>
    public string? Uom { get; set; }

    /// <summary>
    /// Gets or sets an array of <see cref="Values"/>.
    /// </summary>
    public Values[]? Values { get; set; }
}