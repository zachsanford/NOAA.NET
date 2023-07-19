// <copyright file="Properties.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Stations;

/// <summary>
/// A representation of an ObservationStation
/// object.
/// </summary>
public class Properties
{
    /// <summary>
    /// Gets or sets the unique ID for this
    /// object.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the type property for
    /// this object.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="NOAA.NET.Stations.Elevation"/>
    /// properties of this station.
    /// </summary>
    public Elevation? Elevation { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for
    /// this station property.
    /// </summary>
    public string? StationIdentifier { get; set; }

    /// <summary>
    /// Gets or sets the name of this station
    /// property.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the time zone of this
    /// station property.
    /// </summary>
    public string? TimeZone { get; set; }

    /// <summary>
    /// Gets or sets a link to the NWS public
    /// forecast zone containing this station
    /// property.
    /// </summary>
    public string? Forecast { get; set; }

    /// <summary>
    /// Gets or sets a link to the NWS county zone
    /// containing this station property.
    /// </summary>
    public string? County { get; set; }

    /// <summary>
    /// Gets or sets a link to the NWS fire weather
    /// forecast zone containing this station property.
    /// </summary>
    public string? FireWeatherZone { get; set; }
}
