// <copyright file="Properties.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Points;

/// <summary>
/// A representation of a Point
/// object.
/// </summary>
public class Properties
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
    /// Gets or sets the NWS Forecast
    /// Office Id property.
    /// </summary>
    public string? Cwa { get; set; }

    /// <summary>
    /// Gets or sets the Forecast Office
    /// URL property.
    /// </summary>
    public string? ForecastOffice { get; set; }

    /// <summary>
    /// Gets or sets the NWS Forecast Office
    /// Id property.
    /// </summary>
    public string? GridId { get; set; }

    /// <summary>
    /// Gets or sets the Grid's X
    /// Coordinate property.
    /// </summary>
    public int? GridX { get; set; }

    /// <summary>
    /// Gets or sets the Grid's Y
    /// Coordinate property.
    /// </summary>
    public int? GridY { get; set; }

    /// <summary>
    /// Gets or sets the Forecast URL
    /// property.
    /// </summary>
    public string? Forecast { get; set; }

    /// <summary>
    /// Gets or sets the Forecast Hourly URL
    /// property.
    /// </summary>
    public string? ForecastHourly { get; set; }

    /// <summary>
    /// Gets or sets the Forecast Grid
    /// Data URL property.
    /// </summary>
    public string? ForecastGridData { get; set; }

    /// <summary>
    /// Gets or sets the Observation Stations
    /// URL property.
    /// </summary>
    public string? ObservationStations { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Points.RelativeLocation"/>
    /// property.
    /// </summary>
    public RelativeLocation? RelativeLocation { get; set; }

    /// <summary>
    /// Gets or sets the Forecast Zone URL
    /// property.
    /// </summary>
    public string? ForecastZone { get; set; }

    /// <summary>
    /// Gets or sets the County URL
    /// property.
    /// </summary>
    public string? County { get; set; }

    /// <summary>
    /// Gets or sets the Fire Weather Zone
    /// URL property.
    /// </summary>
    public string? FireWeatherZone { get; set; }

    /// <summary>
    /// Gets or sets the Time Zone property.
    /// </summary>
    public string? TimeZone { get; set; }

    /// <summary>
    /// Gets or sets the Radar Station property.
    /// </summary>
    public string? RadarStation { get; set; }
}
