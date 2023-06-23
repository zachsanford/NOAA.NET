// <copyright file="Properties.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;
using System.Text.Json.Serialization;

namespace NOAA.NET.Zones;

/// <summary>
/// An object summarization of the properties
/// of a zone.
/// </summary>
public class Properties
{
    /// <summary>
    /// Gets or sets a geometry represented in
    /// Well-Known Text (WKT) format.
    /// </summary>
    public string? Geometry { get; set; }

    /// <summary>
    /// Gets or sets the unique id of the zone
    /// properties collection.
    /// </summary>
    [JsonPropertyName("@id")]
    public string? MainId { get; set; }

    /// <summary>
    /// Gets or sets the type of the zone
    /// properties collection.
    /// </summary>
    [JsonPropertyName("@type")]
    public string? MainType { get; set; }

    /// <summary>
    /// Gets or sets the Id Property.
    /// </summary>
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the Type Property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the Name Property.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the Effective Date Property.
    /// </summary>
    public DateTime? EffectiveDate { get; set; }

    /// <summary>
    /// Gets or sets the Expiration Date Property.
    /// </summary>
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// Gets or sets the three-letter identifier
    /// for a NWS office.
    /// </summary>
    public string[]? CWA { get; set; }

    /// <summary>
    /// Gets or sets the Forecast Offices Property.
    /// </summary>
    public string[]? ForecastOffices { get; set; }

    /// <summary>
    /// Gets or sets the Time Zone Property.
    /// </summary>
    public string[]? TimeZone { get; set; }

    /// <summary>
    /// Gets or sets the Observation
    /// Stations Property.
    /// </summary>
    public string[]? ObservationStations { get; set; }

    /// <summary>
    /// Gets or sets the Radar Station Property.
    /// </summary>
    public string? RadarStation { get; set; }
}