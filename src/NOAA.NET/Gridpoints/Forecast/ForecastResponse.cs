// <copyright file="ForecastResponse.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Gridpoints.Forecast;

/// <summary>
/// A representation of a GeoJSON Feature.
/// Please refer to IETF RFC 7946 for
/// information of the GeoJSON format.
/// </summary>
public class ForecastResponse
{
    /// <summary>
    /// Gets or sets the Context object Property.
    /// </summary>
    public object[]? Context { get; set; }

    /// <summary>
    /// Gets or sets the Type Property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="NOAA.NET.Gridpoints.Forecast.Geometry"/> Property.
    /// </summary>
    public Geometry? Geometry { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="NOAA.NET.Gridpoints.Forecast.Properties"/> Property.
    /// </summary>
    public Properties? Properties { get; set; }
}
