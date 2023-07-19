// <copyright file="RelativeLocationProperties.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Points;

/// <summary>
/// A representation of a Property object
/// underneath the Relative Location object.
/// </summary>
public class RelativeLocationProperties
{
    /// <summary>
    /// Gets or sets the City property.
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Gets or sets the State property.
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Points.Distance"/>
    /// property.
    /// </summary>
    public Distance? Distance { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Points.Bearing"/>
    /// property.
    /// </summary>
    public Bearing? Bearing { get; set; }
}
