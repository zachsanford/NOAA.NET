// <copyright file="Feature.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Aviation.Cwsus;

/// <summary>
/// A representation of a CWSUS Feature.
/// </summary>
public class Feature
{
    /// <summary>
    /// Gets or sets the Type Property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="Geometry"/> Property.
    /// </summary>
    public Geometry? Geometry { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="Properties"/> Property.
    /// </summary>
    public Properties? Properties { get; set; }
}
