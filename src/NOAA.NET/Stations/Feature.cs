// <copyright file="Feature.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Stations;

/// <summary>
/// A representation of a GeoJSON feature.
/// Please refer to the IETF RFC 7946 for
/// information on the GeoJSON format.
/// </summary>
public class Feature
{
    /// <summary>
    /// Gets or sets the unique ID property.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the type property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="NOAA.NET.Stations.Geometry"/>
    /// property.
    /// </summary>
    public Geometry? Geometry { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="NOAA.NET.Stations.Properties"/>
    /// property.
    /// </summary>
    public Properties? Properties { get; set; }
}
