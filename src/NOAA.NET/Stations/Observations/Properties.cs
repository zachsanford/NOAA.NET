// <copyright file="Properties.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;

namespace NOAA.NET.Stations.Observations;

/// <summary>
/// A representation of an Observation object.
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
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.Elevation"/>
    /// property.
    /// </summary>
    public Elevation? Elevation { get; set; }

    /// <summary>
    /// Gets or sets the Station property.
    /// </summary>
    public string? Station { get; set; }

    /// <summary>
    /// Gets or sets the Timestamp property.
    /// </summary>
    public DateTime? Timestamp { get; set; }

    /// <summary>
    /// Gets or sets the Raw Message property.
    /// </summary>
    public string? RawMessage { get; set; }

    /// <summary>
    /// Gets or sets the Text Description property.
    /// </summary>
    public string? TextDescription { get; set; }

    /// <summary>
    /// Gets or sets the Icon property.
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// Gets or sets the Present Weather collection property.
    /// </summary>
    public object[]? PresentWeather { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.Temperature"/>
    /// property.
    /// </summary>
    public Temperature? Temperature { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.Dewpoint"/>
    /// property.
    /// </summary>
    public Dewpoint? Dewpoint { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.WindDirection"/>
    /// property.
    /// </summary>
    public WindDirection? WindDirection { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.WindSpeed"/>
    /// property.
    /// </summary>
    public WindSpeed? WindSpeed { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.WindGust"/>
    /// property.
    /// </summary>
    public WindGust? WindGust { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.BarometricPressure"/>
    /// property.
    /// </summary>
    public BarometricPressure? BarometricPressure { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.SeaLevelPressure"/>
    /// property.
    /// </summary>
    public SeaLevelPressure? SeaLevelPressure { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.Visibility"/>
    /// property.
    /// </summary>
    public Visibility? Visibility { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.MaxTemperatureLast24Hours"/>
    /// property.
    /// </summary>
    public MaxTemperatureLast24Hours? MaxTemperatureLast24Hours { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.MinTemperatureLast24Hours"/>
    /// property.
    /// </summary>
    public MinTemperatureLast24Hours? MinTemperatureLast24Hours { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.PrecipitationLastHour"/>
    /// property.
    /// </summary>
    public PrecipitationLastHour? PrecipitationLastHour { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.PrecipitationLast3Hours"/>
    /// property.
    /// </summary>
    public PrecipitationLast3Hours? PrecipitationLast3Hours { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.PrecipitationLast6Hours"/>
    /// property.
    /// </summary>
    public PrecipitationLast6Hours? PrecipitationLast6Hours { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.RelativeHumidity"/>
    /// property.
    /// </summary>
    public RelativeHumidity? RelativeHumidity { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.WindChill"/>
    /// property.
    /// </summary>
    public WindChill? WindChill { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.HeatIndex"/>
    /// property.
    /// </summary>
    public HeatIndex? HeatIndex { get; set; }

    /// <summary>
    /// Gets or sets the
    /// <see cref="NOAA.NET.Stations.Observations.CloudLayer"/>
    /// collection property.
    /// </summary>
    public CloudLayer[]? CloudLayers { get; set; }
}
