// <copyright file="Period.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;

namespace NOAA.NET.Gridpoints.Forecast;

/// <summary>
/// A representation of a forecast period object.
/// </summary>
public class Period
{
    /// <summary>
    /// Gets or sets the Number property.
    /// </summary>
    public int? Number { get; set; }

    /// <summary>
    /// Gets or sets the Name property.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the Start Time property.
    /// </summary>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// Gets or sets the End Time property.
    /// </summary>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// Gets or sets the Is Daytime property.
    /// </summary>
    public bool? IsDaytime { get; set; }

    /// <summary>
    /// Gets or sets the Temperature property.
    /// </summary>
    public int? Temperature { get; set; }

    /// <summary>
    /// Gets or sets the Temperature Unit property.
    /// </summary>
    public string? TemperatureUnit { get; set; }

    /// <summary>
    /// Gets or sets the Temperature Trend property.
    /// </summary>
    public string? TemperatureTrend { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="NOAA.NET.Gridpoints.Forecast.ProbabilityOfPrecipitation"/>
    /// property.
    /// </summary>
    public ProbabilityOfPrecipitation? ProbabilityOfPrecipitation { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="DewPoint"/> property.
    /// </summary>
    public DewPoint? DewPoint { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="NOAA.NET.Gridpoints.Forecast.RelativeHumidity"/>
    /// property.
    /// </summary>
    public RelativeHumidity? RelativeHumidity { get; set; }

    /// <summary>
    /// Gets or sets the Wind Speed property.
    /// </summary>
    public string? WindSpeed { get; set; }

    /// <summary>
    /// Gets or sets the Wind Direction property.
    /// </summary>
    public string? WindDirection { get; set; }

    /// <summary>
    /// Gets or sets the Icon URL property.
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// Gets or sets the Short Forecast property.
    /// </summary>
    public string? ShortForecast { get; set; }

    /// <summary>
    /// Gets or sets the Detailed Forecast property.
    /// </summary>
    public string? DetailedForecast { get; set; }
}
