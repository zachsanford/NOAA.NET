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
    /// Gets or sets the Number Property.
    /// </summary>
    public int? Number { get; set; }

    /// <summary>
    /// Gets or sets the Name Property.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the Start Time Property.
    /// </summary>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// Gets or sets the End Time Property.
    /// </summary>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// Gets or sets the Is Daytime Property.
    /// </summary>
    public bool? IsDaytime { get; set; }

    /// <summary>
    /// Gets or sets the Temperature Property.
    /// </summary>
    public int? Temperature { get; set; }

    /// <summary>
    /// Gets or sets the Temperature Unit Property.
    /// </summary>
    public string? TemperatureUnit { get; set; }

    /// <summary>
    /// Gets or sets the Temperature Trend Property.
    /// </summary>
    public string? TemperatureTrend { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="NOAA.NET.Gridpoints.Forecast.ProbabilityOfPrecipitation"/>
    /// Property.
    /// </summary>
    public ProbabilityOfPrecipitation? ProbabilityOfPrecipitation { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="DewPoint"/> Property.
    /// </summary>
    public DewPoint? DewPoint { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="NOAA.NET.Gridpoints.Forecast.RelativeHumidity"/>
    /// Property.
    /// </summary>
    public RelativeHumidity? RelativeHumidity { get; set; }

    /// <summary>
    /// Gets or sets the Wind Speed Property.
    /// </summary>
    public string? WindSpeed { get; set; }

    /// <summary>
    /// Gets or sets the Wind Direction Property.
    /// </summary>
    public string? WindDirection { get; set; }

    /// <summary>
    /// Gets or sets the Icon URL Property.
    /// </summary>
    public string? Icon { get; set; }

    /// <summary>
    /// Gets or sets the Short Forecast Property.
    /// </summary>
    public string? ShortForecast { get; set; }

    /// <summary>
    /// Gets or sets the Detailed Forecast Property.
    /// </summary>
    public string? DetailedForecast { get; set; }
}
