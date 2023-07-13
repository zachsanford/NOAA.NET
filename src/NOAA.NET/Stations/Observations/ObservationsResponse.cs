// <copyright file="ObservationsResponse.cs" company="Zach Sanford">
// Copyright (c) Zach Sanford. All rights reserved.
// </copyright>

namespace NOAA.NET.Stations.Observations;

/// <summary>
/// A representation of the Stations\Observations
/// Endpoint response.
/// </summary>
public class ObservationsResponse
{
    /// <summary>
    /// Gets or sets the Context object
    /// property.
    /// </summary>
    public object[]? Context { get; set; }

    /// <summary>
    /// Gets or sets the Type property.
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Gets or sets the Feature collection
    /// property.
    /// </summary>
    public Feature[]? Features { get; set; }
}