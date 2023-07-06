// <copyright file="Properties.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using System;

namespace NOAA.NET.Gridpoints.Forecast;

/// <summary>
/// A representation of a multi-day forecast
/// for a 2.5km grid square object.
/// </summary>
public class Properties
{
    /// <summary>
    /// Gets or sets the Updated Property.
    /// </summary>
    public DateTime? Updated { get; set; }

    /// <summary>
    /// Gets or sets the Units Property.
    /// </summary>
    public string? Units { get; set; }

    /// <summary>
    /// Gets or sets the Forecast Generator Property.
    /// </summary>
    public string? ForecastGenerator { get; set; }

    /// <summary>
    /// Gets or sets the Generated At Property.
    /// </summary>
    public DateTime? GeneratedAt { get; set; }

    /// <summary>
    /// Gets or sets the Update Time Property.
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// Gets or sets the Valid Times Property.
    /// </summary>
    public string? ValidTimes { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="NOAA.NET.Gridpoints.Forecast.Elevation"/> Property.
    /// </summary>
    public Elevation? Elevation { get; set; }

    /// <summary>
    /// Gets or sets an array of <see cref="Period"/>.
    /// </summary>
    public Period[]? Periods { get; set; }
}
