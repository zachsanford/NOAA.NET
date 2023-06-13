// <copyright file="Feature.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Alerts;

/// <summary>
/// A representation of a GeoJSON feature. Please
/// refer to IETF RFC 7946 for more information.
/// </summary>
public class Feature
{
    /// <summary>
    /// Gets or sets the unique id of the feature.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the feature type.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="Geometry"/> of the feature.
    /// </summary>
    public Geometry? Geometry { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="Properties"/> of the feature.
    /// </summary>
    public Properties? Properties { get; set; }
}
