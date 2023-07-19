// <copyright file="PointsBuilder.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Points;

/// <summary>
/// Builder class for the Points Endpoint.
/// </summary>
public sealed class PointsBuilder
{
    /// <summary>
    /// Gets or sets the latitude and longitude coordinates property.
    /// The points are a <see cref="float"/> in a <see cref="string"/>
    /// format separated by a comma. They are formatted up to the
    /// fourth decimal value.
    /// <example>
    /// For example:
    /// <code>
    /// PointsBuilder.Point = "39.9525,-75.1652"
    /// </code>
    /// </example>
    /// </summary>
    public required string Point { get; set; }
}
