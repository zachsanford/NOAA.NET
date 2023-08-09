// <copyright file="ZonesBaseResponse.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Zones.Base;

/// <summary>
/// A GeoJSON feature collection. Please refer
/// to IETF RFC 7946 for information on the
/// GeoJSON format.
/// </summary>
public class ZonesBaseResponse
{
    /// <summary>
    /// Gets or sets the Type property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the collection of <see cref="Feature"/>.
    /// </summary>
    public Feature[]? Features { get; set; }
}
