// <copyright file="GridpointsForecastResponse.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Gridpoints.Forecast;

/// <summary>
/// A representation of a GeoJSON Feature.
/// Please refer to IETF RFC 7946 for
/// information of the GeoJSON format.
/// </summary>
public class GridpointsForecastResponse
{
    /// <summary>
    /// Gets or sets the Context object property.
    /// </summary>
    public object[]? Context { get; set; }

    /// <summary>
    /// Gets or sets the Type property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="NOAA.NET.Gridpoints.Forecast.Geometry"/> property.
    /// </summary>
    public Geometry? Geometry { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="NOAA.NET.Gridpoints.Forecast.Properties"/> property.
    /// </summary>
    public Properties? Properties { get; set; }
}
