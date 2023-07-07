// <copyright file="StationsResponse.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Stations;

/// <summary>
/// A representation of the Stations Endpoint
/// response.
/// </summary>
public class StationsResponse
{
    /// <summary>
    /// Gets or sets a object array as a
    /// context property.
    /// </summary>
    public object[]? Context { get; set; }

    /// <summary>
    /// Gets or sets the type property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="NOAA.NET.Stations.Feature"/>
    /// collection property.
    /// </summary>
    public Feature[]? Features { get; set; }

    /// <summary>
    /// Gets or sets the collection of observed station
    /// URLs propery.
    /// </summary>
    public string[]? ObservationStations { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="NOAA.NET.Stations.Pagination"/>
    /// property.
    /// </summary>
    public Pagination? Pagination { get; set; }
}
