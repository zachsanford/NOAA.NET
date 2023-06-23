// <copyright file="Feature.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Zones;

/// <summary>
/// A representation of a GeoJSON feature. Please
/// refer to IETF RFC 7946 for information on the
/// GeoJSON format.
/// </summary>
public class Feature
{
    /// <summary>
    /// Gets or sets the Id of the feature.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the Type Property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the collection of <see cref="Properties"/>.
    /// </summary>
    public Properties? Properties { get; set; }
}
