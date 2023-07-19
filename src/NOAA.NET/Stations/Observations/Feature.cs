// <copyright file="Feature.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Stations.Observations;

/// <summary>
/// A representation of a GeoJsonFeature object.
/// </summary>
public class Feature
{
    /// <summary>
    /// Gets or sets the Id property.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the Type property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.Geometry"/>
    /// property.
    /// </summary>
    public Geometry? Geometry { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.Properties"/>
    /// property.
    /// </summary>
    public Properties? Properties { get; set; }
}
