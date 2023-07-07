// <copyright file="GridpointsForecastBuilder.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

using NOAA.NET.Gridpoints.Types;

namespace NOAA.NET.Gridpoints.Forecast;

/// <summary>
/// Builder class for the Gridpoints Forecast
/// Endpoint.
/// </summary>
public sealed class GridpointsForecastBuilder
{
    /// <summary>
    /// Gets or sets the Units in textual output property.
    /// Defaults to US if left unspecified.
    /// </summary>
    public Units? Units { get; set; } = Types.Units.US;

    /// <summary>
    /// Gets or sets a value indicating whether the
    /// Hourly flag is enabled for the Hourly Endpoint.
    /// Defaults to false if left unspecified.
    /// </summary>
    public bool IsHourly { get; set; } = false;

    /// <summary>
    /// Gets or sets the <see cref="WFO"/> type, for the
    /// Weather Forecast Office property.
    /// </summary>
    public required WFO Wfo { get; set; }

    /// <summary>
    /// Gets or sets the forecast grid X coordinate
    /// property.
    /// </summary>
    public required byte XCoordinate { get; set; }

    /// <summary>
    /// Gets or sets the forecast grid Y coordinate
    /// property.
    /// </summary>
    public required byte YCoordinate { get; set; }
}
