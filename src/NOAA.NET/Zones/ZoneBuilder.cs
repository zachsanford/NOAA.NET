// <copyright file="ZoneBuilder.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Types;

namespace NOAA.NET.Zones;

/// <summary>
/// Builder class for the Zones Endpoint.
/// </summary>
public class ZoneBuilder
{
    /// <summary>
    /// Gets or sets the Zone ID property.
    /// </summary>
    public string? ZoneId { get; set; }

    /// <summary>
    /// Gets or sets the Zone Type property.
    /// </summary>
    public Zone? Type { get; set; }

    /// <summary>
    /// Gets or sets the latitude and longitude coordinates property.
    /// The points are a <see cref="float"/> in a <see cref="string"/>
    /// format separated by a comma. They are formatted up to the
    /// sixth decimal value.
    /// <example>
    /// For example:
    /// <code>
    /// OptionsBuilder.Point = "39.952583,-75.165222"
    /// </code>
    /// </example>
    /// </summary>
    public string? Point { get; set; }

    /// <summary>
    /// Gets or sets the boolean flag for the Include
    /// Geometry property.
    /// </summary>
    public bool? IncludeGeometry { get; set; } = false;

    /// <summary>
    /// Gets or sets the Limit property.
    /// </summary>
    public int? Limit { get; set; } = 50;
}
